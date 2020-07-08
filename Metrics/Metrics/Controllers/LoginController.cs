using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Metrics.Data;
using Metrics.Models;

using System.Diagnostics.Eventing.Reader;

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
            return View(await _context.Registrations.ToListAsync());
        }

        

        // GET: Login/Create=Login
        public IActionResult Login(int id =0)
        {
            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("RegistrationId,FullName,Gender,Age,EmailAddress,Password,Level")] Registration registration, Registration user)
        {
            if (ModelState.IsValid)
            {
                
                if (registration.FullName == user.FullName)
                    //if the credentials matches then bring to the Index Page otherwise to the registration
                    
                    return RedirectToAction("Please enter another username");

                else if(registration.Password == user.Password && registration.FullName != user.FullName)
                    return RedirectToAction(nameof(Index));
                else
                    return RedirectToAction(nameof(Registration));



            }

            return View(user);
        }

    }

        



    }

