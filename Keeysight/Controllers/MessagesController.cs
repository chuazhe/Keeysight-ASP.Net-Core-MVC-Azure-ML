using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Keeysight.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;


namespace Keeysight.Controllers
{
    public class MessagesController : Controller
    {

        //Dependency Injection
        private readonly MessagesContext _context;
        public MessagesController(MessagesContext context)
        {
            this._context = context;
        }

        [Authorize]
        public ViewResult Index()
        {
            var query = _context.Messages.ToList();
            return View(query);
        }


    }
}