using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

//TODO: Update this using statement to include your project name
using Group12_FinalProject.Models;
using Group12_FinalProject.DAL;

//TODO: Upddate this namespace to match your project name
namespace Group12_FinalProject.Controllers
{
    public class SeedController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedController(AppDbContext db, UserManager<AppUser> um, RoleManager<IdentityRole> rm)
        {
            _context = db;
            _userManager = um;
            _roleManager = rm;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SeedRoles()
        {
            try
            {
                await Seeding.SeedRoles.AddAllRoles(_roleManager);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }
        public async Task<IActionResult> SeedPeople()
        {
            try
            {
                await Seeding.SeedUsers.SeedAllUsers(_userManager, _context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }

        public IActionResult SeedAllCategories()
        {
            try
            {
                //call the SeedAllGenres method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedCategories.SeedAllCategories(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this category.");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);

                    //Add additional inner exception messages, if there are any
                    if (ex.InnerException.InnerException != null)
                    {
                        errorList.Add(ex.InnerException.InnerException.Message);
                    }
                }


                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }

        public IActionResult SeedAllProperties()
        {
            //this code may throw an exception, so we need to be in a Try/Catch block
            try
            {
                //call the SeedBooks method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedProperties.SeedOneProperty(_context); // still issues with all the plurals even in the controller
                // named in the class as seed one property from the canvas resources, not hw3... ???
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this Property.");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }
        public IActionResult SeedAllReviews()
        {
            //this code may throw an exception, so we need to be in a Try/Catch block
            try
            {
                //call the SeedBooks method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedReviews.SeedOneReview(_context); 
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this Review.");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                   errorList.Add(ex.InnerException.InnerException.Message);
               }

                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }

    }
}
