using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group12_FinalProject.DAL;
using Group12_FinalProject.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace Group12_FinalProject.Controllers
{
    public class ReservationDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ReservationDetails
        public IActionResult Index(int? reservationID)
        {
            if (reservationID == null)
            {
                return View("Error", new String[] { "Please specify a reservation to view!" });
            }

            //limit the list to only the registration details that belong to this registration
            List<ReservationDetail> rds = _context.ReservationDetails
                                          .Include(rd => rd.Property)
                                          .Where(rd => rd.Reservation.ReservationID == reservationID)
                                          .ToList();
            //i am here

            return View(rds);
        }

        // GET: reservationDetails/Create
        public IActionResult Create(int reservationID)
        {
            //create a new instance of the reservationDetail class
            ReservationDetail rd = new ReservationDetail();

            //find the registration that should be associated with this registration
            Reservation dbReservation = _context.Reservations.Find(reservationID);

            //set the new reservation detail's reservation equal to the reservation you just found
            rd.Reservation = dbReservation;

            //populate the ViewBag with a list of existing properties
            ViewBag.AllProperties = GetAllProperties();

            //pass the newly created reservation detail to the view
            return View(rd);
        }

        // POST: reservationDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Reservation, ReservationDetailID, NumberOfDays")] ReservationDetail reservationDetail, int SelectedProperty)
        {
            //if user has not entered all fields, send them back to try again
            if (ModelState.IsValid == false)
            {
                ViewBag.AllProperties = GetAllProperties();
                return View(reservationDetail);
            }

            //find the course to be associated with this order
            Property dbProperty = _context.Properties.Find(SelectedProperty);

            //set the reservation detail's course to be equal to the one we just found
            reservationDetail.Property = dbProperty;

            //find the reservation on the database that has the correct reservation id
            //unfortunately, the HTTP request will not contain the entire reservation object, 
            //just the resrvation id, so we have to find the actual object in the database
            Reservation dbReservation = _context.Reservations.Find(reservationDetail.Reservation.ReservationID);

            //set the registration on the registration detail equal to the registration that we just found
            reservationDetail.Reservation = dbReservation;

            //set the reservation detail's price equal to the property price
            //this will allow us to to store the price that the user paid
           

            //calculate the extended price for the reservation detail
            //MORE COMPLICATED CALC HERE
            //reservationDetail.StayPrice = reservationDetail.NumberofDays * reservationDetail.CourseFee;

            //add the reservation detail to the database
            _context.Add(reservationDetail);
            await _context.SaveChangesAsync();

            //send the user to the details page for this reservation
            return RedirectToAction("Details", "Reservations", new { id = reservationDetail.Reservation.ReservationID });
        }

        // GET: ReservationDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //user did not specify a reservation detail to edit
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a reservation  detail to edit!" });
            }

            //find the reservation detail
            ReservationDetail reservationDetail = await _context.ReservationDetails
                                                   .Include(rd => rd.Property)
                                                   .Include(rd => rd.Reservation)
                                                   .FirstOrDefaultAsync(rd => rd.ReservationDetailID == id);
            if (reservationDetail == null)
            {
                return View("Error", new String[] { "This reservation detail was not found" });
            }
            return View(reservationDetail);
        }

        // POST: ReservationDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservationDetailID, ReservationStartDate")] ReservationDetail reservationDetail)
        {
            //this is a security check to make sure they are editing the correct record
            if (id != reservationDetail.ReservationDetailID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //information is not valid, try again
            if (ModelState.IsValid == false)
            {
                return View(reservationDetail);
            }

            //create a new registration detail
            ReservationDetail dbRD;
            //if code gets this far, update the record
            try
            {
                //find the existing registration detail in the database
                //include both registration and course
                dbRD = _context.ReservationDetails
                      .Include(rd => rd.Property)
                      .Include(rd => rd.Reservation)
                      .FirstOrDefault(rd => rd.ReservationDetailID == reservationDetail.ReservationDetailID);

                //update the scalar properties
                dbRD.StayPrice = dbRD.Property.WeekendPrice * dbRD.NumberOfWeekendDays + dbRD.Property.WeekDayPrice * dbRD.NumberOfWeekDays;

                // what is the property fee after the calculation?

                //save changes
                _context.Update(dbRD);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to the Reservation details index page
            return RedirectToAction("Details", "Reservations", new { id = dbRD.Reservation.ReservationID });

        }

        // GET: ReservationDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //user did not specify a Reservation detail to delete
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a Reservation detail to delete!" });
            }

            //find the registration detail in the database
            ReservationDetail reservationDetail = await _context.ReservationDetails
                                                    .Include(r => r.Reservation)
                                                   .FirstOrDefaultAsync(m => m.ReservationDetailID == id);

            //registration detail was not found in the database
            if (reservationDetail == null)
            {
                return View("Error", new String[] { "This Reservation detail was not in the database!" });
            }

            //send the user to the delete confirmation page
            return View(reservationDetail);
        }

        // POST: ReservationDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //find the registration detail to delete
            ReservationDetail reservationDetail = await _context.ReservationDetails
                                                   .Include(r => r.Reservation)
                                                   .FirstOrDefaultAsync(r => r.ReservationDetailID == id);

            //delete the registration detail
            _context.ReservationDetails.Remove(reservationDetail);
            await _context.SaveChangesAsync();

            //return the user to the registration/details page
            return RedirectToAction("Details", "Reservations", new { id = reservationDetail.Reservation.ReservationID });
        }

        private SelectList GetAllProperties()
        {
            //create a list for all the courses
            List<Property> allProperties = _context.Properties.ToList();

            //the user MUST select a property, so you don't need a dummy option for no property

            //use the constructor on select list to create a new select list with the options
            SelectList slAllProperties = new SelectList(allProperties, nameof(Property.PropertyID), nameof(Property.FullAddress));

            return slAllProperties;
        }
    }
}