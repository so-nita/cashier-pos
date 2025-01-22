using AutoMapper;
using Microsoft.EntityFrameworkCore;
using CashierPOS.WebApi.DataValidation;
using CashierPOS.WebApi.Interface;
using CashierPOS.WebApi.Interface.Product;
using CashierPOS.WebApi.Models.EntityModel;
using Microsoft.IdentityModel.Tokens;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.Product;
using CashierPOS.Model.Models.Response;
using CashierPOS.Model.Constants;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace CashierPOS.WebApi.Services;

public class ProductService : IProductService
{
    private readonly IRepository<Product> _repo;
    private readonly IRepository<SubCategory> _repoSubCate;
    private readonly IRepository<User> _repoUser;
    private readonly IRepository<ProductDiscount> _repoDiscount;
    private readonly IMapper _mapper;
    public ProductService(IRepository<Product> repo, IRepository<SubCategory> subcategory, IMapper mapper, IRepository<User> repoUser,IRepository<ProductDiscount> repoDiscount)
    {
        _repo = repo;
        _repoSubCate = subcategory;
        _mapper = mapper;
        _repoUser = repoUser;
        _repoDiscount = repoDiscount;
    }

    private Response<List<ProductResponse>>? GetAll()
    {
        try
        {
            var discountMap = _repoDiscount.GetQueryable()
                .Include(d => d.DiscountType)
                .Where(d => d.Status == Status.Enable)
                .ToDictionary(d => d.ProductId, d => d.DiscountType.DiscountPercent);

            var products = _repo.GetQueryable()
                .Include(c => c.SubCategory.Category.Menu)
                .Include(e => e.User);
            var data = new List<ProductResponse>();

            foreach (var e in products)
            {
                //var tax = CalculatePriceIncludingTax(e.Price, e.Tax);
                var discountPercentage = discountMap.ContainsKey(e.Id) ? discountMap[e.Id] : 0;
                var sizeValue = "";
                // Parse the JSON string and extract the desired value
                if (!string.IsNullOrEmpty(e.Size))
                {
                    var sizeJson = JArray.Parse(e.Size);
                    var firstOption = sizeJson?.FirstOrDefault()?["options"]?.FirstOrDefault()?["option"];
                    sizeValue = firstOption?.ToString();
                }
                var product = new ProductResponse()
                {
                    Id = e.Id,
                    Name = e.Name,
                    NameKh = e.NameKh,
                    Image = e.Image,
                    Price = e.Price,
                    Tax = CalculatePriceIncludingTax(e.Price, e.Tax),
                    Cost = e.Cost,
                    Code = e.Code,
                    Qty = e.Qty,
                    Size = sizeValue,
                    Brand = e.Brand?.ToUpper(),
                    Division_Id = e.SubCategory?.Category?.Menu?.DivisionId,
                    DiscountPercent = discountPercentage,
                    DiscountAmount = (discountPercentage * e.Price)/100,
                    Sub_Category_Id = e.Category_Id!,
                    Create_At = e.Create_At,
                    Status = e.Status.ToString(),
                    Description = e.Description,
                    Is_Deleted = e.Is_Deleted,
                };
                data.Add(product);
            }

            return Response<List<ProductResponse>>.Success(data, data.Count());
        }
        catch (Exception ex)
        {
            return Response<List<ProductResponse>>.Fail(ex.Message);
        }
    }

