using Group12_FinalProject.DAL;
using Group12_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group12_FinalProject.Seeding
{
	public static class SeedProperties
	{
		public static void SeedOneProperty(AppDbContext db)
		{
			Int32 intPropertiesAdded = 0;
			String strPropertyStreet = "Begin";
			 			//Add the list of books
			List<Property> Properties = new List<Property>();
			Property p1 = new Property()
			{
				Zip = 72227,
				State = "PA",
				Street = "8714 Mann Plaza",
				City = "Lisaside",
				WeekendPrice = 171.57m,
				WeekDayPrice = 152.68m,
				CleaningFee = 8.88m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 5,
				Bathroom = 6,
				GuestsAllowed = 9,
			};
			p1.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p1.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p1);

			Property p2 = new Property()
			{
				Zip = 05565,
				State = "FL",
				Street = "96593 White View Apt. 094",
				City = "Jonesberg",
				WeekendPrice = 148.15m,
				WeekDayPrice = 120.81m,
				CleaningFee = 8.02m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 8,
				GuestsAllowed = 8,
			};
			p2.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p2.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p2);

			Property p3 = new Property()
			{
				Zip = 80819,
				State = "MD",
				Street = "848 Melissa Springs Suite 947",
				City = "Kellerstad",
				WeekendPrice = 132.99m,
				WeekDayPrice = 127.96m,
				CleaningFee = 13.37m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 8,
			};
			p3.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p3.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p3);

			Property p4 = new Property()
			{
				Zip = 79428,
				State = "ND",
				Street = "30413 Norton Isle Suite 012",
				City = "North Lisa",
				WeekendPrice = 185.35m,
				WeekDayPrice = 80.2m,
				CleaningFee = 5.57m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 14,
			};
			p4.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p4.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p4);

			Property p5 = new Property()
			{
				Zip = 63315,
				State = "DE",
				Street = "39916 Mitchell Crescent",
				City = "New Andrewburgh",
				WeekendPrice = 100.37m,
				WeekDayPrice = 170.25m,
				CleaningFee = 18.64m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 2,
				Bathroom = 3,
				GuestsAllowed = 12,
			};
			p5.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p5.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p5);

			Property p6 = new Property()
			{
				Zip = 24135,
				State = "NE",
				Street = "086 Mary Cliff",
				City = "North Deborah",
				WeekendPrice = 162.6m,
				WeekDayPrice = 220.24m,
				CleaningFee = 10.83m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 9,
				GuestsAllowed = 2,
			};
			p6.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p6.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p6);

			Property p7 = new Property()
			{
				Zip = 58475,
				State = "PA",
				Street = "91634 Strong Mountains Apt. 302",
				City = "West Alyssa",
				WeekendPrice = 204.87m,
				WeekDayPrice = 213.37m,
				CleaningFee = 25.04m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 9,
			};
			p7.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p7.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p7);

			Property p8 = new Property()
			{
				Zip = 10865,
				State = "WA",
				Street = "6984 Price Shoals",
				City = "Erictown",
				WeekendPrice = 140.89m,
				WeekDayPrice = 159.69m,
				CleaningFee = 27.13m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 2,
				Bathroom = 3,
				GuestsAllowed = 8,
			};
			p8.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p8.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p8);

			Property p9 = new Property()
			{
				Zip = 51359,
				State = "ME",
				Street = "423 Bell Heights",
				City = "Brittanyberg",
				WeekendPrice = 295.39m,
				WeekDayPrice = 200.73m,
				CleaningFee = 14.91m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 3,
				GuestsAllowed = 4,
			};
			p9.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p9.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p9);

			Property p10 = new Property()
			{
				Zip = 87296,
				State = "WI",
				Street = "93523 Dana Lane",
				City = "Johnsonshire",
				WeekendPrice = 110.8m,
				WeekDayPrice = 170.39m,
				CleaningFee = 8.67m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 6,
				GuestsAllowed = 3,
			};
			p10.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p10.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p10);

			Property p11 = new Property()
			{
				Zip = 07035,
				State = "NH",
				Street = "1427 Odonnell Rapids",
				City = "North Troyport",
				WeekendPrice = 126.29m,
				WeekDayPrice = 217.15m,
				CleaningFee = 26.48m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 3,
				GuestsAllowed = 14,
			};
			p11.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p11.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p11);

			Property p12 = new Property()
			{
				Zip = 37198,
				State = "ME",
				Street = "81206 Stewart Forest Apt. 089",
				City = "East Davidborough",
				WeekendPrice = 293.26m,
				WeekDayPrice = 205.21m,
				CleaningFee = 28.74m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 5,
				GuestsAllowed = 8,
			};
			p12.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p12.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p12);

			Property p13 = new Property()
			{
				Zip = 85034,
				State = "SD",
				Street = "76104 Marsh Crescent",
				City = "Dennishaven",
				WeekendPrice = 126.99m,
				WeekDayPrice = 123.13m,
				CleaningFee = 18.73m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 7,
				GuestsAllowed = 4,
			};
			p13.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p13.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p13);

			Property p14 = new Property()
			{
				Zip = 60619,
				State = "SD",
				Street = "0003 Grant Lakes",
				City = "Port Karafort",
				WeekendPrice = 188.81m,
				WeekDayPrice = 89.19m,
				CleaningFee = 11.98m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 5,
				GuestsAllowed = 14,
			};
			p14.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p14.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p14);

			Property p15 = new Property()
			{
				Zip = 21978,
				State = "KY",
				Street = "236 Smith Drive Suite 555",
				City = "West Kimberlyton",
				WeekendPrice = 132.96m,
				WeekDayPrice = 198.3m,
				CleaningFee = 13.96m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 11,
			};
			p15.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p15.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p15);

			Property p16 = new Property()
			{
				Zip = 14742,
				State = "MT",
				Street = "6824 Timothy Garden Apt. 428",
				City = "West Richardmouth",
				WeekendPrice = 297.31m,
				WeekDayPrice = 181.5m,
				CleaningFee = 10.09m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 6,
				GuestsAllowed = 10,
			};
			p16.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p16.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p16);

			Property p17 = new Property()
			{
				Zip = 11894,
				State = "SC",
				Street = "5517 Holly Meadow Apt. 452",
				City = "Lake Anne",
				WeekendPrice = 139.22m,
				WeekDayPrice = 134.09m,
				CleaningFee = 9.75m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 1,
			};
			p17.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p17.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p17);

			Property p18 = new Property()
			{
				Zip = 28976,
				State = "TX",
				Street = "30601 Hawkins Highway",
				City = "Morashire",
				WeekendPrice = 160.61m,
				WeekDayPrice = 187.65m,
				CleaningFee = 7.5m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 5,
				GuestsAllowed = 9,
			};
			p18.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p18.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p18);

			Property p19 = new Property()
			{
				Zip = 28798,
				State = "AZ",
				Street = "49263 Wilson View Apt. 873",
				City = "South Raymondborough",
				WeekendPrice = 133.25m,
				WeekDayPrice = 206.95m,
				CleaningFee = 14.04m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 5,
			};
			p19.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p19.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p19);

			Property p20 = new Property()
			{
				Zip = 68819,
				State = "NE",
				Street = "76582 Vanessa Oval",
				City = "New Richard",
				WeekendPrice = 242.89m,
				WeekDayPrice = 99.54m,
				CleaningFee = 6.61m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 5,
				Bathroom = 4,
				GuestsAllowed = 12,
			};
			p20.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p20.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p20);

			Property p21 = new Property()
			{
				Zip = 50177,
				State = "FL",
				Street = "7389 Alec Squares Suite 508",
				City = "Port Jonathan",
				WeekendPrice = 165.32m,
				WeekDayPrice = 112.62m,
				CleaningFee = 24.26m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 7,
				GuestsAllowed = 12,
			};
			p21.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p21.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p21);

			Property p22 = new Property()
			{
				Zip = 66355,
				State = "NC",
				Street = "18013 Billy Bridge Suite 522",
				City = "Schmitthaven",
				WeekendPrice = 119.02m,
				WeekDayPrice = 199.21m,
				CleaningFee = 11.63m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 4,
				GuestsAllowed = 2,
			};
			p22.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p22.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p22);

			Property p23 = new Property()
			{
				Zip = 51431,
				State = "NJ",
				Street = "891 Bullock Ford",
				City = "Amandachester",
				WeekendPrice = 244.93m,
				WeekDayPrice = 179.05m,
				CleaningFee = 21.78m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 5,
				Bathroom = 6,
				GuestsAllowed = 11,
			};
			p23.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p23.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p23);

			Property p24 = new Property()
			{
				Zip = 50853,
				State = "MT",
				Street = "02489 Cook Park",
				City = "Sherriport",
				WeekendPrice = 227.35m,
				WeekDayPrice = 207.24m,
				CleaningFee = 5.5m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 3,
				GuestsAllowed = 6,
			};
			p24.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p24.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p24);

			Property p25 = new Property()
			{
				Zip = 20341,
				State = "UT",
				Street = "23450 Timothy Divide",
				City = "Wuland",
				WeekendPrice = 278.36m,
				WeekDayPrice = 116.01m,
				CleaningFee = 24.73m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 4,
				GuestsAllowed = 11,
			};
			p25.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p25.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p25);

			Property p26 = new Property()
			{
				Zip = 85565,
				State = "OH",
				Street = "0976 Williams Mountains Apt. 009",
				City = "Lake Mario",
				WeekendPrice = 293.42m,
				WeekDayPrice = 225.14m,
				CleaningFee = 10.42m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 6,
				Bathroom = 7,
				GuestsAllowed = 7,
			};
			p26.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p26.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p26);

			Property p27 = new Property()
			{
				Zip = 51884,
				State = "WY",
				Street = "1097 Santos Springs Suite 264",
				City = "New Michelleborough",
				WeekendPrice = 126.45m,
				WeekDayPrice = 70.24m,
				CleaningFee = 18.69m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 2,
				Bathroom = 2,
				GuestsAllowed = 4,
			};
			p27.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p27.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p27);

			Property p28 = new Property()
			{
				Zip = 66353,
				State = "SC",
				Street = "5100 Scott Burg",
				City = "East Clayton",
				WeekendPrice = 224.07m,
				WeekDayPrice = 186.38m,
				CleaningFee = 28.24m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 4,
				Bathroom = 3,
				GuestsAllowed = 3,
			};
			p28.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p28.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p28);

			Property p29 = new Property()
			{
				Zip = 57004,
				State = "NV",
				Street = "412 Snow Manors Apt. 161",
				City = "South Kimtown",
				WeekendPrice = 120.93m,
				WeekDayPrice = 112.47m,
				CleaningFee = 23.28m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 9,
			};
			p29.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p29.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p29);

			Property p30 = new Property()
			{
				Zip = 48447,
				State = "IN",
				Street = "5415 David Square",
				City = "West Michaeltown",
				WeekendPrice = 100.02m,
				WeekDayPrice = 214.81m,
				CleaningFee = 17.78m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 9,
				GuestsAllowed = 1,
			};
			p30.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p30.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p30);

			Property p31 = new Property()
			{
				Zip = 62982,
				State = "DE",
				Street = "03104 Norris Rapids",
				City = "Port Donald",
				WeekendPrice = 161.6m,
				WeekDayPrice = 159.87m,
				CleaningFee = 10.34m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 11,
			};
			p31.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p31.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p31);

			Property p32 = new Property()
			{
				Zip = 16915,
				State = "FL",
				Street = "03557 Phillips Wells Suite 291",
				City = "New Beverlyburgh",
				WeekendPrice = 203.6m,
				WeekDayPrice = 70.55m,
				CleaningFee = 5.09m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 6,
				GuestsAllowed = 4,
			};
			p32.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p32.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p32);

			Property p33 = new Property()
			{
				Zip = 39742,
				State = "MT",
				Street = "332 Watson Shore Apt. 290",
				City = "Millerland",
				WeekendPrice = 299.34m,
				WeekDayPrice = 176.37m,
				CleaningFee = 17.38m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 3,
				GuestsAllowed = 2,
			};
			p33.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p33.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p33);

			Property p34 = new Property()
			{
				Zip = 54060,
				State = "MS",
				Street = "645 John Roads",
				City = "Danahaven",
				WeekendPrice = 229.98m,
				WeekDayPrice = 172.83m,
				CleaningFee = 23.55m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 6,
				GuestsAllowed = 14,
			};
			p34.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p34.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p34);

			Property p35 = new Property()
			{
				Zip = 55774,
				State = "HI",
				Street = "3547 Stephanie Underpass Apt. 418",
				City = "Port Jacqueline",
				WeekendPrice = 143.71m,
				WeekDayPrice = 177.08m,
				CleaningFee = 19.21m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 1,
				GuestsAllowed = 5,
			};
			p35.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p35.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p35);

			Property p36 = new Property()
			{
				Zip = 59363,
				State = "UT",
				Street = "5825 Welch Corners",
				City = "Fischerport",
				WeekendPrice = 113.86m,
				WeekDayPrice = 76.66m,
				CleaningFee = 27.87m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 4,
				GuestsAllowed = 10,
			};
			p36.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p36.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p36);

			Property p37 = new Property()
			{
				Zip = 71770,
				State = "IN",
				Street = "41489 Roger Terrace",
				City = "Davisfort",
				WeekendPrice = 299.09m,
				WeekDayPrice = 177.37m,
				CleaningFee = 23.78m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 6,
				Bathroom = 8,
				GuestsAllowed = 6,
			};
			p37.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p37.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p37);

			Property p38 = new Property()
			{
				Zip = 05147,
				State = "CO",
				Street = "014 Aaron Locks Suite 714",
				City = "Justinborough",
				WeekendPrice = 158.42m,
				WeekDayPrice = 104.05m,
				CleaningFee = 5.36m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 2,
				Bathroom = 2,
				GuestsAllowed = 5,
			};
			p38.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p38.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p38);

			Property p39 = new Property()
			{
				Zip = 28062,
				State = "SC",
				Street = "8518 Pamela Track Apt. 164",
				City = "Aprilshire",
				WeekendPrice = 210.59m,
				WeekDayPrice = 199.37m,
				CleaningFee = 8.83m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 2,
				GuestsAllowed = 1,
			};
			p39.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p39.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p39);

			Property p40 = new Property()
			{
				Zip = 88090,
				State = "OH",
				Street = "864 Ramos Port Apt. 211",
				City = "Moralesmouth",
				WeekendPrice = 153.69m,
				WeekDayPrice = 94.48m,
				CleaningFee = 16.85m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 5,
				GuestsAllowed = 9,
			};
			p40.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p40.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p40);

			Property p41 = new Property()
			{
				Zip = 28775,
				State = "RI",
				Street = "637 Neal Island Suite 074",
				City = "Lake Tyler",
				WeekendPrice = 196.14m,
				WeekDayPrice = 88.82m,
				CleaningFee = 6.97m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 3,
				GuestsAllowed = 14,
			};
			p41.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p41.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p41);

			Property p42 = new Property()
			{
				Zip = 75585,
				State = "WV",
				Street = "0811 Smith Canyon Apt. 904",
				City = "Jessicabury",
				WeekendPrice = 123.22m,
				WeekDayPrice = 119.58m,
				CleaningFee = 18.45m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 5,
				GuestsAllowed = 2,
			};
			p42.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p42.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p42);

			Property p43 = new Property()
			{
				Zip = 17438,
				State = "MD",
				Street = "7562 Fisher Spur",
				City = "Hernandezberg",
				WeekendPrice = 283.77m,
				WeekDayPrice = 218.87m,
				CleaningFee = 19.07m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 2,
			};
			p43.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p43.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p43);

			Property p44 = new Property()
			{
				Zip = 07027,
				State = "VT",
				Street = "5667 Blair Underpass",
				City = "South Shelby",
				WeekendPrice = 239.76m,
				WeekDayPrice = 76.19m,
				CleaningFee = 11.37m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 2,
				Bathroom = 4,
				GuestsAllowed = 13,
			};
			p44.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p44.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p44);

			Property p45 = new Property()
			{
				Zip = 01008,
				State = "MI",
				Street = "6708 Carpenter Overpass Suite 735",
				City = "Bobbyton",
				WeekendPrice = 229.04m,
				WeekDayPrice = 161.17m,
				CleaningFee = 25.01m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 7,
				GuestsAllowed = 7,
			};
			p45.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p45.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p45);

			Property p46 = new Property()
			{
				Zip = 60236,
				State = "ND",
				Street = "16396 Shawn Junction",
				City = "New Nicolemouth",
				WeekendPrice = 220.69m,
				WeekDayPrice = 106.06m,
				CleaningFee = 11.82m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 4,
				GuestsAllowed = 6,
			};
			p46.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p46.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p46);

			Property p47 = new Property()
			{
				Zip = 01707,
				State = "CA",
				Street = "4486 Olson Well",
				City = "North Kevin",
				WeekendPrice = 138.96m,
				WeekDayPrice = 151.44m,
				CleaningFee = 6.72m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 7,
				GuestsAllowed = 10,
			};
			p47.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p47.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p47);

			Property p48 = new Property()
			{
				Zip = 33233,
				State = "HI",
				Street = "67771 Christopher Courts Apt. 637",
				City = "Port Ronaldfurt",
				WeekendPrice = 134.28m,
				WeekDayPrice = 102.43m,
				CleaningFee = 19.81m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 5,
				Bathroom = 5,
				GuestsAllowed = 2,
			};
			p48.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p48.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p48);

			Property p49 = new Property()
			{
				Zip = 79756,
				State = "NY",
				Street = "5561 Bishop Turnpike",
				City = "Lake Kenneth",
				WeekendPrice = 259.87m,
				WeekDayPrice = 94.31m,
				CleaningFee = 22.33m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 11,
			};
			p49.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p49.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p49);

			Property p50 = new Property()
			{
				Zip = 36216,
				State = "SD",
				Street = "3019 Gerald Mall Apt. 340",
				City = "Trevinoville",
				WeekendPrice = 263.32m,
				WeekDayPrice = 151.69m,
				CleaningFee = 13.27m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 5,
				GuestsAllowed = 1,
			};
			p50.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p50.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p50);

			Property p51 = new Property()
			{
				Zip = 43477,
				State = "NY",
				Street = "84331 Leonard Fort Suite 749",
				City = "East Lisa",
				WeekendPrice = 204.28m,
				WeekDayPrice = 204.04m,
				CleaningFee = 11.07m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 8,
				GuestsAllowed = 10,
			};
			p51.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p51.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p51);

			Property p52 = new Property()
			{
				Zip = 17819,
				State = "VA",
				Street = "62281 Kathy Tunnel",
				City = "Hudsonborough",
				WeekendPrice = 224.19m,
				WeekDayPrice = 165.51m,
				CleaningFee = 24.26m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 1,
				GuestsAllowed = 9,
			};
			p52.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p52.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p52);

			Property p53 = new Property()
			{
				Zip = 97149,
				State = "NM",
				Street = "9927 Christina Burg Suite 774",
				City = "East Angelaburgh",
				WeekendPrice = 121.74m,
				WeekDayPrice = 106.87m,
				CleaningFee = 5.62m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 9,
				GuestsAllowed = 6,
			};
			p53.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p53.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p53);

			Property p54 = new Property()
			{
				Zip = 45480,
				State = "IA",
				Street = "142 Warner View Suite 460",
				City = "North Leslie",
				WeekendPrice = 148.76m,
				WeekDayPrice = 212.32m,
				CleaningFee = 20.2m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 9,
			};
			p54.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p54.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p54);

			Property p55 = new Property()
			{
				Zip = 03720,
				State = "AR",
				Street = "5240 Berry Centers",
				City = "West Andrew",
				WeekendPrice = 111.01m,
				WeekDayPrice = 164.02m,
				CleaningFee = 26.21m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 6,
				GuestsAllowed = 12,
			};
			p55.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p55.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p55);

			Property p56 = new Property()
			{
				Zip = 85576,
				State = "HI",
				Street = "51056 Patricia Forge",
				City = "Grahamstad",
				WeekendPrice = 167.53m,
				WeekDayPrice = 117.45m,
				CleaningFee = 24.75m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 9,
				GuestsAllowed = 10,
			};
			p56.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p56.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p56);

			Property p57 = new Property()
			{
				Zip = 92199,
				State = "VA",
				Street = "0648 Malone Port Apt. 662",
				City = "New Devonhaven",
				WeekendPrice = 176.53m,
				WeekDayPrice = 209.47m,
				CleaningFee = 5.83m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 6,
				Bathroom = 5,
				GuestsAllowed = 12,
			};
			p57.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p57.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p57);

			Property p58 = new Property()
			{
				Zip = 05261,
				State = "SC",
				Street = "23028 Jennifer Meadow Apt. 972",
				City = "West Matthewfurt",
				WeekendPrice = 199.1m,
				WeekDayPrice = 153.04m,
				CleaningFee = 18.62m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 14,
			};
			p58.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p58.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p58);

			Property p59 = new Property()
			{
				Zip = 72649,
				State = "LA",
				Street = "2738 Martin Terrace Suite 547",
				City = "Smithhaven",
				WeekendPrice = 199.22m,
				WeekDayPrice = 196.56m,
				CleaningFee = 20.71m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 1,
				GuestsAllowed = 11,
			};
			p59.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p59.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p59);

			Property p60 = new Property()
			{
				Zip = 97488,
				State = "KY",
				Street = "984 Stephen Stravenue",
				City = "South Michaelton",
				WeekendPrice = 178.29m,
				WeekDayPrice = 117.03m,
				CleaningFee = 6.47m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 6,
				GuestsAllowed = 3,
			};
			p60.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p60.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p60);

			Property p61 = new Property()
			{
				Zip = 42837,
				State = "LA",
				Street = "98522 Mathis Viaduct Apt. 909",
				City = "West Michael",
				WeekendPrice = 252.79m,
				WeekDayPrice = 133.35m,
				CleaningFee = 9.15m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 4,
				Bathroom = 4,
				GuestsAllowed = 1,
			};
			p61.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p61.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p61);

			Property p62 = new Property()
			{
				Zip = 56059,
				State = "OH",
				Street = "620 Ashley Mills Apt. 507",
				City = "Julieborough",
				WeekendPrice = 296.05m,
				WeekDayPrice = 171.15m,
				CleaningFee = 18.26m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 9,
			};
			p62.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p62.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p62);

			Property p63 = new Property()
			{
				Zip = 02288,
				State = "LA",
				Street = "212 Shelly Roads",
				City = "Fischerview",
				WeekendPrice = 163.88m,
				WeekDayPrice = 132.81m,
				CleaningFee = 7.46m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 10,
			};
			p63.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p63.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p63);

			Property p64 = new Property()
			{
				Zip = 50851,
				State = "OK",
				Street = "8885 Lee Tunnel Suite 208",
				City = "Port Donna",
				WeekendPrice = 140.73m,
				WeekDayPrice = 228.84m,
				CleaningFee = 17.13m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 7,
				GuestsAllowed = 7,
			};
			p64.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p64.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p64);

			Property p65 = new Property()
			{
				Zip = 03009,
				State = "NM",
				Street = "693 Michael Estate",
				City = "Lake Michael",
				WeekendPrice = 139.83m,
				WeekDayPrice = 155.03m,
				CleaningFee = 21.05m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 5,
				GuestsAllowed = 13,
			};
			p65.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p65.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p65);

			Property p66 = new Property()
			{
				Zip = 92905,
				State = "NY",
				Street = "342 Miller Mission",
				City = "Lake Jennifer",
				WeekendPrice = 249.24m,
				WeekDayPrice = 128.41m,
				CleaningFee = 6.63m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 4,
				Bathroom = 5,
				GuestsAllowed = 1,
			};
			p66.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p66.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p66);

			Property p67 = new Property()
			{
				Zip = 65056,
				State = "AK",
				Street = "71664 Kim Throughway",
				City = "Chelsealand",
				WeekendPrice = 286.53m,
				WeekDayPrice = 163.68m,
				CleaningFee = 25.57m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 8,
				GuestsAllowed = 9,
			};
			p67.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p67.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p67);

			Property p68 = new Property()
			{
				Zip = 11181,
				State = "AZ",
				Street = "66660 Gomez Port Apt. 945",
				City = "South Thomashaven",
				WeekendPrice = 137.17m,
				WeekDayPrice = 93.86m,
				CleaningFee = 28.18m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 3,
				GuestsAllowed = 2,
			};
			p68.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p68.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p68);

			Property p69 = new Property()
			{
				Zip = 53480,
				State = "FL",
				Street = "0131 Williams Ville Apt. 562",
				City = "Richardberg",
				WeekendPrice = 120.61m,
				WeekDayPrice = 86.25m,
				CleaningFee = 11.39m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 6,
				Bathroom = 5,
				GuestsAllowed = 13,
			};
			p69.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p69.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p69);

			Property p70 = new Property()
			{
				Zip = 11353,
				State = "OR",
				Street = "22708 Madison Spurs",
				City = "Herringstad",
				WeekendPrice = 241.25m,
				WeekDayPrice = 182.46m,
				CleaningFee = 18.29m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 7,
				GuestsAllowed = 2,
			};
			p70.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p70.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p70);

			Property p71 = new Property()
			{
				Zip = 05560,
				State = "FL",
				Street = "3454 Holmes Motorway",
				City = "Port Rachel",
				WeekendPrice = 123.04m,
				WeekDayPrice = 89.88m,
				CleaningFee = 19.14m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 3,
				GuestsAllowed = 1,
			};
			p71.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p71.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p71);

			Property p72 = new Property()
			{
				Zip = 93500,
				State = "GA",
				Street = "805 James Turnpike",
				City = "Carrmouth",
				WeekendPrice = 219.86m,
				WeekDayPrice = 81.55m,
				CleaningFee = 13.38m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 5,
				GuestsAllowed = 12,
			};
			p72.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p72.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p72);

			Property p73 = new Property()
			{
				Zip = 44515,
				State = "NV",
				Street = "8081 Smith Trail",
				City = "North Ronaldstad",
				WeekendPrice = 196.09m,
				WeekDayPrice = 130.47m,
				CleaningFee = 14.53m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 7,
				GuestsAllowed = 3,
			};
			p73.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p73.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p73);

			Property p74 = new Property()
			{
				Zip = 07347,
				State = "MS",
				Street = "125 Ian Crossroad Apt. 593",
				City = "South Deannaport",
				WeekendPrice = 136.82m,
				WeekDayPrice = 148.1m,
				CleaningFee = 15.57m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 2,
				Bathroom = 1,
				GuestsAllowed = 4,
			};
			p74.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p74.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p74);

			Property p75 = new Property()
			{
				Zip = 54532,
				State = "NH",
				Street = "1607 Munoz River",
				City = "Emilyshire",
				WeekendPrice = 209.77m,
				WeekDayPrice = 147.55m,
				CleaningFee = 27.65m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 6,
				Bathroom = 7,
				GuestsAllowed = 3,
			};
			p75.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p75.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p75);

			Property p76 = new Property()
			{
				Zip = 65516,
				State = "UT",
				Street = "3615 David Keys Apt. 269",
				City = "West Stephenside",
				WeekendPrice = 126.47m,
				WeekDayPrice = 86.8m,
				CleaningFee = 17.6m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 2,
				Bathroom = 4,
				GuestsAllowed = 3,
			};
			p76.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p76.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p76);

			Property p77 = new Property()
			{
				Zip = 20721,
				State = "AZ",
				Street = "640 Mary Common",
				City = "Michaelville",
				WeekendPrice = 173.01m,
				WeekDayPrice = 121.75m,
				CleaningFee = 12.53m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 4,
				GuestsAllowed = 7,
			};
			p77.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p77.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p77);

			Property p78 = new Property()
			{
				Zip = 43567,
				State = "LA",
				Street = "395 Timothy Road",
				City = "Williamsbury",
				WeekendPrice = 198.1m,
				WeekDayPrice = 160.23m,
				CleaningFee = 10.82m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 5,
			};
			p78.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p78.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p78);

			Property p79 = new Property()
			{
				Zip = 01239,
				State = "OR",
				Street = "3267 Walter Dam",
				City = "Cunninghamtown",
				WeekendPrice = 127.7m,
				WeekDayPrice = 110.64m,
				CleaningFee = 26.67m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 7,
			};
			p79.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p79.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p79);

			Property p80 = new Property()
			{
				Zip = 03966,
				State = "MS",
				Street = "00580 Brandon Creek",
				City = "Port Eric",
				WeekendPrice = 236.71m,
				WeekDayPrice = 227.6m,
				CleaningFee = 20.22m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 5,
				GuestsAllowed = 2,
			};
			p80.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p80.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p80);

			Property p81 = new Property()
			{
				Zip = 29996,
				State = "MS",
				Street = "325 Amanda Cliffs Apt. 695",
				City = "South Paulabury",
				WeekendPrice = 135.59m,
				WeekDayPrice = 115.37m,
				CleaningFee = 29.8m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 6,
				Bathroom = 6,
				GuestsAllowed = 13,
			};
			p81.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p81.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p81);

			Property p82 = new Property()
			{
				Zip = 93980,
				State = "CT",
				Street = "40956 Amanda Walk Apt. 260",
				City = "Simonfurt",
				WeekendPrice = 271.49m,
				WeekDayPrice = 93.35m,
				CleaningFee = 8.54m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 4,
				Bathroom = 4,
				GuestsAllowed = 5,
			};
			p82.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p82.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p82);

			Property p83 = new Property()
			{
				Zip = 23687,
				State = "KS",
				Street = "25762 Gill Creek Suite 525",
				City = "Mccoyton",
				WeekendPrice = 247.15m,
				WeekDayPrice = 171.37m,
				CleaningFee = 17.22m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 5,
			};
			p83.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p83.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p83);

			Property p84 = new Property()
			{
				Zip = 04593,
				State = "GA",
				Street = "6048 Johnson Loop Suite 635",
				City = "East Daniel",
				WeekendPrice = 299.6m,
				WeekDayPrice = 95.59m,
				CleaningFee = 24.3m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 8,
			};
			p84.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p84.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p84);

			Property p85 = new Property()
			{
				Zip = 96954,
				State = "RI",
				Street = "1168 Gary Fords Apt. 308",
				City = "Port Trevor",
				WeekendPrice = 278.17m,
				WeekDayPrice = 194.84m,
				CleaningFee = 5.88m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 11,
			};
			p85.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p85.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p85);

			Property p86 = new Property()
			{
				Zip = 62271,
				State = "MS",
				Street = "164 Matthew Parkway Suite 826",
				City = "Jimmyfurt",
				WeekendPrice = 100.08m,
				WeekDayPrice = 112.03m,
				CleaningFee = 28.82m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 6,
				Bathroom = 8,
				GuestsAllowed = 8,
			};
			p86.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p86.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p86);

			Property p87 = new Property()
			{
				Zip = 05222,
				State = "CO",
				Street = "1220 Heidi Rue Apt. 998",
				City = "West Haleyburgh",
				WeekendPrice = 182.77m,
				WeekDayPrice = 127.97m,
				CleaningFee = 13.02m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 4,
				GuestsAllowed = 1,
			};
			p87.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p87.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p87);

			Property p88 = new Property()
			{
				Zip = 22365,
				State = "SD",
				Street = "751 Wood Square Suite 732",
				City = "Port Melissaburgh",
				WeekendPrice = 186.01m,
				WeekDayPrice = 120.07m,
				CleaningFee = 26.71m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 7,
				GuestsAllowed = 13,
			};
			p88.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p88.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p88);

			Property p89 = new Property()
			{
				Zip = 53609,
				State = "OR",
				Street = "376 Smith Dale Suite 279",
				City = "South Sarahland",
				WeekendPrice = 122.31m,
				WeekDayPrice = 137.96m,
				CleaningFee = 26.29m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 2,
				Bathroom = 2,
				GuestsAllowed = 9,
			};
			p89.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p89.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p89);

			Property p90 = new Property()
			{
				Zip = 09478,
				State = "CA",
				Street = "79148 Pierce Lock Suite 423",
				City = "Erikberg",
				WeekendPrice = 234.61m,
				WeekDayPrice = 226.57m,
				CleaningFee = 16.41m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 5,
				GuestsAllowed = 6,
			};
			p90.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p90.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p90);

			Property p91 = new Property()
			{
				Zip = 01425,
				State = "ID",
				Street = "147 Lisa Hill Apt. 512",
				City = "Port Elizabethshire",
				WeekendPrice = 145.15m,
				WeekDayPrice = 95.73m,
				CleaningFee = 9.93m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 6,
				GuestsAllowed = 10,
			};
			p91.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p91.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p91);

			Property p92 = new Property()
			{
				Zip = 29941,
				State = "KY",
				Street = "971 Hansen Well Suite 103",
				City = "South Mary",
				WeekendPrice = 145.72m,
				WeekDayPrice = 161.68m,
				CleaningFee = 24.36m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 8,
				GuestsAllowed = 4,
			};
			p92.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p92.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p92);

			Property p93 = new Property()
			{
				Zip = 47577,
				State = "WY",
				Street = "511 Berry Fork Suite 623",
				City = "Sharonfort",
				WeekendPrice = 260.18m,
				WeekDayPrice = 183.81m,
				CleaningFee = 7.46m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 4,
				Bathroom = 5,
				GuestsAllowed = 3,
			};
			p93.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p93.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p93);

			Property p94 = new Property()
			{
				Zip = 94134,
				State = "WI",
				Street = "65873 Chen Knolls",
				City = "Ramirezfurt",
				WeekendPrice = 117.17m,
				WeekDayPrice = 215.38m,
				CleaningFee = 24.31m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 4,
				Bathroom = 3,
				GuestsAllowed = 14,
			};
			p94.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p94.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p94);

			Property p95 = new Property()
			{
				Zip = 57039,
				State = "IN",
				Street = "8799 Emma Parkway Suite 735",
				City = "North Thomasfurt",
				WeekendPrice = 242.21m,
				WeekDayPrice = 145.51m,
				CleaningFee = 11.89m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 5,
				GuestsAllowed = 11,
			};
			p95.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p95.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p95);

			Property p96 = new Property()
			{
				Zip = 23718,
				State = "ND",
				Street = "30068 David View Apt. 173",
				City = "New Peggychester",
				WeekendPrice = 161.21m,
				WeekDayPrice = 142.76m,
				CleaningFee = 20.92m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 6,
				GuestsAllowed = 7,
			};
			p96.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p96.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p96);

			Property p97 = new Property()
			{
				Zip = 26932,
				State = "MD",
				Street = "298 Johnathan Cove Apt. 402",
				City = "South Jamie",
				WeekendPrice = 176.37m,
				WeekDayPrice = 170.07m,
				CleaningFee = 8.54m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 6,
				Bathroom = 7,
				GuestsAllowed = 13,
			};
			p97.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p97.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p97);

			Property p98 = new Property()
			{
				Zip = 74554,
				State = "CO",
				Street = "171 Harrison Motorway",
				City = "Davidview",
				WeekendPrice = 234.81m,
				WeekDayPrice = 145.08m,
				CleaningFee = 26.14m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 6,
				Bathroom = 8,
				GuestsAllowed = 10,
			};
			p98.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p98.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p98);

			Property p99 = new Property()
			{
				Zip = 32097,
				State = "NE",
				Street = "3576 Sergio Avenue",
				City = "Benjaminmouth",
				WeekendPrice = 260.62m,
				WeekDayPrice = 111.73m,
				CleaningFee = 15.89m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 1,
				GuestsAllowed = 1,
			};
			p99.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p99.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p99);

			Property p100 = new Property()
			{
				Zip = 21519,
				State = "RI",
				Street = "37457 Tanya Pike Apt. 348",
				City = "North Ericton",
				WeekendPrice = 214.62m,
				WeekDayPrice = 70.63m,
				CleaningFee = 5.29m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 2,
				Bathroom = 1,
				GuestsAllowed = 13,
			};
			p100.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p100.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p100);

			Property p101 = new Property()
			{
				Zip = 76875,
				State = "PA",
				Street = "3673 Peter Turnpike Suite 835",
				City = "New Sandra",
				WeekendPrice = 172.79m,
				WeekDayPrice = 229.03m,
				CleaningFee = 14.05m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 4,
				GuestsAllowed = 6,
			};
			p101.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p101.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p101);

			Property p102 = new Property()
			{
				Zip = 80451,
				State = "TX",
				Street = "939 Johnson Oval Suite 830",
				City = "North Dennismouth",
				WeekendPrice = 133.53m,
				WeekDayPrice = 169.34m,
				CleaningFee = 18.06m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 5,
				GuestsAllowed = 6,
			};
			p102.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p102.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p102);

			Property p103 = new Property()
			{
				Zip = 51726,
				State = "NV",
				Street = "645 Jennings Estates",
				City = "Angelastad",
				WeekendPrice = 109.44m,
				WeekDayPrice = 155.52m,
				CleaningFee = 8.28m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 2,
				Bathroom = 3,
				GuestsAllowed = 4,
			};
			p103.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p103.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p103);

			Property p104 = new Property()
			{
				Zip = 77240,
				State = "MT",
				Street = "1231 Stephanie Lock Suite 835",
				City = "North Richardland",
				WeekendPrice = 182.33m,
				WeekDayPrice = 180.2m,
				CleaningFee = 17.78m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 5,
			};
			p104.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p104.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p104);

			Property p105 = new Property()
			{
				Zip = 98152,
				State = "CO",
				Street = "302 Parker Plains Apt. 197",
				City = "East Robertstad",
				WeekendPrice = 212.7m,
				WeekDayPrice = 212.86m,
				CleaningFee = 6.82m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 2,
				GuestsAllowed = 1,
			};
			p105.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p105.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p105);

			Property p106 = new Property()
			{
				Zip = 98277,
				State = "MS",
				Street = "098 Hernandez Green",
				City = "New Sergiobury",
				WeekendPrice = 262.3m,
				WeekDayPrice = 188.71m,
				CleaningFee = 21.88m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 6,
				GuestsAllowed = 8,
			};
			p106.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p106.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p106);

			Property p107 = new Property()
			{
				Zip = 80082,
				State = "NE",
				Street = "94102 Sims Port Suite 187",
				City = "Florestown",
				WeekendPrice = 128.05m,
				WeekDayPrice = 83.34m,
				CleaningFee = 11.29m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 4,
				GuestsAllowed = 8,
			};
			p107.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p107.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p107);

			Property p108 = new Property()
			{
				Zip = 71531,
				State = "ND",
				Street = "01630 Baker Crescent",
				City = "Kellyborough",
				WeekendPrice = 125.27m,
				WeekDayPrice = 204.02m,
				CleaningFee = 21.15m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 1,
				GuestsAllowed = 4,
			};
			p108.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p108.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p108);

			Property p109 = new Property()
			{
				Zip = 14157,
				State = "OK",
				Street = "70452 Forbes Courts",
				City = "Mosesland",
				WeekendPrice = 172.1m,
				WeekDayPrice = 90.98m,
				CleaningFee = 18.09m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 4,
				Bathroom = 3,
				GuestsAllowed = 9,
			};
			p109.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p109.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p109);

			Property p110 = new Property()
			{
				Zip = 26899,
				State = "MO",
				Street = "0835 Angela Station",
				City = "East Heather",
				WeekendPrice = 299.91m,
				WeekDayPrice = 158.64m,
				CleaningFee = 23.09m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 9,
			};
			p110.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p110.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p110);

			Property p111 = new Property()
			{
				Zip = 42872,
				State = "VT",
				Street = "2458 Jason Village Suite 248",
				City = "North Donnamouth",
				WeekendPrice = 189.3m,
				WeekDayPrice = 107.97m,
				CleaningFee = 9.05m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 2,
				Bathroom = 4,
				GuestsAllowed = 4,
			};
			p111.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p111.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p111);

			Property p112 = new Property()
			{
				Zip = 78301,
				State = "CO",
				Street = "1243 Grimes Corners",
				City = "Shawchester",
				WeekendPrice = 193.24m,
				WeekDayPrice = 214.14m,
				CleaningFee = 26.1m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 3,
				GuestsAllowed = 2,
			};
			p112.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p112.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p112);

			Property p113 = new Property()
			{
				Zip = 34523,
				State = "DC",
				Street = "558 Williams Station",
				City = "Port Pamela",
				WeekendPrice = 192.46m,
				WeekDayPrice = 106.3m,
				CleaningFee = 17.59m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 6,
				Bathroom = 7,
				GuestsAllowed = 4,
			};
			p113.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p113.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p113);

			Property p114 = new Property()
			{
				Zip = 63064,
				State = "VT",
				Street = "4934 Lozano Place Suite 716",
				City = "Gavinton",
				WeekendPrice = 257.37m,
				WeekDayPrice = 116.99m,
				CleaningFee = 5.63m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 5,
				Bathroom = 6,
				GuestsAllowed = 6,
			};
			p114.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p114.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p114);

			Property p115 = new Property()
			{
				Zip = 35700,
				State = "LA",
				Street = "41227 Patricia Lake",
				City = "Martinezbury",
				WeekendPrice = 108.28m,
				WeekDayPrice = 203.03m,
				CleaningFee = 11.35m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 2,
				Bathroom = 1,
				GuestsAllowed = 3,
			};
			p115.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p115.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p115);

			Property p116 = new Property()
			{
				Zip = 55206,
				State = "VA",
				Street = "028 Harris Drive Apt. 422",
				City = "Amyburgh",
				WeekendPrice = 262.77m,
				WeekDayPrice = 163.3m,
				CleaningFee = 13.74m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 2,
				Bathroom = 2,
				GuestsAllowed = 14,
			};
			p116.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p116.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p116);

			Property p117 = new Property()
			{
				Zip = 98240,
				State = "IA",
				Street = "06268 Lewis Place Suite 121",
				City = "Port Patriciatown",
				WeekendPrice = 108.52m,
				WeekDayPrice = 156.25m,
				CleaningFee = 23.66m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 2,
				GuestsAllowed = 4,
			};
			p117.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p117.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p117);

			Property p118 = new Property()
			{
				Zip = 87205,
				State = "WI",
				Street = "5641 Brenda Streets Apt. 008",
				City = "Lake Seanmouth",
				WeekendPrice = 153.42m,
				WeekDayPrice = 178.27m,
				CleaningFee = 24.69m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 5,
				Bathroom = 6,
				GuestsAllowed = 12,
			};
			p118.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p118.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p118);

			Property p119 = new Property()
			{
				Zip = 58221,
				State = "ME",
				Street = "92555 Shaw Spurs Suite 207",
				City = "New Randy",
				WeekendPrice = 184.92m,
				WeekDayPrice = 92.51m,
				CleaningFee = 12.82m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 8,
				GuestsAllowed = 13,
			};
			p119.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p119.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p119);

			Property p120 = new Property()
			{
				Zip = 18885,
				State = "NY",
				Street = "559 Foster Locks Suite 933",
				City = "Robinsonhaven",
				WeekendPrice = 225.85m,
				WeekDayPrice = 224.62m,
				CleaningFee = 17.9m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 6,
				GuestsAllowed = 6,
			};
			p120.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p120.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p120);

			Property p121 = new Property()
			{
				Zip = 00638,
				State = "WY",
				Street = "4647 Kristine Fields Suite 710",
				City = "New Dakota",
				WeekendPrice = 174.02m,
				WeekDayPrice = 112.61m,
				CleaningFee = 17.48m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 10,
			};
			p121.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p121.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p121);

			Property p122 = new Property()
			{
				Zip = 31451,
				State = "ME",
				Street = "92594 Emily Shoals",
				City = "North Cathyburgh",
				WeekendPrice = 119.06m,
				WeekDayPrice = 189.98m,
				CleaningFee = 25.11m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 5,
				GuestsAllowed = 1,
			};
			p122.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p122.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p122);

			Property p123 = new Property()
			{
				Zip = 26297,
				State = "MS",
				Street = "551 Casey Squares Apt. 209",
				City = "Michaelborough",
				WeekendPrice = 114.73m,
				WeekDayPrice = 72.03m,
				CleaningFee = 18.38m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 1,
				GuestsAllowed = 6,
			};
			p123.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p123.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p123);

			Property p124 = new Property()
			{
				Zip = 04610,
				State = "PA",
				Street = "2998 Willis Wall",
				City = "North Brian",
				WeekendPrice = 144.51m,
				WeekDayPrice = 216.21m,
				CleaningFee = 10.81m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 4,
				GuestsAllowed = 3,
			};
			p124.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p124.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p124);

			Property p125 = new Property()
			{
				Zip = 86618,
				State = "MD",
				Street = "164 Schultz Road",
				City = "Lake Bryan",
				WeekendPrice = 233.9m,
				WeekDayPrice = 132.69m,
				CleaningFee = 15.8m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 13,
			};
			p125.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p125.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p125);

			Property p126 = new Property()
			{
				Zip = 80124,
				State = "GA",
				Street = "9541 Brock Estate Apt. 848",
				City = "Franklinchester",
				WeekendPrice = 285.05m,
				WeekDayPrice = 220.97m,
				CleaningFee = 20.98m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 2,
				Bathroom = 1,
				GuestsAllowed = 9,
			};
			p126.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p126.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p126);

			Property p127 = new Property()
			{
				Zip = 63590,
				State = "MS",
				Street = "588 Alan Rest",
				City = "Port Stephanieville",
				WeekendPrice = 180.86m,
				WeekDayPrice = 224.98m,
				CleaningFee = 11.91m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 6,
				Bathroom = 6,
				GuestsAllowed = 12,
			};
			p127.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p127.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p127);

			Property p128 = new Property()
			{
				Zip = 53548,
				State = "MT",
				Street = "216 Brandon Loop Apt. 096",
				City = "New Jessica",
				WeekendPrice = 239.97m,
				WeekDayPrice = 221.98m,
				CleaningFee = 9.24m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 12,
			};
			p128.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p128.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p128);

			Property p129 = new Property()
			{
				Zip = 35611,
				State = "LA",
				Street = "782 Dawn Radial",
				City = "Port Christopher",
				WeekendPrice = 297.25m,
				WeekDayPrice = 76.56m,
				CleaningFee = 20.42m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 1,
			};
			p129.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p129.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p129);

			Property p130 = new Property()
			{
				Zip = 42879,
				State = "WA",
				Street = "008 Nancy Route Suite 228",
				City = "North Stephanie",
				WeekendPrice = 129.36m,
				WeekDayPrice = 128.71m,
				CleaningFee = 23.76m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 2,
				Bathroom = 3,
				GuestsAllowed = 3,
			};
			p130.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p130.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p130);

			Property p131 = new Property()
			{
				Zip = 71569,
				State = "MO",
				Street = "115 Jon Isle Suite 788",
				City = "North Lesliefurt",
				WeekendPrice = 210.63m,
				WeekDayPrice = 114.21m,
				CleaningFee = 21.08m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 9,
			};
			p131.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p131.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p131);

			Property p132 = new Property()
			{
				Zip = 87566,
				State = "DE",
				Street = "132 Poole Pass Suite 212",
				City = "North Patrick",
				WeekendPrice = 280.37m,
				WeekDayPrice = 146.82m,
				CleaningFee = 26.78m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 6,
				GuestsAllowed = 11,
			};
			p132.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p132.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p132);

			Property p133 = new Property()
			{
				Zip = 67652,
				State = "WY",
				Street = "457 Vargas Island Suite 853",
				City = "Lake Patrickstad",
				WeekendPrice = 249.39m,
				WeekDayPrice = 134.72m,
				CleaningFee = 19.19m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 4,
				Bathroom = 3,
				GuestsAllowed = 1,
			};
			p133.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p133.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p133);

			Property p134 = new Property()
			{
				Zip = 45184,
				State = "HI",
				Street = "1569 Amy Path",
				City = "North Ashleyton",
				WeekendPrice = 111.23m,
				WeekDayPrice = 111.6m,
				CleaningFee = 13.48m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 8,
				GuestsAllowed = 7,
			};
			p134.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p134.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p134);

			Property p135 = new Property()
			{
				Zip = 04078,
				State = "IL",
				Street = "0375 Sandra Trace Suite 826",
				City = "Gailshire",
				WeekendPrice = 168.47m,
				WeekDayPrice = 89m,
				CleaningFee = 14.93m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 5,
				Bathroom = 6,
				GuestsAllowed = 3,
			};
			p135.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p135.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p135);

			Property p136 = new Property()
			{
				Zip = 50437,
				State = "MN",
				Street = "759 Good Port",
				City = "New Russell",
				WeekendPrice = 208.35m,
				WeekDayPrice = 208.64m,
				CleaningFee = 7.09m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 5,
				GuestsAllowed = 6,
			};
			p136.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p136.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p136);

			Property p137 = new Property()
			{
				Zip = 34147,
				State = "WV",
				Street = "3895 Allen Junction",
				City = "West John",
				WeekendPrice = 195.41m,
				WeekDayPrice = 172.51m,
				CleaningFee = 21.53m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 3,
			};
			p137.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p137.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p137);

			Property p138 = new Property()
			{
				Zip = 36340,
				State = "MS",
				Street = "7329 Jacobs Station",
				City = "New Tylerborough",
				WeekendPrice = 146.12m,
				WeekDayPrice = 163.15m,
				CleaningFee = 18.98m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 8,
			};
			p138.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p138.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p138);

			Property p139 = new Property()
			{
				Zip = 88806,
				State = "MD",
				Street = "5003 Cassandra Estates Suite 148",
				City = "Haleychester",
				WeekendPrice = 161.49m,
				WeekDayPrice = 81.5m,
				CleaningFee = 16.41m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 7,
				GuestsAllowed = 9,
			};
			p139.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p139.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p139);

			Property p140 = new Property()
			{
				Zip = 76853,
				State = "TN",
				Street = "10524 Parker Mall Suite 531",
				City = "Port Courtneyhaven",
				WeekendPrice = 120.73m,
				WeekDayPrice = 177.94m,
				CleaningFee = 9.5m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 7,
				GuestsAllowed = 13,
			};
			p140.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			p140.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p140);

			Property p141 = new Property()
			{
				Zip = 93533,
				State = "MO",
				Street = "300 Madison Stream",
				City = "Christophershire",
				WeekendPrice = 187.08m,
				WeekDayPrice = 121.01m,
				CleaningFee = 16.48m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 4,
				GuestsAllowed = 6,
			};
			p141.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p141.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p141);

			Property p142 = new Property()
			{
				Zip = 96763,
				State = "FL",
				Street = "4229 Derrick Wells",
				City = "West Tyler",
				WeekendPrice = 241.45m,
				WeekDayPrice = 199.68m,
				CleaningFee = 25.94m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 2,
				Bathroom = 4,
				GuestsAllowed = 6,
			};
			p142.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p142.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p142);

			Property p143 = new Property()
			{
				Zip = 92174,
				State = "VA",
				Street = "26239 Michael Shoals",
				City = "Gregoryview",
				WeekendPrice = 111.91m,
				WeekDayPrice = 162.01m,
				CleaningFee = 14.35m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 9,
			};
			p143.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p143.User = db.Users.FirstOrDefault(c => c.Email == "morales@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p143);

			Property p144 = new Property()
			{
				Zip = 88294,
				State = "IN",
				Street = "302 Joy Spring Apt. 622",
				City = "Ryanhaven",
				WeekendPrice = 163.73m,
				WeekDayPrice = 173.36m,
				CleaningFee = 25.35m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 12,
			};
			p144.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p144.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p144);

			Property p145 = new Property()
			{
				Zip = 23464,
				State = "CA",
				Street = "734 Craig Overpass Suite 589",
				City = "Jefferyside",
				WeekendPrice = 287.28m,
				WeekDayPrice = 216.1m,
				CleaningFee = 22.2m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 8,
			};
			p145.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p145.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p145);

			Property p146 = new Property()
			{
				Zip = 35243,
				State = "CA",
				Street = "272 Green Street",
				City = "Port Lacey",
				WeekendPrice = 247.34m,
				WeekDayPrice = 211.51m,
				CleaningFee = 11.73m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 4,
				Bathroom = 3,
				GuestsAllowed = 7,
			};
			p146.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p146.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p146);

			Property p147 = new Property()
			{
				Zip = 61935,
				State = "IL",
				Street = "8056 Dunn Trail Apt. 049",
				City = "Blackshire",
				WeekendPrice = 189.08m,
				WeekDayPrice = 111.4m,
				CleaningFee = 19.58m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 6,
				GuestsAllowed = 2,
			};
			p147.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p147.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p147);

			Property p148 = new Property()
			{
				Zip = 72324,
				State = "CA",
				Street = "86187 Antonio Fort",
				City = "North Carmen",
				WeekendPrice = 109.87m,
				WeekDayPrice = 150.69m,
				CleaningFee = 13.3m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 9,
				GuestsAllowed = 7,
			};
			p148.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p148.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p148);

			Property p149 = new Property()
			{
				Zip = 84393,
				State = "NJ",
				Street = "71318 Cassandra Plaza",
				City = "Burkeview",
				WeekendPrice = 227.55m,
				WeekDayPrice = 184.21m,
				CleaningFee = 19.52m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 7,
				GuestsAllowed = 10,
			};
			p149.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p149.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p149);

			Property p150 = new Property()
			{
				Zip = 62346,
				State = "NH",
				Street = "5303 Lewis Springs",
				City = "Port Adrian",
				WeekendPrice = 207.51m,
				WeekDayPrice = 204.67m,
				CleaningFee = 26.36m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 2,
				Bathroom = 1,
				GuestsAllowed = 2,
			};
			p150.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p150.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p150);

			Property p151 = new Property()
			{
				Zip = 02837,
				State = "IA",
				Street = "465 Wiley Corners Apt. 759",
				City = "East Michellechester",
				WeekendPrice = 213.84m,
				WeekDayPrice = 129.14m,
				CleaningFee = 12.81m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 5,
				GuestsAllowed = 11,
			};
			p151.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p151.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p151);

			Property p152 = new Property()
			{
				Zip = 68847,
				State = "LA",
				Street = "521 Flores Stream",
				City = "West Rebeccaborough",
				WeekendPrice = 254.37m,
				WeekDayPrice = 77.06m,
				CleaningFee = 6.03m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 5,
				GuestsAllowed = 3,
			};
			p152.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p152.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p152);

			Property p153 = new Property()
			{
				Zip = 35218,
				State = "NE",
				Street = "0271 Soto Drives Apt. 975",
				City = "New Edgar",
				WeekendPrice = 233.17m,
				WeekDayPrice = 179.91m,
				CleaningFee = 11.04m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 5,
				GuestsAllowed = 9,
			};
			p153.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p153.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p153);

			Property p154 = new Property()
			{
				Zip = 32697,
				State = "NM",
				Street = "27862 Kent Mountains",
				City = "Lake Michaelville",
				WeekendPrice = 153.38m,
				WeekDayPrice = 90.54m,
				CleaningFee = 6.91m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 5,
				GuestsAllowed = 14,
			};
			p154.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p154.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p154);

			Property p155 = new Property()
			{
				Zip = 95889,
				State = "OR",
				Street = "917 Mclaughlin Glens",
				City = "Martinville",
				WeekendPrice = 226.89m,
				WeekDayPrice = 225.59m,
				CleaningFee = 28.99m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 6,
				GuestsAllowed = 2,
			};
			p155.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p155.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p155);

			Property p156 = new Property()
			{
				Zip = 82153,
				State = "KY",
				Street = "3032 Michelle Drives",
				City = "North Daniel",
				WeekendPrice = 157.15m,
				WeekDayPrice = 203.25m,
				CleaningFee = 15.68m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 3,
				Bathroom = 4,
				GuestsAllowed = 13,
			};
			p156.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p156.User = db.Users.FirstOrDefault(c => c.Email == "rankin@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p156);

			Property p157 = new Property()
			{
				Zip = 32202,
				State = "SD",
				Street = "601 Maria Mission Apt. 554",
				City = "Myerstown",
				WeekendPrice = 269.55m,
				WeekDayPrice = 223.27m,
				CleaningFee = 11.35m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 9,
				GuestsAllowed = 9,
			};
			p157.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p157.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p157);

			Property p158 = new Property()
			{
				Zip = 17431,
				State = "OH",
				Street = "238 Shawn Well",
				City = "Port Johnshire",
				WeekendPrice = 112.64m,
				WeekDayPrice = 173.63m,
				CleaningFee = 6.38m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 8,
				GuestsAllowed = 14,
			};
			p158.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p158.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p158);

			Property p159 = new Property()
			{
				Zip = 37901,
				State = "SC",
				Street = "41743 Berger Inlet Apt. 527",
				City = "South Tammymouth",
				WeekendPrice = 163.2m,
				WeekDayPrice = 176.23m,
				CleaningFee = 14.77m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 9,
				GuestsAllowed = 9,
			};
			p159.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p159.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p159);

			Property p160 = new Property()
			{
				Zip = 17895,
				State = "MO",
				Street = "9983 Mary Grove Apt. 643",
				City = "Beardview",
				WeekendPrice = 209.33m,
				WeekDayPrice = 219.53m,
				CleaningFee = 24.51m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 6,
				GuestsAllowed = 9,
			};
			p160.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p160.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p160);

			Property p161 = new Property()
			{
				Zip = 90576,
				State = "HI",
				Street = "03541 Ryan Islands Apt. 562",
				City = "East Michaelfort",
				WeekendPrice = 269.63m,
				WeekDayPrice = 126.25m,
				CleaningFee = 8.27m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 10,
			};
			p161.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p161.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p161);

			Property p162 = new Property()
			{
				Zip = 94980,
				State = "SC",
				Street = "6591 Angela Mission Apt. 108",
				City = "Penabury",
				WeekendPrice = 286.86m,
				WeekDayPrice = 143.98m,
				CleaningFee = 20.48m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 5,
				Bathroom = 6,
				GuestsAllowed = 14,
			};
			p162.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p162.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p162);

			Property p163 = new Property()
			{
				Zip = 44974,
				State = "CO",
				Street = "492 Ramirez Crossing",
				City = "Aaronberg",
				WeekendPrice = 144.6m,
				WeekDayPrice = 121.91m,
				CleaningFee = 10.12m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 10,
			};
			p163.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p163.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p163);

			Property p164 = new Property()
			{
				Zip = 66170,
				State = "DE",
				Street = "35974 Sharon Locks Apt. 101",
				City = "Jennyport",
				WeekendPrice = 114.46m,
				WeekDayPrice = 137.8m,
				CleaningFee = 17.74m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 9,
				GuestsAllowed = 1,
			};
			p164.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p164.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p164);

			Property p165 = new Property()
			{
				Zip = 22495,
				State = "UT",
				Street = "89403 Gabriella Mills",
				City = "East Steven",
				WeekendPrice = 155.1m,
				WeekDayPrice = 128.63m,
				CleaningFee = 23.05m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 4,
				GuestsAllowed = 11,
			};
			p165.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p165.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p165);

			Property p166 = new Property()
			{
				Zip = 85059,
				State = "NH",
				Street = "601 Kyle Roads",
				City = "Clarkfurt",
				WeekendPrice = 284.39m,
				WeekDayPrice = 209.11m,
				CleaningFee = 6.25m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 4,
				Bathroom = 5,
				GuestsAllowed = 4,
			};
			p166.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p166.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p166);

			Property p167 = new Property()
			{
				Zip = 61092,
				State = "IN",
				Street = "60969 Justin Passage Suite 774",
				City = "Joshuaburgh",
				WeekendPrice = 121m,
				WeekDayPrice = 128.59m,
				CleaningFee = 19.36m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 1,
				GuestsAllowed = 7,
			};
			p167.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p167.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p167);

			Property p168 = new Property()
			{
				Zip = 43986,
				State = "PA",
				Street = "7943 Tina Mount",
				City = "East Lisa",
				WeekendPrice = 104.47m,
				WeekDayPrice = 122.88m,
				CleaningFee = 25.31m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 4,
				Bathroom = 3,
				GuestsAllowed = 14,
			};
			p168.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p168.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p168);

			Property p169 = new Property()
			{
				Zip = 91397,
				State = "NC",
				Street = "6775 James Ford",
				City = "South Victorialand",
				WeekendPrice = 275.5m,
				WeekDayPrice = 211.24m,
				CleaningFee = 15.74m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 3,
				GuestsAllowed = 9,
			};
			p169.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p169.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p169);

			Property p170 = new Property()
			{
				Zip = 67849,
				State = "VT",
				Street = "431 Johnson Neck Suite 039",
				City = "Mariechester",
				WeekendPrice = 126.24m,
				WeekDayPrice = 124.65m,
				CleaningFee = 24.3m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 1,
				GuestsAllowed = 9,
			};
			p170.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p170.User = db.Users.FirstOrDefault(c => c.Email == "rice@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p170);

			Property p171 = new Property()
			{
				Zip = 20687,
				State = "NM",
				Street = "15666 Justin Locks",
				City = "Lake Ryanport",
				WeekendPrice = 112.05m,
				WeekDayPrice = 70.11m,
				CleaningFee = 27.45m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 6,
				GuestsAllowed = 3,
			};
			p171.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p171.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p171);

			Property p172 = new Property()
			{
				Zip = 30222,
				State = "TX",
				Street = "9947 Torres Viaduct Apt. 506",
				City = "Benjaminport",
				WeekendPrice = 152.09m,
				WeekDayPrice = 174.87m,
				CleaningFee = 18.44m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 11,
			};
			p172.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			p172.User = db.Users.FirstOrDefault(c => c.Email == "ingram@gmail.com");
			//Add this property to the list of properties to add
			Properties.Add(p172);

			Property p173 = new Property()
			{
				Zip = 21190,
				State = "NJ",
				Street = "20866 Keith Mill",
				City = "Susanton",
				WeekendPrice = 174.06m,
				WeekDayPrice = 96.8m,
				CleaningFee = 28.15m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 2,
				Bathroom = 4,
				GuestsAllowed = 10,
			};
			p173.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p173.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p173);

			Property p174 = new Property()
			{
				Zip = 04838,
				State = "AL",
				Street = "04374 Nicholas Cliff Suite 001",
				City = "Adrianport",
				WeekendPrice = 108.24m,
				WeekDayPrice = 205.01m,
				CleaningFee = 6.56m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 1,
				Bathroom = 1,
				GuestsAllowed = 10,
			};
			p174.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			p174.User = db.Users.FirstOrDefault(c => c.Email == "jacobs@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p174);

			Property p175 = new Property()
			{
				Zip = 80130,
				State = "CA",
				Street = "271 Andrew Summit",
				City = "Port Craig",
				WeekendPrice = 148.39m,
				WeekDayPrice = 197.52m,
				CleaningFee = 20.55m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 6,
				GuestsAllowed = 7,
			};
			p175.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p175.User = db.Users.FirstOrDefault(c => c.Email == "gonzalez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p175);

			Property p176 = new Property()
			{
				Zip = 96166,
				State = "MN",
				Street = "17611 Robbins Mission",
				City = "New Curtis",
				WeekendPrice = 286.13m,
				WeekDayPrice = 219.69m,
				CleaningFee = 10.64m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 3,
				GuestsAllowed = 9,
			};
			p176.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p176.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p176);

			Property p177 = new Property()
			{
				Zip = 40702,
				State = "MO",
				Street = "80831 Kemp Pines",
				City = "Annashire",
				WeekendPrice = 123.93m,
				WeekDayPrice = 91.26m,
				CleaningFee = 19.36m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 1,
				Bathroom = 2,
				GuestsAllowed = 7,
			};
			p177.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p177.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p177);

			Property p178 = new Property()
			{
				Zip = 86023,
				State = "IL",
				Street = "96545 Smith Alley",
				City = "West Joy",
				WeekendPrice = 254.38m,
				WeekDayPrice = 132.54m,
				CleaningFee = 14.83m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 6,
				Bathroom = 8,
				GuestsAllowed = 7,
			};
			p178.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p178.User = db.Users.FirstOrDefault(c => c.Email == "martinez@aol.com");
			//Add this property to the list of properties to add
			Properties.Add(p178);

			Property p179 = new Property()
			{
				Zip = 70897,
				State = "MT",
				Street = "6146 Johnson Isle",
				City = "South Arthur",
				WeekendPrice = 228.04m,
				WeekDayPrice = 227.96m,
				CleaningFee = 6.99m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 2,
				Bathroom = 4,
				GuestsAllowed = 1,
			};
			p179.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p179.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p179);

			Property p180 = new Property()
			{
				Zip = 69154,
				State = "MN",
				Street = "0415 Smith Springs",
				City = "Jeremyburgh",
				WeekendPrice = 228.81m,
				WeekDayPrice = 140.93m,
				CleaningFee = 29.74m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 4,
				Bathroom = 4,
				GuestsAllowed = 3,
			};
			p180.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p180.User = db.Users.FirstOrDefault(c => c.Email == "loter@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p180);

			Property p181 = new Property()
			{
				Zip = 53524,
				State = "HI",
				Street = "3999 Ricky Via",
				City = "West Adamburgh",
				WeekendPrice = 255.43m,
				WeekDayPrice = 137.35m,
				CleaningFee = 16.62m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.Yes,
				Bedroom = 7,
				Bathroom = 6,
				GuestsAllowed = 6,
			};
			p181.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			p181.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p181);

			Property p182 = new Property()
			{
				Zip = 24886,
				State = "MN",
				Street = "83787 Stuart Key",
				City = "Davetown",
				WeekendPrice = 146.75m,
				WeekDayPrice = 172.99m,
				CleaningFee = 26.24m,
				PetsAllowed = petsAllowed.Yes,
				ParkingFee = parkingfee.No,
				Bedroom = 7,
				Bathroom = 6,
				GuestsAllowed = 4,
			};
			p182.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p182.User = db.Users.FirstOrDefault(c => c.Email == "chung@yahoo.com");
			//Add this property to the list of properties to add
			Properties.Add(p182);

			Property p183 = new Property()
			{
				Zip = 56713,
				State = "TX",
				Street = "690 Christina Park",
				City = "Toddburgh",
				WeekendPrice = 157.96m,
				WeekDayPrice = 188.53m,
				CleaningFee = 6.69m,
				PetsAllowed = petsAllowed.No,
				ParkingFee = parkingfee.No,
				Bedroom = 3,
				Bathroom = 5,
				GuestsAllowed = 1,
			};
			p183.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			p183.User = db.Users.FirstOrDefault(c => c.Email == "tanner@utexas.edu");
			//Add this property to the list of properties to add
			Properties.Add(p183);




			try  //attempt to add or update the book
			{
				//loop through each of the books in the list
				foreach (Property propertyToAdd in Properties)
				{
					//set the flag to the current title to help with debugging
					strPropertyStreet = propertyToAdd.Street;
					 				//look to see if the book is in the database - this assumes that no
				//two properties have the same street
				Property dbProperty = db.Properties.FirstOrDefault(p => p.Street == propertyToAdd.Street);
					 				//if the dbBook is null, this title is not in the database
					 				if (dbProperty == null)
					 					{
						//add the book to the database and save changes
						db.Properties.Add(propertyToAdd);
						db.SaveChanges();
						 						//update the counter to help with debugging
						intPropertiesAdded += 1;
					}
					else //dbBook is not null - this title *is* in the database
					{
						//update all of the book's properties
						dbProperty.Zip = propertyToAdd.Zip;
						dbProperty.State = propertyToAdd.State;
						dbProperty.Street = propertyToAdd.Street;
						dbProperty.City = propertyToAdd.City;
						dbProperty.WeekendPrice = propertyToAdd.WeekendPrice;
						dbProperty.WeekDayPrice = propertyToAdd.WeekDayPrice;
						dbProperty.PetsAllowed = propertyToAdd.PetsAllowed;
						dbProperty.ParkingFee = propertyToAdd.ParkingFee;
						dbProperty.Bedroom = propertyToAdd.Bedroom;
						dbProperty.Bathroom = propertyToAdd.Bathroom;
						dbProperty.GuestsAllowed = propertyToAdd.GuestsAllowed;
						//since we found the correct category object in a previous step,
						//this update is easy - both dbBook and bookToAdd have a Categotry
						//object for this property
						dbProperty.Category = propertyToAdd.Category;
						dbProperty.User = propertyToAdd.User;
						//update the database and save the changes
						db.Update(dbProperty);
						db.SaveChanges();
						 						//update the counter to help with debugging
						 						intPropertiesAdded += 1;
					} //this is the end of the else
				} //this is the end of the foreach loop for the books
			}//this is the end of the try block
			 			catch (Exception ex)//something went wrong with adding or updating
			{
				//Build a messsage using the flags we created
				String msg = "Repositories added: "+ intPropertiesAdded + "; Error on "+ strPropertyStreet;
				 				//throw the exception with the new message
				throw new InvalidOperationException(ex.Message + msg);
			}
		}
	}
}
