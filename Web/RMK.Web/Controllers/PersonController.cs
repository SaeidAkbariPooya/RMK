using Microsoft.AspNetCore.Mvc;
using RMK.Application.Interfaces;

namespace AMR.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll() 
        {
            var result = _personService.GetAll();
            return Ok(result);
        }
    }
}
