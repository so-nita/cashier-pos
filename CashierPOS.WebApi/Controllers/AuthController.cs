using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using CashierPOS.WebApi.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CashierPOS.Model.Models;
using CashierPOS.Model.Models.Constant;
using CashierPOS.Model.Models.User;

namespace CashierPOS.WebApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private readonly IUserService _service;
        private readonly IConfiguration _config;

        public AuthController(IUserService service, IConfiguration configuration)
        {
            _service = service;
            _config = configuration;
        }

        /*[HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginReq request)
        {
            var userResponse = _service.GetLogin(request);

            if (userResponse.Status != 200)
            {
                return Unauthorized();
            }
            var authorizationHeader = HttpContext.Request.Headers["Authorization"].FirstOrDefault();

            if (string.IsNullOrEmpty(authorizationHeader) || !authorizationHeader.StartsWith("Bearer"))
            {
                return BadRequest("Invalid or missing Authorization header");
            }

            var token = authorizationHeader.Substring("Bearer ".Length);

            var generatedToken = GenerateJwtToken(userResponse.Result!, token);

            return Ok(new { Token = generatedToken});
        }*/

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginReq request)
        {
            var userResponse = _service.GetLogin(request);

            if (userResponse.Status != (int)ResponseStatus.NotFound)
            {
                /*return Unauthorized();*/
                return Ok(userResponse);
            }
            /*var authorizationHeader = HttpContext.Request.Headers["Authorization"].FirstOrDefault();

            if (string.IsNullOrEmpty(authorizationHeader) || !authorizationHeader.StartsWith("Bearer"))
            {
                return Unauthorized();
            }
            var token = authorizationHeader.Substring("Bearer ".Length);

            var configuredSecretKey = _config["AppSettings:Jwt:SecretKey"];

            if (token != configuredSecretKey)
            {
                return Unauthorized("Invalid token");
            }

            var generatedToken = GenerateJwtToken(userResponse.Result!, token);*/
            return Ok(userResponse);
            //return Ok(new { Token = generatedToken });
        }

        private string GenerateJwtToken(UserResponse user, string secretKey)
        {
            if (string.IsNullOrEmpty(secretKey))
            {
                throw new InvalidOperationException("JWT secret key is missing or empty.");
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.NameIdentifier, user.UserName),
            };
            //claims.AddRange(user.Role_Type.Select(role => new Claim(ClaimTypes.Role, role)));

            var token = new JwtSecurityToken(
                _config["AppSettings:Jwt:Issuer"],
                _config["AppSettings:Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
 
        [HttpPost]
        public IActionResult Create([FromBody] UserCreateReq request)
        {
            var data = _service.Create(request);
            if(data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

        [HttpPost("logout")]
        public IActionResult Logout([FromBody] UserLogoutReq request)
        {
            var data = _service.GetLogout(request);
            /*if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }*/
            return Ok(data);
        }

        [HttpPost("getAuth")]
        public IActionResult GetUser([FromBody] UserLoginReq request)
        {
            var data = _service.GetUserApproved(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }

       /* [HttpPost("reopenShift")]
        public IActionResult UserReopenShift([FromBody] UserReponseShiftReq request)
        {
            var data = _service.GetUserReOpenShift(request);
            if (data.Status != (int)ResponseStatus.Success)
            {
                return BadRequest(data);
            }
            return Ok(data);
        }*/
    }
}


