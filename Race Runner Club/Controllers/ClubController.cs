using Microsoft.AspNetCore.Mvc;

namespace Race_Runner_Club.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
