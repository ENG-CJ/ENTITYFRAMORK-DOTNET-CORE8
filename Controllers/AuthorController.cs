using Microsoft.AspNetCore.Mvc;

namespace Libraries.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
