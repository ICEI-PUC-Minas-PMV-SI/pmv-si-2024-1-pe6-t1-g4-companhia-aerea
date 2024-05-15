using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace application.Controllers
{
    //[Authorize("Bearer")]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomController : ControllerBase
    {
        internal SessionData GetSessionData()
        {
            var jwtToken = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var handler = new JwtSecurityTokenHandler();
            var token = (JwtSecurityToken)handler.ReadToken(jwtToken);

            var sessionData = new SessionData()
            {
                Id = token.Claims.FirstOrDefault(i => i.Type == "jti").Value.ToString(),
                Email = token.Claims.FirstOrDefault(i => i.Type == "email").Value.ToString(),
                Role = token.Claims.FirstOrDefault(i => i.Type == "role").Value.ToString(),
                Username = token.Claims.FirstOrDefault(i => i.Type == "name").Value.ToString(),
            };

            return sessionData;
        }

        public class SessionData
        {
            public string Id { get; set; }

            public string Username { get; set; }

            public string Email { get; set; }

            public string Role { get; set; }
        }
    }
}
