using Mango.Web.Models;
using Mango.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IRestorantService _restorantService;

        public HomeController(ILogger<HomeController> logger, IRestorantService restorantService)
        {
            _logger = logger;
            _restorantService = restorantService;
        }

        public async Task<IActionResult> Index()
        {
            List<RestorantDto> list = new();
            var response = await _restorantService.GetRestorantsAsync<ResponseDto>("");
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<RestorantDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }

        public async Task<IActionResult> SearchPage()
        {
            return View();
        }
    }
}
