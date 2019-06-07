using Keeysight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;




namespace Keeysight.Hubs
{
    public class ChatHub : Hub
    {

        //Dependency Injection
        private readonly MessagesContext _context;
        public ChatHub(MessagesContext context)
        {
            this._context = context;

        }



        //No validation yet
        public async void Add(String content)
        {
            try
            {
                //use onConfiguring
                using (var context = new MessagesContext())
                {
                    Messages user = new Messages
                    {
                        Content = content

                    };


                    //Only use AddSync So if you use a value generator that might need to access the DB to get new values to assign to new entries, such as the SequenceHiLo generator, then use AddAsync().
                    context.Messages.Add(user);

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }




        public async Task SendMessage(string user, string message)
        {

            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendMessageToGroup(string group, string message)
        {

            await Clients.Group(group).SendAsync("ReceiveMessage", group, message);
        }

        //Not working in IIS Express, but working in debug mode
        //Working in Production Mode
        //Don't know why
        public Task JoinGroup(string group)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, group);
        }

        public Task LeaveGroup(string group)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, group);
        }



    }
}