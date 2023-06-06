using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReactAuthJWTDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SecretController : ControllerBase
    {
        [HttpGet]
        [Route("getdata")]
        public object GetSecretData()
        {
            var currentUser = User.FindFirst("user").Value;
            return new { message = $"This is a huge secret!! and you are {currentUser}" };
        }
    }
}
