using Microsoft.AspNetCore.Mvc;
using AuthenticatorDEV.Models;

namespace AuthenticatorDEV.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase {
        //GET: api/Users
        [HttpGet]
        public IActionResult Get([FromBody] User usr) {
            return Ok(new string[] {"Verified", "true"});
        }

        [HttpPost]
        public IActionResult Post([FromBody] User usr) {
            bool Verified = getValidation(usr);
            return Ok(new string[] {"Verified", Verified.ToString()});
        }
        private bool getValidation(User usr) {
            bool validation = false;
            if ((usr.Email=="testme@test.com") && (usr.Password=="insecurePWD")) {
                validation = true;
            }
            return validation;
        }
    }
}
