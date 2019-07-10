using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Keeysight.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Keeysight.Hubs;


namespace Keeysight
{
    public class Startup
    {
        //This Startup and IConfiguration will help you to read the appsettings.json file in the Startup.cs class.
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Add AppIdentityContext as a service
            //Dependency Injection
            services.AddDbContext<AppIdentityDbContext>(options =>
 options.UseSqlServer(
 Configuration["Data:KeeysightIdentity:ConnectionString"]));

            //Add TestTableContext as a service
            //Dependency Injection
            services.AddDbContext<TestTableContext>(options =>
options.UseSqlServer(
Configuration["Data:KeeysightIdentity:ConnectionString"]));

            //Add MessagesContext as a service
            //Dependency Injection
            services.AddDbContext<MessagesContext>(options =>
options.UseSqlServer(
Configuration["Data:KeeysightIdentity:ConnectionString"]));

            //used the AddIdentity method to set up the Identity services using the built-in classes to represent users and roles.
            services.AddIdentity<AppUser, IdentityRole>(opts => {
                opts.User.RequireUniqueEmail = true;
                //opts.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz";
                //opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            })
            .AddEntityFrameworkStores<AppIdentityDbContext>()
            .AddDefaultTokenProviders();

            services.Configure<CookiePolicyOptions>(options =>
            {
                //https://stackoverflow.com/questions/49770491/session-variable-value-is-getting-null-in-asp-net-core
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMemoryCache();
            services.AddSession();

            //Dependency Injection with a call to Add signalR
            services.AddSignalR();

            //Add Current User 
            services.AddHttpContextAccessor();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            // Enable static files to be served. This would allow html, images, etc. in wwwroot directory to be served. 
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTE0ODA3QDMxMzcyZTMxMmUzMFBPaWM0MjM5WDN5Y1N2WlNQZDh5MEFmQ2pTaldBTUVGZkJRQjZaSjMyNHc9; MTE0ODA4QDMxMzcyZTMxMmUzMEI4VTFmVk1veXJhZ2U4cHJodENNVXFoZTBxdU1ST3RlMEFSZ3llek5qM1E9; MTE0ODA5QDMxMzcyZTMxMmUzMFVCSWM5bFZhczNJaFlteGUyK2ljYk1XbGp5VXZNQnlnWDQrTlh4NWhpK3c9; MTE0ODEwQDMxMzcyZTMxMmUzMGc1eFV3ZjRmSlZFbXV4UHVtZWZya25GTHY3dEJpTzdQQ3VXeWZCRmg2Slk9; MTE0ODExQDMxMzcyZTMxMmUzMG81ckMxTWhSL2EzOGtnQzVKaEZFQUF3eTZaM0pJRFYxQ3UzdEd0bXdGbGM9; MTE0ODEyQDMxMzcyZTMxMmUzMGhVeVZBRjU4Z21hTkVsN05TM1krd0g2REdPdXBtMUxkZVI1N2JRUS9iWkE9; MTE0ODEzQDMxMzcyZTMxMmUzMG5XeTJpU1g2MlUwNVZtWjFkYTJhYmpWMThyU0xYbWxPYnFDdDlvTXBCOWM9; MTE0ODE0QDMxMzcyZTMxMmUzMFdkalV5TnRiMUlTOFJtNW9sNFlqTFBla2FvVWF3eXdxcWZOY2UydWxORmM9; MTE0ODE1QDMxMzcyZTMxMmUzMFVVRDdJVkU5V2twSjl5SWh3NEV4ZmlmUTBsRWNrazBNSFRNUjR3QU9HMms9; MTE0ODE2QDMxMzcyZTMxMmUzMG81ckMxTWhSL2EzOGtnQzVKaEZFQUF3eTZaM0pJRFYxQ3UzdEd0bXdGbGM9");


            // Add SignalR to the middleware pipeline, while setting up the necessary routes
            app.UseSignalR(routes =>
            {
               
                routes.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}
