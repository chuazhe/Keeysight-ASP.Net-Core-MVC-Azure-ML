using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Keeysight.Models;

namespace Keeysight.Controllers
{
    public class AnalysisController : Controller
    {

        private readonly TestTableContext _context;
        public AnalysisController(TestTableContext context)
        {
            this._context = context;
        }

        /*
        public ActionResult Index()
        {

            var query = _context.TestTable.ToList();
            return View(query);
        }*/

            public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(_context.TestTable.ToList());
        }
    }

}
