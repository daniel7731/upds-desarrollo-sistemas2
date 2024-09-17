using Microsoft.AspNetCore.Mvc;
using WebApplicationAcademia.Model;

namespace WebApplicationAcademia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpPost("login/")]
        public bool login(string userName , string password)
        {

            return true;
        }
        [HttpGet("isLogged/")]
        public bool isLogged(string code)
        {

            return false;
        }
    }
}