    public Response<List<ProductResponse>>? GetProductSell()
    {
        try
        {
            var data = _repo.GetQueryable()
                    .Include(c => c.SubCategory.Category.Menu)
                    .Include(e => e.User)
                    .Where(e=>e.Qty>0)
                    .Select(e => new ProductResponse()
                    {
                        Id = e.Id,
                        Name = e.Name,
                        NameKh = e.NameKh,
                        Image = e.Image,
                        Cost = e.Cost,
                        Code = e.Code,
                        Qty = e.Qty,
                        Price = e.Price,
                        Tax = CalculatePriceIncludingTax(e.Price, e.Tax),
                        Division_Id = e.SubCategory.Category.Menu.DivisionId,
                        Brand = e.Brand,
                        Sub_Category_Id = e.Category_Id,
                        //Sub_Category_Name = e.SubCategory.Name,
                        Create_At = e.Create_At,
                        Status = e.Status.ToString(),
                        Description = e.Description,
                        Is_Deleted = e.Is_Deleted,
                    }).ToList();

            return Response<List<ProductResponse>>.Success(data, data.Count(), "Successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return Response<List<ProductResponse>>.Fail();
        }
    }
    public Response<ProductResponse> Read(Key key)
    {
        try
        {
            var discount = _repoDiscount.GetQueryable().Include(e => e.DiscountType).Where(e => e.Status == Status.Enable);
            var product = _repo.GetQueryable()
                    .Include(c => c.SubCategory)
                    .Include(e => e.User)
                    .Where(e => e.Id==key.Id || e.Code==key.Code && e.Is_Deleted==false)
                    .Select(e => new ProductResponse()
                    {
                        Id = e.Id,
                        Name = e.Name,
                        NameKh = e.NameKh,
                        Image = e.Image,
                        Price = e.Price,
                        Tax = CalculatePriceIncludingTax(e.Price, e.Tax),
                        Cost = e.Cost,
                        Code = e.Code,
                        Qty = e.Qty,
                        //BrandCode = e.Brand_Code,
                        Brand = e.Brand,
                        //DiscountAmount
                        DiscountPercent = _repoDiscount.GetQueryable()
                            .Include(d => d.DiscountType)
                            .Where(d => d.ProductId == e.Id && d.Status == Status.Enable)
                            .Select(d => d.DiscountType.DiscountPercent)
                            .FirstOrDefault(),
                        /*Create_By = e.Create_By,
                        Create_By_Name = e.User.Name,
                        Company_Id = e.Company_Id,
                        Company_Name = e.Company_Name,*/
                        Sub_Category_Id = e.Category_Id,
                        //Sub_Category_Name = e.SubCategory.Name,
                        Create_At = e.Create_At,
                        Status = e.Status.ToString(),
                        Description = e.Description,
                        Is_Deleted = e.Is_Deleted,
                    }).ToList();
            if (!product.Any())
            {
                return Response<ProductResponse>.Fail(_message:"Product not found.");
            }
        
            return Response<ProductResponse>.Success(product.FirstOrDefault(), product.Count(),"Successfully");
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return Response<ProductResponse>.Fail();
        }
    }

    // Method to calculate price including tax based on tax type
    private static decimal CalculatePriceIncludingTax(decimal price, Tax tax)
    {
        switch (tax)
        {
            case Tax.VAT:
                return price * 0.1m; // Apply VAT (10%)
            case Tax.PLT:
                return price * 0.13m; // Apply PLT (VAT + 3%)
            case Tax.none:
            default:
                return price; // No tax
        }
    }

    public Response<List<ProductResponse>> ReadAll()
    {
        try
        {
            var products = GetAll()?.Result!.Where(e => e.Is_Deleted == false).ToList();

            return Response<List<ProductResponse>>.Success(products, products!.Count());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return Response<List<ProductResponse>>.Fail();
        }
    }

    public Response<string> Create(ProductCreateReq request)
    {
        try
        {
            var dataErrors = DataValidation<ProductCreateReq>.ValidateDynamicTypes(request);
            if (dataErrors.Count > 0)
            {
                return Response<string>.Fail(data: dataErrors.First().ToString());
            }
            var existProduct = _repo.GetQueryable().Where(e => e.Is_Deleted.Equals(false));

            /*var existCode = existProduct.FirstOrDefault(e => e.Code == request.Code);
            if (existCode != null)   
                return Response<string>.Conflict($"Code {request.Code} is existing.");*/

            var user = _repoUser.GetQueryable().Include(e=>e.Company)
                       .FirstOrDefault(e => e.Id == request.Create_By && e.Is_Deleted.Equals(false));

            if (user == null) 
                return Response<string>.Conflict($"User Id '{request.Create_By}' does not existing.");

            var checkCategory = _repoSubCate.GetById(request.Category_Id);

            if (checkCategory == null) 
                return Response<string>.Conflict($"Category Id '{request.Category_Id}' does not existing.");

            if(request.Price <= request.Cost)
            {
                return Response<string>.Fail($"Price must be more than Cost {request.Cost}");
            }

            var code = GenerateProductCode();

            var product = new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Code = code /*request.Code*/,
                Name = request.Name,
                NameKh = request.NameKh,
                Company_Id = user.Company_Id,
                Size = request.Size,
                //Company_Name = user.Company.Name,
                Create_By = user.Id,
                Qty = 0,
                Category_Id = request.Category_Id,
                Cost = request.Cost,
                Price = request.Price,
                Tax = request.Tax,
                Image = request.Image,
                Description = request.Description,
                Create_At = DateTime.Now,
                Status = Status.Enable.ToString(),
                Is_Deleted = false,
            };

            _repo.Add(product);
            return _repo.SaveChanges()>0 ? Response<string>.Success(null,1,"Create Successfully.")
                                         : Response<string>.Fail("Fail to Create.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return Response<string>.Fail("Fail to Create.");
        }
    }

    private static string GenerateProductCode()
    {
        // Generate a new GUID
        string guid = Guid.NewGuid().ToString("N");

        // Extract only numeric characters from the GUID
        string numericCode = Regex.Replace(guid, "[^0-9]", "");

        // Take the first 13 characters to get a 13-digit number
        numericCode = numericCode.Substring(0, Math.Min(numericCode.Length, 13));

        return numericCode;
    }

    public Response<string> Update(ProductUpdateReq request)
    {
        try
        {
            if(request.Id.IsNullOrEmpty() && request.Code.IsNullOrEmpty())
            {
                return Response<string>.Fail("Product identity is required.");
            }
            var productFound = _repo.GetQueryable().FirstOrDefault(e => e.Is_Deleted == false && e.Id == request.Id || e.Code == request.Code );

            if(productFound == null)
            {
                return Response<string>.Fail($"Product Id : {request.Id} not found.");
            }

            var data = _mapper.Map(request, productFound);
            data.Updated_At = DateTime.Now;

            _repo.Update(data);

            return _repo.SaveChanges() > 0 ? Response<string>.Success("Updated Successfully.") 
                                           : Response<string>.Fail("Failed to update.");
        }
        catch (Exception ex) 
        {

            return Response<string>.Fail("Fail to update.");
        }
    }

    public Response<string> Delete(Key key)
    {
        try
        {
            var found = _repo.GetQueryable().FirstOrDefault(e => e.Id == key.Id || e.Code.Equals(key.Code));
            if(found == null)   return Response<string>.NotFound("Product not found.");
        
            found.Is_Deleted = true;
            _repo.Update(found);
            //_repo.Delete(found);

            return _repo.SaveChanges() > 0 ? Response<string>.Success(null, 1, "Delete Successfully.")
                                           : Response<string>.Fail("Failed to delete.");
        }
        catch (Exception ex)
        {
            return Response<string>.Fail(ex.Message);
        }
    }


}
