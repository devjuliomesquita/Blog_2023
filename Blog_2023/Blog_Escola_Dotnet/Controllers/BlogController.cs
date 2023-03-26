using Blog_Escola_Dotnet.BusinessManager.Interfaces;
using Blog_Escola_Dotnet.Models.BlogViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Escola_Dotnet.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogBusinessManager _IBlogBusinessManager;
        public BlogController(IBlogBusinessManager iBlogBusinessManager)
        {
            _IBlogBusinessManager = iBlogBusinessManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View(new CreateBlogViewModel());
        }
        public IActionResult Add(CreateBlogViewModel model)
        {
            return View(model);
        }
    }
}
