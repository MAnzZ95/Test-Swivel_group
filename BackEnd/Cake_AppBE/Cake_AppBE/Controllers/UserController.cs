using AutoMapper;
using Cake_AppBE.Helpers;
using Cake_AppBE.IRepository;
using Cake_AppBE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Cake_AppBE.Controllers
{
    [Route("api/user")]
    [ApiController]
    [Authorize]

    public class UserController : ControllerBase
    {
        private IMapper _mapper;
        private readonly AppSettings _appSettings;
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository, IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _mapper = mapper;
            _appSettings = appSettings.Value;
            _userRepository = userRepository;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<ActionResult> Authenticate([FromBody] AuthenticateModel model)
        {
            var user =  await _userRepository.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            
            return Ok(new
            {
                Id=user.Id,
                Username = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Token = tokenString
            });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] RegisterModel model)
        {
            
            var user = _mapper.Map<User>(model);

            try      
            {
                
                var us = await _userRepository.Create(user, model.Password);
                return Ok(us);
            }
            catch (AppException ex)
            {
                
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("{name}",Name="userbyname")]
        
        public async Task<ActionResult> getUserbyUsername(string name)
        {
            try
            {
                var user = await _userRepository.GetUserByUserName(name);
                if(user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet(Name = "userlogin")]
        public async Task<ActionResult> userLogin(string name,string password)
        {
            try
            {
                var user = await _userRepository.GetUserByUserName(name);
                if (user == null)
                {
                    return NotFound();
                }
                
                        return Ok(user);
                 
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
