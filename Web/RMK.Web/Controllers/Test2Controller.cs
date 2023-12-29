using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AMR.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test2Controller : Controller
    {
        [Authorize]
        [HttpPost]
        [Route("PublicAction")]
        public async Task<IActionResult> PublicAction() => Ok();

        [HttpPost]
        [Route("PrivateAction")]
        public async Task<IActionResult> PrivateAction() 
        {
            if (User.Identity.IsAuthenticated) {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            return Ok();
        } 
    }
}
