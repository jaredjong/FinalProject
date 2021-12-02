using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Group12_FinalProject.Models
{
    public enum reservationStatus
    {
        Past, Future, Cancelled
    }

    public class Reservation 
    // add property inherit?
    {
        public Int32 ReservationID { get; set; }

        public Int32 ConfirmationNumber { get; set; }

        private const Decimal TAX_RATE = .0825m;

        //check in date not be before "today's" date.. meaning must reserve after the date of making the reservation.
        // somehow need to make it to where the reservation cannot be schedule as the same date as another customer who has already reserved those dates
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime CheckInDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime CheckOutDate { get; set; }

        [Range(1, 1000, ErrorMessage = "Number of guests must be at least 1.")]
        public Int32 NumberofGuests { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime CurrentDate { get; set; }


        //reservation status- past, future, cancelled
        [Display(Name = "Reservation Status:")]
        public reservationStatus ReservationStatus { get; set; }

        //Navigaional Properties
        //have relational/ navigationl property like homework 5: acts similarily to Order = Reservation, OrderDetail = ReservationDetail?
        public List<ReservationDetail> ReservationDetails { get; set; }

        //have relational/ navigationl property like homework 5: for app user
        public AppUser User { get; set; }

        public Reservation()
        {
            //have relational/ navigationl property like homework 5: acts similarily to Product = Property, OrderDetail = ReservationDetail?
            if (ReservationDetails == null)
            {
                ReservationDetails = new List<ReservationDetail>();
            }
        }
    }
}
