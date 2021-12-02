using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;

//TODO: Change this namespace to match your project
namespace Group12_FinalProject.Models
{ 
    //NOTE: This is the view model used to allow the user to login
    //The user only needs teh email and password to login
    public class LoginViewModel
    {
        // no two emails should be the same
        //cannot change email
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        // can change password
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    //NOTE: This is the view model used to register a user
    //When the user registers, they only need to specify the
    //properties listed in this model
    public class RegisterViewModel
    {
        //NOTE: Here is the property for email
        // no two emails should be the same
        //cannot change email
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public Int32 ZipCode { get; set; }

        //NOTE: Here is the property for phone number
        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        //NOTE: Here is the property for phone number
        [Required(ErrorMessage = "Birthday is required")]
        //TO DO: [AccountViewModel.Birthday = DateTime.Now)]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }


        //TODO: Add any fields that you need for creating a new user
        //First name is provided as an example
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        //NOTE: Here is the logic for putting in a password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    //NOTE: This is the view model used to allow the user to 
    //change their password
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangeBirthdayViewModel
    {
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Current Birthday")]
        public DateTime OldBirthday { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "New Birthday")]
        public DateTime NewBirthday { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Confirm new Birthday")]
        [Compare("NewBirthday", ErrorMessage = "The new birthday and confirmation birthday do not match.")]
        public DateTime ConfirmBirthday { get; set; }
    }

    public class ChangePhoneNumberViewModel
    {
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Current Phone Number")]
        public string OldPhoneNumber { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "New Phone Number")]
        public string NewPhoneNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Confirm new Phone Number")]
        [Compare("NewPhoneNumber", ErrorMessage = "The new Phone Number and confirmation Phone Number do not match.")]
        public string ConfirmPhoneNumber { get; set; }
    }

    public class ChangeStreetAddressViewModel
    {
        [Required]
        [Display(Name = "Current Street Address")]
        public string OldStreetAddress { get; set; }

        [Required]
        [Display(Name = "New Street Address")]
        public string NewStreetAddress { get; set; }

        [Display(Name = "Confirm new Street Address")]
        [Compare("NewStreetAddress", ErrorMessage = "The new Street Address and confirmation Street Address do not match.")]
        public string ConfirmStreetAddress { get; set; }
    }

    //NOTE: This is the view model used to display basic user information
    //on the index page
    public class IndexViewModel
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime Birthday { get; set; }
        public bool HasPassword { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public String UserID { get; set; }
        public String StreetAddress { get; set; }
        public String PhoneNumber { get; set; }
    }
}
