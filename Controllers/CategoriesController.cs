using Microsoft.AspNetCore.Mvc;

namespace Group12_FinalProject.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            //return the home page with the links to the other pages
            return View();
        }
    }
}
