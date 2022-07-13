using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Controllers
{
    public class RestorantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
