using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Group12_FinalProject.Models
{
    public class AppUser : IdentityUser
    {

        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First name is required.")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last name is required.")]
        public String LastName { get; set; }

        [Display(Name ="Full Name:")]
        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [Display(Name = "Zip Code:")]
        public Int32 ZipCode { get; set; }

        [Display(Name = "Birthday:")]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Street Address:")]
        public String StreetAddress { get; set; }

        //piazza said do not need to include middle inital and ssn for seeding
        public List<Reservation> Reservations { get; set; }

        public List<Property> Properties { get; set; }

        public List<Review> Reviews { get; set; }

        public AppUser()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }

            if (Properties == null)
            {
                Properties = new List<Property>();
            }
        }
    }
}
