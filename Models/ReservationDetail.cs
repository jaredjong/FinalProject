using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Group12_FinalProject.Models
{
    public class ReservationDetail
    {
        public Int32 ReservationDetailID { get; set; }

        [Display(Name = "Stay Price: ")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal StayPrice { get; set; }

        public DateTime ReservationStartDate { get; set; }

        public DateTime CurrentDate { get; set; }

        public DateTime ReservationEndDate { get; set; }


        public List<DateTime> dates
        {
            get
            {

                var dates_local = new List<DateTime>();

                for (var dt = ReservationStartDate; dt <= ReservationEndDate; dt = dt.AddDays(1))
                {
                    dates_local.Add(dt);
                }

                return dates_local;

            }

        }

        public Int32 NumberOfWeekDays
        {
            get
            {
                Int32 mondays = dates.Where(d => d.DayOfWeek == DayOfWeek.Monday).Count();
                Int32 tuesdays = dates.Where(d => d.DayOfWeek == DayOfWeek.Tuesday).Count();
                Int32 wednesdays = dates.Where(d => d.DayOfWeek == DayOfWeek.Wednesday).Count();
                Int32 thursdays = dates.Where(d => d.DayOfWeek == DayOfWeek.Thursday).Count();
                Int32 sundays = dates.Where(d => d.DayOfWeek == DayOfWeek.Sunday).Count();

                return mondays + tuesdays + wednesdays + thursdays + sundays;
            }
        }

        public Int32 NumberOfWeekendDays
        {
            get
            {
                Int32 saturdays = dates.Where(d => d.DayOfWeek == DayOfWeek.Saturday).Count();
                Int32 fridays = dates.Where(d => d.DayOfWeek == DayOfWeek.Friday).Count();

                return saturdays + fridays;
            }
        }


        [Display(Name = "Number of Days: ")]
        public Int32 NumberofDays {
            get

            {
                return NumberOfWeekDays + NumberOfWeekendDays;
            }

        }


        //Navigaional Properties
        //have relational/ navigationl property like homework 5: acts similarily to Order = Reservation, OrderDetail = ReservationDetail?
        public Reservation Reservation { get; set; }

        //have relational/ navigationl property like homework 5: acts similarily to Product = Property, OrderDetail = ReservationDetail?
        public Property Property { get; set; }
    }
}

