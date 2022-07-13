using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEZ_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        [Route("Register")]
        public async Task <IActionResult> Register()
        {
            return await Task .FromResult(Ok("This function was succesfull"));
        }
        [HttpPost]
        [Route("Login")]

        public IActionResult Login()
        {
            return Ok("Call Succesful");
        }
            
    }
}
