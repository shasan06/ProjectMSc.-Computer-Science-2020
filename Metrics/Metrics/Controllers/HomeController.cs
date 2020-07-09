using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Metrics.Models;
using Metrics.Data;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Metrics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public IActionResult Index()
        {
            //var userinfo = new Registration();
            //Set UserInfo into Session
            //HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(userinfo.RegistrationId));
            //var complexity = _context.Complexities.First();
            //var model = new HomeIndexModel()
            //{
            //    Message = "Count",
            //    Image = complexity.Image
            //};
            //TempData["messsage"] = DateTime.Now;

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
