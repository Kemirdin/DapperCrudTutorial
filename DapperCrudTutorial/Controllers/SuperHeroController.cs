using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperCrudTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SuperHeroController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }


        [HttpGet]
        public async Task<ActionResult>

    }
}
