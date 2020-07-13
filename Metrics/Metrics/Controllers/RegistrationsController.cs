using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Metrics.Data;
using Metrics.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Metrics.Controllers
{
    public class RegistrationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        //first thing is to do modification in the form for adding new registration
        //rename the IActionResult method from Create() to AddOrEdit()
        //constructor of this registration controller will use the dependency injection which adds the service 
        //in the CONFIGURE SERVICES, in the startup file 
        //where we added dbCONTEXT into this ISERVICECOLLECTION whenever we create 
        //an instance of registration controller value for this constructor parameter is initialised by
        //"context"--which is the applicationdbcontext object will be passed from this IService collection
        //as the result of the dependency injection

        public RegistrationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Registrations
        //this method will show the registration form to the user
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registrations.ToListAsync());
        }

        // GET: Registrations/Create=AddorEdit
        public IActionResult AddorEdit(int id = 0)
        {
            //this method will create the user if the id doesn't exist, if it exist then will find that registered user
            //we have addoredit of the type get request based on the id we know that the button needs to edit
            if (id == 0)
                return View(new Registration()); //this will insert a new registration if id=0
            else
                return View(_context.Registrations.Find(id));
        }

        // POST: Registrations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddorEdit([Bind("RegistrationId, FullName, Gender, Age, Password, ConfirmPassword, Level, EmailAddress")] Registration registration)
        {//we have the AddorEdit of the type Post
            if (ModelState.IsValid)

            {
                if (_context.Registrations.Where(u => u.FullName == registration.FullName).Any())
                {
                    //Do what do u need to do...
                    //return ViewBag.Message = registration.FullName + " is already been taken. Please choose another name";
                    //ViewBag.Message = registration.FullName + " is already been taken. Please choose another name";
                    //ModelState.AddModelError(registration.FullName + " is already been taken. Please choose another name");
                    //ViewData.ModelState.AddModelError(string.Empty, registration.FullName + " is already been taken. Please choose another name");
                    //return View("~/Views/Registrations/AddOrEdit.cshtml");
                    //return (RedirectToAction(nameof(Index)));
                    //return (nameof(Registration));
                    //
                    ViewData["Message"] = "This username is already been taken. Please choose another name";
                    //return View("AddOrEdit", "Registrations");
                    return View(registration);
                }



                else if (registration.RegistrationId == 0)//if the id is zero then we will do the insert operation otherwise we have to do the update operation
                {
                    var m = new Registration
                    {
                        FullName = registration.FullName,
                        Gender = registration.Gender,
                        Age = registration.Age,
                        Password = registration.Password,
                        ConfirmPassword = registration.ConfirmPassword,
                        EmailAddress = registration.EmailAddress,

                    };

                    _context.Registrations.Add(m);
                    await _context.SaveChangesAsync();
                    ModelState.Clear();
                    ViewData["Message"] = registration.FullName + " is successfully registered.";
                    return View(registration);
                    //return RedirectToAction(nameof(Index));
                    
                    


                }
                else
                    _context.Update(registration);


                await _context.SaveChangesAsync();
                //ModelState.Clear();
                //ViewData.ModelState.AddModelError(string.Empty, registration.FullName + " successfully registered.");

                //return View("~/Views/Registrations/AddOrEdit.cshtml");//but here i want it to go to login after registration


            }

            return View(registration);


        }

        // GET: Registrations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //we have the delete of the type get


            var registration = await _context.Registrations.FindAsync(id);
            _context.Registrations.Remove(registration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }


}






