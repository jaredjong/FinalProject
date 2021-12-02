using Group12_FinalProject.DAL;
using Group12_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group12_FinalProject.Seeding
{
    public static class SeedCategories
    {
        public static void SeedAllCategories(AppDbContext db)
        {
            // check to see if all the categories have already been added
            if (db.Categories.Count() == 5)
            {
                //exit the program - we don't need to do any of this
                NotSupportedException ex = new NotSupportedException("Category record count is already 5!");
                throw ex;
            }
            Int32 intCategoriesAdded = 0;
            try
            {
                //Create a list of languages
                List<Category> Categories = new List<Category>();

                Category c1 = new Category() { CategoryName = "Apartment" };
                Categories.Add(c1);

                Category c2 = new Category() { CategoryName = "Cabin" };
                Categories.Add(c2);

                Category c3 = new Category() { CategoryName = "Condo" };
                Categories.Add(c3);

                Category c4 = new Category() { CategoryName = "Hotel" };
                Categories.Add(c4);

                Category c5 = new Category() { CategoryName = "House" };
                Categories.Add(c5);

                foreach (Category categoryToAdd in Categories)
                {
                    Category dbCategory = db.Categories.FirstOrDefault(g => g.CategoryName == categoryToAdd.CategoryName);
                    if (dbCategory == null)
                    {
                        db.Categories.Add(categoryToAdd);
                        db.SaveChanges();
                        intCategoriesAdded += 1;
                    }
                }
            }
            catch
            {
                String msg = "Categories Added: " + intCategoriesAdded.ToString();
                throw new InvalidOperationException(msg);
            }
        }
    }
}

