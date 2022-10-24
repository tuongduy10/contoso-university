using ContosoUniversity.Business.Services.Enrollment;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.BackendApi.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly IEnrollmentService _enrollService;
        public HomeController(IEnrollmentService enrollmentService)
        {
            _enrollService = enrollmentService;
        }
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var list = await _enrollService.GetAllAsync();
            return Ok(list);
        }
    }
}
