using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Metrics.Data;
using Metrics.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;


namespace Metrics.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;


        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Login
        public async Task<IActionResult> Index()
        {
            //Get userinfo from Session
            //var userinfo = JsonConvert.DeserializeObject<Registration>(HttpContext.Session.GetString("SessionUser"));

            return View(await _context.Registrations.ToListAsync());
        }



        // GET: Login/Create=Login
        public IActionResult Login()
        {
            return View();
        }



        // POST: Login/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Registration user)
        {
            if (ModelState.IsValid)
            {
                //if in the database registered name and password matches with the user then get that entire row and store it in credentials which is done by first and default method
                //var credentials = _context.Registrations.Where(u => u.FullName == user.FullName && u.Password == user.Password).FirstOrDefault();
                //if in the database registered name and password matches with the user then grant the permission
                if (_context.Registrations.Where(u => u.FullName == user.FullName && u.Password == user.Password).Any())
                {
                    //var session = new Session().ToString();
                    //session = user.FullName;
                    TempData["username"]=user.FullName;
                    return RedirectToAction("UserView","Login");//will go to login controllers, userview method
                    //the user is directed to its profile page
                    //The LoggedIn is a method will be the profile page of the user
                }

                //if the Login fails then error message
                else
                {
                    ViewData.ModelState.AddModelError("", "Username or Password is incorrect.");
                    return View("~/Views/Login/Login.cshtml");

                }


            }
            await _context.SaveChangesAsync();
            return View();





        }

        public async Task<IActionResult> UserView()
        {
            //after successfull login request comes in this method
            if(TempData["username"] ==null) // if the user comes to this page without login then return to Login whose action method is Index
            {
                return RedirectToAction("Index","Login");
            }
            await _context.SaveChangesAsync();
            return View();
        }

        

    }
}

    
    


    

