using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Group12_FinalProject.DAL;
using Group12_FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Group12_FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index(String SearchString)
        {
            var query = from p in _context.Properties
                        select p;
            //Populate the view bag with a count of all properties
            ViewBag.AllProperties = _context.Properties.Count();

            if (SearchString == null)

            {
                ViewBag.SelectedProperties = _context.Properties.Count();
                return View(_context.Properties.OrderBy(s => s.City).Include(s => s.Category).ToList());
                // don't have title... do I say City? this is not a detail in the search view model tho.... so i chose city rather than street
                // what was "s" in the hw3? ANSWER: S is searchviewmodel how does that correlate to here because now the p.category below only like lowercase while hw3 was uppercase

            }

            else
            {
                // title is here again so what do i change this to? did city again
                query = query.Where(p => p.City.Contains(SearchString) ||
                        p.State.Contains(SearchString)); /// changed description to state
                // do not search description either... what would I do here then? maybe state?

                List<Property> SelectedProperties = query.Include(p => p.Category).ToList(); // on hw3 this was capitalized... pay load tho
                //Populate the view bag with a count of selected properties
                ViewBag.SelectedProperties = SelectedProperties.Count;
                return View(SelectedProperties.OrderBy(s => s.City));

            }
        }
        public IActionResult Details(int? id)//id is the id of the book you want to see
        {
            if (id == null) //propertyID not specified
            {
                //user did not specify a BookID – take them to the error view
                return View("Error", new String[] { "PropertyID not specified - which property do you want to view?" });
            }

            //look up the book in the database based on the id; be sure to include the genre
            Property property = _context.Properties.Include(p => p.Category)
                                      .FirstOrDefault(p => p.PropertyID == id);

            if (property == null) //No book with this id exists in the database
            {
                //there is not a book with this id in the database – show the user an error view
                return View("Error", new String[] { "Property not found in database" });
            }

            //if code gets this far, all is well – display the details
            return View(property);
        }



        public IActionResult DetailedSearch()
        {
            ViewBag.AllCategories = GetAllCategories();
            return View();
        }

        public SelectList GetAllCategories()
        {
            //Get the list of category from the database
            List<Category> categoryList = _context.Categories.ToList();

            //convert the list to a SelectList by calling SelectList constructor
            //CategoryID and CategoryName are the names of the properties on the Category class
            //CategoryID is the primary key
            SelectList categorySelectList = new SelectList(categoryList.OrderBy(m => m.CategoryID), "CategoryID", "CategoryName");

            //return the electList
            return categorySelectList;
        }

        public IActionResult DisplaySearchResults(PropertySearchViewModel psvm)
        {
            var query = from p in _context.Properties
                        select p;

            // TO DO: change to choose what is the main search
            //city
            if (String.IsNullOrEmpty(psvm.SearchCity) == false)
            {
                query = query.Where(p => p.City.Contains(psvm.SearchCity) ||
                p.FullAddress.Contains(psvm.SearchCity));
                // error with the property's property
            }

            //state
            if (String.IsNullOrEmpty(psvm.SearchState) == false)
            {
                query = query.Where(p => p.State.Contains(psvm.SearchState));
            }

            //guest rating
            // how do i get this to work? because it says its always true
            //if (svm.SearchGuestRating != 0)
           // {
                //if (svm.RatingSearchType == SearchRatingOptions.Below)
               // {
                   // query = query.Where(p => p.GuestRating <= svm.SearchGuestRating);
              //  }

               // else
              //  {
               //     query = query.Where(p => p.GuestRating >= svm.SearchGuestRating);
               // }
         //   }

            //number of guests - why error
            // how do i get this to work? because it says its always true
            if (psvm.SearchGuestsAllowed != 0)
            {
                query = query.Where(p => p.GuestsAllowed <= psvm.SearchGuestsAllowed);
            }

            //number of bathrooms - why error: because not a string: how would I do this?
            // how do i get this to work? because it says its always true
            if (psvm.SearchBathroom != 0)
            {
                query = query.Where(p => p.Bathroom <= psvm.SearchBathroom);
            }

            //number of bedrooms - why error: because not a string: how would I do this?
            // how do i get this to work? because it says its always true
            if (psvm.SearchBedroom != 0)
            {
                query = query.Where(p => p.Bedroom <= psvm.SearchBedroom);
            }

            //Price
            //if (svm.SearchDailyPrice != null)
            //{
            //  if (svm.PriceSearchType == SearchPriceOptions.Below)
            //  {
            //  query = query.Where(p => p.Price <= svm.SearchDailyPrice);
            //   } // need to adjust the properties for price in property and resrvation:

            //  else
            //  {
            //  query = query.Where(p => p.Price <= svm.SearchDailyPrice);
            // }
            // }

            if (psvm.SelectedPetsAllowed != null)
            {
                //In this example, we are just displaying the search criteria
                //In a real search, you would put a query here that selects records
                //with the same value as the enum
                ViewBag.SelectedPetsAllowed = psvm.SelectedPetsAllowed;
            }

            if (psvm.SelectedFreeParking != null)
            {
                //In this example, we are just displaying the search criteria
                //In a real search, you would put a query here that selects records
                //with the same value as the enum
                ViewBag.SelectedFreeParking = psvm.SelectedFreeParking;
            }



            if (psvm.SelectedCategoryID != 0)
            {
                query = query.Where(p => p.Category.CategoryID == psvm.SelectedCategoryID);
            } 

            // how should we do the search for the date?? like how would I compare that to the property search?
            // need to search when a property does not a reservation on the searched date range
           // if User searched for dates

          //  {
            //search for dates
          //  var dateQuery = from r in _context.Reservations select r;

          //  if (svm.SelectedCheckInDate != null) //reservations that DO NOT conflict
           // {
          //   dateQuery = dateQuery.Where(d => d.CheckInDate >= svm.SelectedCheckOutDate && d.CheckOutDate <= svm.SelectedCheckInDate);
           //  }

           //   List<Reservation> reservations = dateQuery.ToList();
            // List<Reservation> unavailable = _context.Reservations.Except(reservations).ToList();  //all reservations that cause problems

           //  List<Property> UnavailableProperties = new List<Property>();
            //double check if this is correct for the new list of the unvailable prop

            // foreach (Reservation res in unavailable)
              //{
            // UnavailableProperties.AddRange(_context.Properties.Where(p => p.reservation.Any(r => r.ReservationID == //res.ReservationID)));
              //}

            //   SelectedProperties = SelectedProperties.Except(UnavailbleProperties).ToList();

            //  }

            List<Property> SelectedProperties = query.Include(p => p.Category).ToList();

            ViewBag.AllProperties = _context.Properties.Count();

            ViewBag.SelectedProperties = SelectedProperties.Count;

            return View("Index", SelectedProperties.OrderBy(p => p.City));
        }


    }
}

