using Microsoft.AspNetCore.Mvc;
using YigithanBlog.Service.Services.Abstractions;

namespace YigithanBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesAsync();
            return View(articles);
        }
    }
}
