﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Keeysight.Models
{
    public class MessagesContext : DbContext
    {
        //For OnConfiguring
        public MessagesContext()
        {
        }

        //Initiliase the context with the connection string in appsettings.json (RMB to put the configure the service 1st in Starup.cs!)
        public MessagesContext(DbContextOptions<MessagesContext> options) : base(options)
        { }

        //The object for the context
        public DbSet<Messages> Messages { get; set; }


        //If u want to use (var context= new MessagesContext()) which it doesn't have to initialise the context to perform query to the database, u will have to provide the connection string inside it
        //don't put this file in public repository if developing in real life situation
        //may cause security issues
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:keeysight.database.windows.net,1433;Initial Catalog=KeeysightIdentity;Persist Security Info=False;User ID=keeysightadmin;Password=Keeysight123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }


        /*
        // For scaffolded purpose
        Configuration Conventions
        A Configuration Convention is a way to configure entities without overriding the default behavior provided in the Fluent API.
        You can define a configuration convention in the OnModelCreating() method and also in a custom class
        , similar to how you would define normal entity mappings with Fluent API. Used to to define the attributes (PK,FK,NOT NULL,...) in code-first approach.
             */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
