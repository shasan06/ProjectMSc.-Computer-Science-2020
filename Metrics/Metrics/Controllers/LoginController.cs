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

        
        public async Task<IActionResult> Index()
        {
            //Get userinfo from Session
            //var userinfo = JsonConvert.DeserializeObject<Registration>(HttpContext.Session.GetString("SessionUser"));
            return View(await _context.Registrations.ToListAsync());
            
        }

        

       //GET:Login

        public async Task<IActionResult> Login(int id = 0)
        {
            if (id == 0)
                return View(new Registration()); //this will insert a new registration if id=0
            else
                return View(_context.Registrations.Find(id));
        }



        // POST: Login/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("RegistrationId, FullName, Gender, Age, Password, ConfirmPassword, Level, EmailAddress")] Registration user)
        {
            // if (ModelState.IsValid)
            //{
            //if in the database registered name and password matches with the user then get that entire row and store it in credentials which is done by first and default method
            //var credentials = _context.Registrations.Where(u => u.FullName == user.FullName && u.Password == user.Password).FirstOrDefault();
            //if in the database registered name and password matches with the user then grant the permission
            var dbUser = _context.Registrations
                         .Where(u => u.FullName == user.FullName && u.Password == user.Password)
                         .FirstOrDefault();

            if (dbUser != null)
            {
                //var session = new Session().ToString();
                //session = user.FullName;
                ViewData["Message"] = "Hello " + dbUser.FullName;
                //ViewData["username"] = user.FullName;
                return View("UserView", dbUser);//will go to login controllers, userview method
                                              //the user is directed to its profile page
                                              //The LoggedIn is a method will be the profile page of the user
            }

            //if the Login fails then error message
            else
            {
                ViewData["Message"] = "Username or Password is incorrect."; //msg not displayed*****
                                                                            //return RedirectToAction ("AddOrEdit", "Registrations");
                return View("Login");

            }


            //}
            //await _context.SaveChangesAsync();
            // return View();





        }

       

       /* public async Task<IActionResult> UserView()
        {
            //after successfull login request comes in this method
            if(ViewData["username"] ==null) // if the user comes to this page without login then return to Login whose action method is Index
            {
                return RedirectToAction("Login","Login");
            }
            
            await _context.SaveChangesAsync();
            return View("UserView");
        }
       */
        
        //Get: Logout
        public async Task<IActionResult> Logout()
        {
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home"); //return to the home controller index method
        }
    }
}

    
    


    

