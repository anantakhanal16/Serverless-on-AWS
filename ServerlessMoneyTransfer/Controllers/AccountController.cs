using Microsoft.AspNetCore.Mvc;

namespace ServerlessMoneyTransfer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("Register")]
        public IEnumerable<string> Register()
        {

            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("Login")]
        public IEnumerable<string> Login()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
