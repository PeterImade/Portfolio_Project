using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Project.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
