using Microsoft.AspNetCore.Mvc;

namespace Blog_Escola_Dotnet.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
