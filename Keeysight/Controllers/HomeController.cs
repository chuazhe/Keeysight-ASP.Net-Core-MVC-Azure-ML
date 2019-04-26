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
    }

}
