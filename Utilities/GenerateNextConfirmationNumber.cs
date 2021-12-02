using Group12_FinalProject.DAL;
using System;
using System.Linq;


namespace Group12_FinalProject.Utilities
{
    public static class GenerateNextConfirmationNumber
    {
        public static Int32 GetNextConfirmationNumber(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int32 START_NUMBER = 70000;

            Int32 intMaxConfirmationNumber; //the current maximum course number
            Int32 intNextConfirmationNumber; //the Reservation number for the next class

            if (_context.Reservations.Count() == 0) //there are no order in the database yet
            {
                intMaxConfirmationNumber = START_NUMBER; //registration numbers start at 101
            }
            else
            {
                intMaxConfirmationNumber = _context.Reservations.Max(c => c.ConfirmationNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxConfirmationNumber < START_NUMBER)
            {
                intMaxConfirmationNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextConfirmationNumber = intMaxConfirmationNumber + 1;

            //return the value
            return intNextConfirmationNumber;
        }

    }
}

