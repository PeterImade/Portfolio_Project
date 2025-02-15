using Microsoft.AspNetCore.Mvc;
using Portfolio_Project.Data;
using Portfolio_Project.Models;

namespace Portfolio_Project.Controllers
{
    public class ContactController : Controller
    {

        private readonly PortfolioDBContext _dbContext;

        public ContactController(PortfolioDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Form obj)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", obj);
            }

            try
            {
                _dbContext.Forms.Add(obj);
                _dbContext.SaveChanges();
                TempData["SuccessMessage"] = "Your message has been sent successfully!";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred. Please try again.";
                Console.WriteLine($"Error saving form: {ex.Message}");
            }

            return RedirectToAction("Index");
        }
    }
}
