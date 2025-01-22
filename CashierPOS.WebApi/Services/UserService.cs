using Microsoft.AspNetCore.Identity;
using CashierPOS.WebApi.DataValidation;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Models.EntityModel;
using CashierPOS.Model.Models.Response;
using Microsoft.EntityFrameworkCore;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.User;
using CashierPOS.WebApi.Interfaces;

namespace CashierPOS.WebApi.Services;

public class UserService : IUserService
{
    public readonly IRepository<User> _repo;
    private readonly IApprovalStrategy _approvalStrategy;
    public IRepository<Company> _repoCompany;
    public IRepository<Role> _repoRole;
    public IRepository<UserLog> _repoUserLog;
    public IRepository<ChangeShift> _repoChangeShift;

    public UserService(IRepository<User> repository,
                       IRepository<Company> repoCom,
                       IRepository<Role> repoRole,
                       IRepository<UserLog> userLog,
                       IRepository<ChangeShift> repoChangeShift,
                       IApprovalStrategy approvalStrategy)
    {
        _repo = repository;
        _repoCompany = repoCom;
        _repoRole = repoRole;
        _repoUserLog = userLog;
        _repoChangeShift = repoChangeShift;
        _approvalStrategy = approvalStrategy;
    }

    private string _prefix { get; set; } = "RAE";
    public Response<string> Create(UserCreateReq request)
    {
        try
        {
            var dataErrors = DataValidation<UserCreateReq>.ValidateDynamicTypes(request);
            if (dataErrors.Count > 0)
            {
                return Response<string>.Fail(data: dataErrors.First().ToString());
            }
            var company = _repoCompany.GetQueryable().Include(e => e.Users).FirstOrDefault(e => e.Id == request.Company_Id);
            if (company == null) return Response<string>.Fail("Company does not exiting.");

            var existingUsernames = company.Users!.Select(u => u.UserName).ToList();

            // Generate the next username
            var userName = GenerateNextUsername(existingUsernames);

            var hasher = new PasswordHasher<string>();
            //var passwordHash = hasher.HashPassword(request.UserName, request.Password);
            var passwordHash = hasher.HashPassword(userName, request.Password);

            var user = new User()
            {
                Id = Guid.NewGuid().ToString(),
                Company_Id = request.Company_Id,
                Name = request.Name,
                Password = passwordHash,
                UserName = userName,
                Address = request.Address,
                Contact = request.Contact,
                Email = request.Email,
                Gender = request.Gender.ToString(),
                Image = request.Image,
                //Role_Id = request.Role_Id,
                User_Role = request.UserRole.ToString().ToUpper(),
                Status = Status.Enable,
                Create_At = DateTime.Now,
                Is_Deleted = false
            };

            _repo.Add(user);
            return _repo.SaveChanges() > 0 ? Response<string>.Success(null, 1, "Create Successfully")
                                          : Response<string>.Fail("Fail to create.");
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    private string GenerateNextUsername(List<string> existingUsernames)
    {
        var maxNumeric = existingUsernames
            .Select(username => int.TryParse(username, out var num) ? num : 0)
            .DefaultIfEmpty(0)
            .Max();

        var nextNumeric = maxNumeric + 1;
        var nextUsername = nextNumeric.ToString("D4");

        return nextUsername;
    }

    public Response<UserResponse?> Read(Key key)
    {
        try
        {
            return Response<UserResponse>.Success()!;
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    public Response<List<UserResponse>>? ReadAll()
    {
        try
        {
            return Response<List<UserResponse>>.Success();
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    private Response<List<UserResponse>>? GetAll()
    {
        try
        {
            var data = _repo.GetQueryable().Include(e => e.Company).Select(e => new UserResponse()
            {
                Id = e.Id,
                Name = e.Name,
                UserName = e.UserName,
                Password = e.Password,
                Address = e.Address,
                Image = e.Image,
                Contact = e.Contact,
                Company_Id = e.Company_Id,
                Company_Name = e.Company.Name,
                ExchangeRate = e.Company.Exchange_Rate,
                SaleExchangeRate = e.Company.SaleExchangeRate,
                Token = e.Token,
                //--Role_Id = e.Role_Id,
                User_Role = e.User_Role,
                //Role_Type = e.Role.Name,
                Is_Deleted = e.Is_Deleted,
            }).ToList();
            return Response<List<UserResponse>>.Success(data);
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    /*public Response<UserLogResponse?> GetLogin(UserLoginReq request)
    {
        try
        {
            var userName = request.UserId.ToUpper().Replace(_prefix, "");
            var user = GetAll()!.Result!
                       .FirstOrDefault(e => e.UserName.ToLower() == userName *//*request.UserId.ToLower()*//* && e.Is_Deleted == false);

            if (user == null)
            {
                return Response<UserLogResponse?>.NotFound("Incorrect user id or password");
            }
            var userLogs = _repoUserLog.GetAll().Where(e=>e.Action == ActionLog.LogIn);
            var userLogged = userLogs.FirstOrDefault(e=>e.User_Id==user.Id);
            if (userLogged != null)
            {
                return Response<UserLogResponse?>.Fail("User is being log");
            }
            //UpdatePasswordHashInDatabase(userName, request.Password);

            var hasher = new PasswordHasher<string>();
            var verifyResult = hasher.VerifyHashedPassword(user.UserName, user.Password, request.Password);

            if (verifyResult != PasswordVerificationResult.Success)
            {
                return Response<UserLogResponse?>.NotFound("Incorrect user id or password");
            }

            var posId = userLogs.Select(e=>e.PosId);

            user.Password = request.Password;

            var userLog = new UserLog()
            {
                PosId = posId,
                User_Id = user.Id,
                User_Name = _prefix + user.Id,
                User_Role = user.User_Role,
                LoginAt = DateTime.Now,
                Action = ActionLog.LogIn,
            };
            _repoUserLog.Add(userLog);
            _repoUserLog.SaveChanges();

            var userResponse = new UserLogResponse()
            {
                PosId = posId,
                UserLogId = userLog.Id,
                UserId = user.Id,
                Name = user.Name,
                Image = user.Image,
                UserName = user.UserName,
                CompanyId = user.Company_Id,
                ExchangeRate = user.ExchangeRate,
                ShiftStatus = ShiftStatus.Open,
                SaleExchangeRate = user.SaleExchangeRate,
            };
            return Response<UserLogResponse?>.Success(userResponse, 1, "Login Successfully.");

        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }*/
    public Response<UserLogResponse?> GetLogin(UserLoginReq request)
    {
        try
        {
            var userName = request.UserId.ToUpper().Replace(_prefix, "");
            
            var user = GetAll()!.Result!
                       .FirstOrDefault(e => e.UserName.ToLower() == userName && e.Is_Deleted == false);

            if (user == null)
            {
                return Response<UserLogResponse?>.NotFound("Incorrect user id or password");
            }

            var userLogs = _repoUserLog.GetAll().Where(e => e.Action == ActionLog.LogIn);
            var userLogged = userLogs.FirstOrDefault(e => e.User_Id == user.Id);

            if (userLogged != null)
            {
                return Response<UserLogResponse?>.Fail("User is being log");
            }
            // Update password hash
            //UpdatePasswordHashInDatabase(userName, request.Password);


            var hasher = new PasswordHasher<string>();
            var verifyResult = hasher.VerifyHashedPassword(user.UserName, user.Password, request.Password);

            if (verifyResult != PasswordVerificationResult.Success)
            {
                return Response<UserLogResponse?>.NotFound("Incorrect user id or password");
            }

            var existingPosIds = userLogs.Select(e => e.PosId).ToList();
            int posId = 1;

            while (existingPosIds.Contains(posId))
            {
                posId++;
            }

            user.Password = request.Password;

            var userLog = new UserLog()
            {
                PosId = posId,
                User_Id = user.Id,
                User_Name = _prefix + user.Id,
                User_Role = user.User_Role,
                LoginAt = DateTime.Now,
                Action = ActionLog.LogIn,
            };
            _repoUserLog.Add(userLog);
            _repoUserLog.SaveChanges();

            var userResponse = new UserLogResponse()
            {
                PosId = posId,
                UserLogId = userLog.Id,
                UserId = user.Id,
                Name = user.Name,
                Image = user.Image,
                UserName = user.UserName,
                CompanyId = user.Company_Id,
                ExchangeRate = user.ExchangeRate,
                ShiftStatus = ShiftStatus.Open,
                SaleExchangeRate = user.SaleExchangeRate,
            };

            return Response<UserLogResponse?>.Success(userResponse, 1, "Login Successfully.");
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    private void UpdatePasswordHashInDatabase(string userName, string newPassword)
    {
        // Hash the new password
        var hasher = new PasswordHasher<string>();
        string hashedPassword = hasher.HashPassword(userName, newPassword);
        // Find the user in the repository by username (assuming _repo is an instance of your repository)
        var userToUpdate = _repo.GetAll().FirstOrDefault(e => e.UserName == userName);

        if (userToUpdate != null)
        {
            // Update the password hash
            userToUpdate.Password = hashedPassword;

            // Save changes to the database
            _repo.Update(userToUpdate);
            _repo.SaveChanges();
        }
    }

    public Response<string> Update(UserUpdateReq req)
    {
        try
        {
            return Response<string>.Success();
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    public Response<string> Delete(Key key)
    {
        try
        {
            if (key == null) return Response<string>.Fail("Id required.");
            var user = _repo.GetById(key.Id!);
            if (user == null) return Response<string>.Fail("User not found.");

            _repo.Delete(user);
            return _repo.SaveChanges() > 0 ? Response<string>.Success() : Response<string>.Fail("Fail to delete.");
        }
        catch (Exception ex)
        {
            throw ex.InnerException!;
        }
    }

    public Response<string> GetLogout(UserLogoutReq request)
    {
        try
        {
            var userLogFound = _repoUserLog.GetAll().FirstOrDefault(e => e.Id == request.UserLogId! && e.Action != ActionLog.LogOut);

            if (userLogFound == null)
            {
                return Response<string>.Success(null, 0, "Logout Successfully.");
            }
            //var user = userLogFound.First();
            var changeShift = _repoChangeShift.GetAll().FirstOrDefault(e => e.UserLogId == userLogFound.Id);

            if (changeShift != null && changeShift?.Shift_Status == ShiftStatus.Open)
            {
                return Response<string>.Fail("Plase Close shift before logout.", null, 0);
            }

            userLogFound.LogoutAt = DateTime.Now;
            userLogFound.Action = ActionLog.LogOut;

            _repoUserLog.Update(userLogFound);
            int result = _repoUserLog.SaveChanges();

            return result > 0 ? Response<string>.Success(null, 1, "Logout Successfully.") : Response<string>.Fail("Failed");
        }
        catch (Exception ex)
        {
            _repo.Rollback();
            return Response<string>.Fail(ex.Message, null, 0);
        }
    }

     
    public Response<UserLogResponse> GetUserApproved(UserLoginReq request)
    {
        try
        {
            var userName = request.UserId.ToUpper().Replace(_prefix,"");
            //var user = GetAll()!.Result!.FirstOrDefault(e => e.UserName.ToLower() == request.UserId.ToLower() && e.Is_Deleted == false);
            var user = GetAll()!.Result!.FirstOrDefault(e => e.UserName.ToLower() == userName.ToLower() && e.Is_Deleted == false);

            if (user == null)
            {
                return Response<UserLogResponse>.NotFound("Incorrect Username.");
            }
            //UpdatePasswordHashInDatabase(userName, request.Password);
            var hasher = new PasswordHasher<string>();
            var verifyResult = hasher.VerifyHashedPassword(user.UserName, user.Password, request.Password);
            if (verifyResult != PasswordVerificationResult.Success)
            {
                return Response<UserLogResponse>.Fail("Incorrect Password.");
            }

            var result = new UserLogResponse();
            if (_approvalStrategy.CanApprove(user))
            {
                result = new UserLogResponse()
                {
                    UserId = user.Id,
                    UserName = userName,
                    Image = user.Image,
                    Name = user.Name,
                    CompanyId = user.Company_Id,
                    ExchangeRate = user.ExchangeRate,
                };
                return Response<UserLogResponse>.Success(result, 1, "Successfully");
            }
            else
            {
                return Response<UserLogResponse>.Fail("User does not have approval rights.");
            }
        }
        catch (Exception ex)
        {
            return Response<UserLogResponse>.Fail(ex.Message);
        }
    }

    /*public Response<UserLogResponse> GetUserReOpenShift(UserReponseShiftReq request)
    {
        try
        {
            var userLog = _repoUserLog.GetQueryable().Include(e=>e.User.Company)
                          .FirstOrDefault(e=>e.Id == request.UserLogId && e.Action==ActionLog.LogIn);

            if(userLog == null)
            {
                return Response<UserLogResponse>.Fail("Fail");
            }
            var dataReq = new UserLogoutReq()
            {
                //PosId = request.PosId,
                UserLogId = request.UserLogId,
            };
            var dataResponse = GetLogout(dataReq);
            int result = 0;
            var user = new UserLogResponse();

            if (dataResponse.Status==(int)ResponseStatus.Success)
            {
                var userlog = new UserLog()
                {
                   // PosId = 
                    User_Id = userLog.User.Id,
                    User_Name = userLog.User_Name,
                    User_Role = userLog.User_Role,
                    LoginAt = DateTime.Now,
                    Action = ActionLog.LogIn,
                };
                _repoUserLog.Add(userlog);
                result = _repoUserLog.SaveChanges();

                user = new UserLogResponse()
                {
                    PosId = userlog.Pos_Id,
                    UserLogId = userlog.Id,
                    UserId = userLog.Id,
                    Name = userLog.User.Name,
                    Image = userLog.User.Image,
                    UserName = userLog.User.UserName,
                    CompanyId = userLog.User.Company_Id,
                    ExchangeRate = userLog.User.Company.Exchange_Rate,
                    ShiftStatus = ShiftStatus.Open,
                };
            }
            return result > 0 ? Response<UserLogResponse>.Success(user, 1, "Successfully") 
                              : Response<UserLogResponse>.Fail();
        }catch (Exception ex)
        {
            _repo.Rollback();
            return Response<UserLogResponse>.Fail(ex.Message);
        }
    }*/
}


