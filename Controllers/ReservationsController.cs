using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group12_FinalProject.DAL;
using Group12_FinalProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace Group12_FinalProject.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public IActionResult Index()
        {
            List<Reservation> reservations;
            if (User.IsInRole("Admin"))
            {
                reservations = _context.Reservations.Include(r => r.ReservationDetails).ToList();
            }
            else //user is a customer
            {
                reservations = _context.Reservations
                               .Include(r => r.ReservationDetails)
                                .Where(r => r.User.UserName == User.Identity.Name)
                               .ToList();
            }

            return View(reservations);
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reservation reservation = await _context.Reservations
                 .Include(r => r.ReservationDetails)
                                              .ThenInclude(r => r.Property)
                                              .Include(r => r.User)
                                              .FirstOrDefaultAsync(m => m.ReservationID == id);
            if (reservation == null)
            {
                return NotFound();
            }

            //make sure this reservations belongs to this user
            if (User.IsInRole("Customer") && reservation.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your reservation!  Don't be such a snoop!" });
            }

            return View(reservation);
        }

        // GET: reservations/Create
        //only customers can create reservations
        [Authorize(Roles = "Customer")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: reservation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //check current date.... order notes? what is needed for bind
        public async Task<IActionResult> Create([Bind("ReservationID,ConfirmationNumber,CurrentDate,CheckInDate, CheckOutDate")] Reservation reservation)
        {
            reservation.ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetNextConfirmationNumber(_context);

            //Set the date of this order
            // May need to set reservation
            reservation.CurrentDate = DateTime.Now;
            


            //Associate the order with the logged-in customer
            reservation.User = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "ReservationDetails", new { reservationID = reservation.ReservationID });
            }
            return View(reservation);
        }

    }
}