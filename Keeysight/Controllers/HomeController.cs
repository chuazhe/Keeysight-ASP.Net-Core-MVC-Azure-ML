using Keeysight.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace Keeysight.Controllers
{


    public class HomeController : Controller
    {

        //Dependency Injection
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
            //Search for e.Name == Chua
            //var query = _context.TestTable.Where(e => e.Name == "Chua").ToList();
            //dd/mm/yyyy 
            //4/6/2019 4:07:34 PM
            //Console.WriteLine(System.DateTime.Now);


            /*
            Get UserId, UserName, UserEmail
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value; // will give the user's userId
            var userName = User.FindFirst(ClaimTypes.Name).Value; // will give the user's userName
            //var userEmail = User.FindFirst(ClaimTypes.Email).Value; // will give the user's Email
            Console.Write(userId);
            Console.Write(userName);
            //Console.Write(userEmail);
            */

            var query = _context.TestTable.ToList();
            return View(query);


            //OnConfiguring
            /* 
            using (var context = new TestTableContext())
            {
                var query = context.TestTable.ToList();
                return View(query);
            }
            */
           
        
        }

        //Custom Route, by assigning route, going to home/Index2 will go to Error.cshtml
        //[Route("home/Index2")]
        /*Allow unauthorised user to access this view*/
        [AllowAnonymous]
        public ViewResult Error() => View();
    }

}
