using Keeysight.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.IO;
using Syncfusion.Drawing;
using System.Threading.Tasks;

namespace Keeysight.Controllers
{
    public class GraphNChartController : Controller
    {

        //https://docs.microsoft.com/en-us/ef/core/miscellaneous/configuring-dbcontext
        // This is the dependency injection for DbContext, must be initialised first if u decided to use depency injection 
        /*
        private readonly TestTableContext _context;
        public GraphNChartController(TestTableContext context)
        {
            this._context = context;
        }
        */


        //[Authorize(Roles = "Admin")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        // Respond to POST
        [HttpPost]
        public async Task<IActionResult> Add(TestTable model)
        {
            if (ModelState.IsValid)
            {
                //using (_context) <- this is dependency injection
                using (var context=new TestTableContext())
                {
                    TestTable user = new TestTable
                    {

                        Name = model.Name,
                        Id = model.Id
                    };

                    //Only use AddSync So if you use a value generator that might need to access the DB to get new values to assign to new entries, such as the SequenceHiLo generator, then use AddAsync().
                    context.TestTable.Add(user);

                    await context.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }
                
            }
            else
            {
                return RedirectToAction("Error", "Home");

            }
        }

        // Respond to POST
        [HttpPost]
        public async Task<IActionResult> Update(TestTable model)
        {
            if (ModelState.IsValid)
            {
                //using (_context) <- this is dependency injection
                using (var context = new TestTableContext())
                {
                    TestTable user = new TestTable
                    {

                        Name = model.Name,
                        Id = model.Id
                    };

                    context.TestTable.Update(user);
                    context.SaveChanges();
                    await context.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }

            }
            else
            {
                return RedirectToAction("Error", "Home");

            }
        }

        // Respond to POST
        [HttpPost]
        public async Task<IActionResult> Delete(TestTable model)
        {
            if (ModelState.IsValid)
            {
                //using (_context) <- this is dependency injection
                using (var context = new TestTableContext())
                {
                    TestTable user = new TestTable
                    {

                        Id = model.Id
                    };

                    context.TestTable.Remove(user);
                    await context.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }

            }
            else
            {
                return RedirectToAction("Error", "Home");

            }
        }


        [HttpGet]
        public ActionResult CreateDocument()
        {

            //Create a new PDF document
            PdfDocument document = new PdfDocument();

            //Add a page to the document
            PdfPage page = document.Pages.Add();

            //Create PDF graphics for the page
            PdfGraphics graphics = page.Graphics;

            //Set the standard font
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

            //Draw the text
            graphics.DrawString("Hello World!!!", font, PdfBrushes.Black, new PointF(0, 0));

            //Saving the PDF to the MemoryStream
            MemoryStream stream = new MemoryStream();

            document.Save(stream);

            //If the position is not set to '0' then the PDF will be empty.
            stream.Position = 0;

            Console.WriteLine("LALA");

            //Download the PDF document in the browser.
            FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/pdf");
            fileStreamResult.FileDownloadName = "Output.pdf";
            return fileStreamResult;

        }
    }
}