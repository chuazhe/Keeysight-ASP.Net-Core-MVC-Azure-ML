using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Keeysight.Models;
using Microsoft.AspNetCore.Authorization;

namespace Keeysight.Controllers
{
    public class HomeController : Controller
    {

        [Authorize]
        public ViewResult Index() =>
 View(new Dictionary<string, object> { ["Placeholder"] = "Placeholder" });
    }

}
