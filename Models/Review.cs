using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Group12_FinalProject.Models
{ 
    // dispute review enum
    public enum DisputeStatus { Disputed, Rejected, Accepted }

    public class Review
    {
        //review id
        public Int32 ReviewID { get; set; }

        //rating
        [Display(Name = "Rating: ")]
        [Range(maximum: 5, minimum: 1)]
        [Required(ErrorMessage = "You must leave a rating for this property!")]
        public Int32 Rating { get; set; }

        //customer review text
        [Display(Name = "Review (optional): ")]
        [StringLength(280, MinimumLength = 0, ErrorMessage = "Customer Review must be less than 280 characters")]
        public String Cust_Review { get; set; }

        ////Address
        //[Display(Name = "Address: ")]
        //public String Address { get; set; }

        //dispute status
        [Display(Name = "Status: ")]
        public DisputeStatus DisputeStatus { get; set; }

        public Property Property { get; set; }

        public AppUser User { get; set; }

      
    }
}

