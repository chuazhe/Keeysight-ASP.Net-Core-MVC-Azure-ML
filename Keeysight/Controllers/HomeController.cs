using Keeysight.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Keeysight.Controllers
{


    public class HomeController : Controller
    {



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
