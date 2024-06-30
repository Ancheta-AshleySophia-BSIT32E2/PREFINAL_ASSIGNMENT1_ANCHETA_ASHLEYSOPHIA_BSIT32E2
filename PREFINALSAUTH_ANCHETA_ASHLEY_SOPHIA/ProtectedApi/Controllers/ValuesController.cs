using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProtectedApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            
            var userInfo = new
            {
                Name = "Ashley Sophia S. Ancheta",
                Section = "BSIT 32E2",
                Course = "Bachelor of Science in Infortmation Technology"
            };

            var funFacts = new[]
            {
                "I hate insects!",
                "I enjoy playing video games especially CODM and Mobile Legends.",
                "I love watching series and movies.",
            };

            return Ok(new { UserInfo = userInfo, FunFacts = funFacts });
        }
    }
}
