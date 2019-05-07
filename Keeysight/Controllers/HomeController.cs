using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Keeysight.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data.SqlClient;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Keeysight.Controllers
{


    public class HomeController : Controller
    {

        const string SessionName = "_Name";
        const string SessionAge = "_Age";

        private readonly TestTableContext _context;
        public HomeController(TestTableContext context)
        {
            this._context = context;
        }


        /*Authorize attribute, which tells MVC that only requests from authenticated
        users should be processed*/
        [Authorize]
        public ViewResult Index()
        {
            HttpContext.Session.SetString(SessionName, "Jarvik");
            HttpContext.Session.SetInt32(SessionAge, 24);
            // ViewBag.Message = HttpContext.Session.GetString("SessionName");
            var query = _context.TestTable.Where(e => e.Name == "Chua").ToList();
            return View(query);

        }

        //Custom Route, by assigning route, going to home/Index2 will go to Error.cshtml
        //[Route("home/Index2")]
        /*Allow unauthorised user to access this view*/
        [AllowAnonymous]
        public ViewResult Error() => View();
    }

}
