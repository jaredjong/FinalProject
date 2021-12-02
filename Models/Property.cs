using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Group12_FinalProject.Models
{
    
    //parking enum
    public enum parkingfee
    {
        Yes, No
    }

    public enum petsAllowed
    {
        Yes, No
    }

    public enum activityStatus
    {
        Active, Inactive
    }

    public class Property
    {
        //propertyID
        public Int32 PropertyID { get; set; }

        //propertynumber
        public Int32 PropertyNumber { get; set; }

        [Display(Name = "Zip:")]
        public Int32 Zip { get; set; }

        //city
        [Display(Name = "City:")]
        public String City { get; set; }

        //state
        [Display(Name = "State:")]
        public String State { get; set; }

        //Street
        [Display(Name = "Street:")]
        public String Street { get; set; }

        // full address
        [Display(Name = "Full Address:")]
        public String FullAddress
        {
            get { return Street + " " + City + " " + State + " " + Zip; }
        }

    //guest ratings
    [Display(Name = "Guest Ratings:")]
        [Range(maximum: 5.0, minimum: 1.0)]
        public Decimal GuestRating { get; set; }

        //number of guests
        [Display(Name = "Number of Guests Allowed:")]
        public Int32 GuestsAllowed { get; set; }

        // prices
        //Weekend
        [Display(Name = "Weekend Price:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal WeekendPrice { get; set; }

        //Weekday
        [Display(Name = "Weekday Price:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal WeekDayPrice { get; set; }

        //cleaning fee
        [Display(Name = "Cleaning Fee:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal CleaningFee { get; set; }

        [Display(Name = "Discount:")]
        public Decimal Discount { get; set; }

        // number of bedrooms
        [Display(Name = "Number of Bedrooms:")]
        public Int32 Bedroom { get; set; }

        //number of bathrooms
        [Display(Name = "Number of Bathrooms:")]
        public Int32 Bathroom { get; set; }

        //pets allowed
        [Display(Name = "Pets Allowed:")]
        public petsAllowed PetsAllowed { get; set; }

        //free parking
        [Display(Name = "Free Parking:")]
        public parkingfee ParkingFee { get; set; }

        //property status- active or inactive
        [Display(Name = "Activity Status:")]
        public activityStatus ActivityStatus { get; set; }

        // does there somehow need to be a date availability property??? need to compare for the search

        //navigaional properties
        //have relational/ navigationl property like homework 3: acts similarily to Genre= Category, Book= Property
        public Category Category { get; set; }

        // relational/ navigational property for the properties to show according to what the host owns (connect with App User)
        public AppUser User { get; set; }

        //have relational/ navigationl property like homework 5: acts similarily to Product = Property, OrderDetail = ReservationDetail?
        public List<Review> Reviews { get; set; }

        //have relational/ navigationl property like homework 5: acts similarily to Product = Property, Supplier = Review ? (I think this is a diff relationship although?)
        public List<ReservationDetail> ReservationDetails { get; set; }


        public Property()
        {

            //have relational/ navigationl property like homework 5: acts similarily to Product = Property, OrderDetail = ReservationDetail?
            if (ReservationDetails == null)
            {
                ReservationDetails = new List<ReservationDetail>();
            }

        
            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }

        }
        }
    }
