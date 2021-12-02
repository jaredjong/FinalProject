using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Group12_FinalProject.Models
{
    public class Category
    {
        public Int32? CategoryID { get; set; }

        [Display(Name = "Category Name")]
        public String CategoryName { get; set; }

        //navigational property for Property - a single category will be associated with many properties
        //have this relational/ navigationl property like homework 3: acts similarily to Genre= Category, Book= Property
        public List<Property> Properties { get; set; }

    }
}
