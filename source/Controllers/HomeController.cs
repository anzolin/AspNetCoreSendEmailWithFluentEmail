using FluentEmail.Core;
using Microsoft.AspNetCore.Mvc;
using SendEmailWithFluentEmail.Models;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace SendEmailWithFluentEmail.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> SendEmail([FromServices]IFluentEmail email)
        {
            var model = new
            {
                Name = "test name"
            };

            var template = "hi @Model.Name this is a razor template @(5 + 5)!";

            var response = await email
                .To("name@domain.com")
                .Subject("test email subject")
                .UsingTemplate(template, model)
                .SendAsync();

            // (response.Successful

            return View();
        }

        public async Task<IActionResult> SendEmailTemplateFromFile([FromServices]IFluentEmail email)
        {
            var model = new
            {
                Name = "test name"
            };

            var response = await email
                .To("name@domain.com")
                .Subject("test email subject")
                .UsingTemplateFromFile($"{Directory.GetCurrentDirectory()}/Views/Shared/EmailTemplates/Mytemplate.cshtml", model)
                .SendAsync();

            // (response.Successful

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
