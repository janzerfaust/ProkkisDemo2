using Microsoft.AspNetCore.Mvc;

namespace ProkkisDemo2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {                        
            return View();
        }
    }
}