using Group12_FinalProject.DAL;
using Group12_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    namespace Group12_FinalProject.Seeding
    {
        public static class SeedReviews
        {
            public static void SeedOneReview(AppDbContext db)
            {
                //Create a counter and a flag so we will know which record is causing problems
                Int32 intReviewsAdded = 0;
                Int32 intReviewID = 1; // what to do for counter: needd to ID because if it is the rating then it will replace the others

                //Add the list of books
                List<Review> Reviews = new List<Review>();
			Review r1 = new Review()
			{
                ReviewID = 7,
                Rating = 5,
                Cust_Review = " ",
                User = db.Users.FirstOrDefault(c => c.Email == "orielly@foxnets.com"),
                Property = db.Properties.FirstOrDefault(c => c.Street + " " + c.City + " " + c.State + " " + Convert.ToString(c.Zip) == "693 Michael Estate, Lake Michael, NM 03009")
            };
			//Add this review to the list of reviews to add
			Reviews.Add(r1);



			// how would I code the reivews addresss and the email? to connect to the customer who left the review
			// not sure if the address is correct because it does not refer to the property... but I get an error when I try the other way



			//Add this book to the list of books to add


			try  //attempt to add or update the book
                {
                    //loop through each of the books in the list
                    foreach (Review reviewToAdd in Reviews)
                    {
                    //set the flag to the current title to help with debugging
                    intReviewID = reviewToAdd.ReviewID;

                        //look to see if the book is in the database - this assumes that no
                        //two books have the same title
                        Review dbReview = db.Reviews.FirstOrDefault(r => r.ReviewID == reviewToAdd.ReviewID);

                        //if the dbBook is null, this title is not in the database
                        if (dbReview == null)
                        {
                            //add the book to the database and save changes
                            db.Reviews.Add(reviewToAdd);
                            db.SaveChanges();

                            //update the counter to help with debugging
                            intReviewsAdded += 1;
                        }
                        else //dbBook is not null - this title *is* in the database
                        {
                            //update all of the book's properties
                            dbReview.Rating = reviewToAdd.Rating;
                            dbReview.Cust_Review = reviewToAdd.Cust_Review;
                        dbReview.ReviewID = reviewToAdd.ReviewID;

                        // i do not think this is correct becasue it is not connecting with the property, go to office hours again
                        dbReview.Property = reviewToAdd.Property;
                        dbReview.User = reviewToAdd.User;
                        //update the database and save the changes
                        db.Update(dbReview);
                            db.SaveChanges();

                            //update the counter to help with debugging
                            intReviewsAdded += 1;
                        } //this is the end of the else
                    } //this is the end of the foreach loop for the books
                }//this is the end of the try block

                catch (Exception ex)//something went wrong with adding or updating
                {
                    //Build a messsage using the flags we created
                    String msg = "  Repositories added:" + intReviewsAdded + "; Error on " + intReviewID;

                    //throw the exception with the new message
                    throw new InvalidOperationException(ex.Message + msg);
                }
            }
        }
    }


