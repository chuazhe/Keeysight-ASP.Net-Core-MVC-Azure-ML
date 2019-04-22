using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Keeysight.Models;

namespace Keeysight.Controllers
{
    public class AdminController : Controller
    {
        
        private UserManager<AppUser> userManager;

        // Constructor
        /* When MVC needs to create an instance of the view component class, it will note the need to provide this argument and inspect the configuration in the Startup class to determine which implementation object should be used. */
        public AdminController(UserManager<AppUser> usrMgr)
        {
            userManager = usrMgr;
        }


        public ViewResult Index() => View(userManager.Users);


        public ViewResult Create() => View();

        // Respond to POST
        [HttpPost]
        public async Task<IActionResult> Create(CreateModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                  
                    UserName = model.Name,
                    Email = model.Email
                };
                IdentityResult result
                = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
    }
}
 