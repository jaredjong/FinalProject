using System;
using System.ComponentModel.DataAnnotations;
namespace Group12_FinalProject.Models
{
    //Search Price Options enum
    public enum SearchPriceOptions
    {
       Above, Below
    }

    //Search Rating Options enum
    public enum SearchRatingOptions
    {
        Above, Below
    }

    //Search Pets allowed enum
    public enum SearchPetsAllowed
    {
        Yes, No
    }

    //Search Free Parking enum
    public enum SearchFreeParking
    {
        Yes, No
    }

    public class PropertySearchViewModel
    {
        // city search
        [Display(Name = "Search by City:")]
         public String SearchCity { get; set; }

        //state search
            [Display(Name = "Search by State:")]
            public String SearchState { get; set; }

        //guest rating search
            [Display(Name = "Search by Guest Rating:")]
            [Range(maximum: 5.0, minimum: 0.0)]
             public Decimal? SearchGuestRating { get; set; }

        // search for above and below Rating
        [Display(Name = "Type of Rating Search:")]
        public SearchRatingOptions? RatingSearchType { get; set; }

        //number of guests search
        [Display(Name = "Search by Number of Guests:")]
            public Int32? SearchGuestsAllowed { get; set; }

        //search  daily price
            [Display(Name = "Search by Daily Price:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(minimum:0, maximum: double.PositiveInfinity)]
            public Decimal? SearchDailyPrice { get; set; }

        // search for above and below price
        [Display(Name = "Type of Price Search:")]
        public SearchPriceOptions? PriceSearchType { get; set; }

        // search category- do i need to do this by category ID?? - look at hw 3... said like this... TO DO: change home controller
        [Display(Name = "Search by Category:")]
        [Required(ErrorMessage = "Category is required.")]
        public Int32? SelectedCategoryID { get; set; }

        //search bathrooms
        [Display(Name = "Search by Number of Bathrooms:")]
        public Int32? SearchBathroom { get; set; }

        //search bedrooms
        [Display(Name = "Search by Number of Bedrooms:")]
        public Int32? SearchBedroom { get; set; }

        [Display(Name = "Search by Pets Allowed:")]
        //This is nullable so they can select the "All Majors" option that doesn't exist in the enum
        public SearchPetsAllowed? SelectedPetsAllowed { get; set; }

        [Display(Name = "Search by Free Parking:")]
        //This is nullable so they can select the "All Majors" option that doesn't exist in the enum
        public SearchFreeParking? SelectedFreeParking { get; set; }


        //Search Date
        // need to be searching reservation for when a property does NOT have a reservation
        [Display(Name = "Search by Check In Date:")]
        [DataType(DataType.Date)]
        public DateTime SelectedCheckInDate { get; set; }

        // need to be searching reservation for when a property does NOT have a reservation
        [Display(Name = "Search by Check Out Date:")]
        [DataType(DataType.Date)]
        public DateTime SelectedCheckOutDate { get; set; }



    }
}
