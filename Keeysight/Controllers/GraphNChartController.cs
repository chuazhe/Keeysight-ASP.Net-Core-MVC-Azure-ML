using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Keeysight.Controllers
{
    public class GraphNChartController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}