using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

//TODO: Update these using statements to include your project name
using Group12_FinalProject.Models;
using Group12_FinalProject.Utilities;
using Group12_FinalProject.DAL;
using System.Threading.Tasks;

//TODO: Upddate this namespace to match your project name
namespace Group12_FinalProject.Seeding
{
    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();

            AllUsers.Add(new AddUserModel()
            { // Seeding Hosts from Excel Sheet first...
                // trying with one of the hosts first to test 11/28/21 6:50pm
                // now seeding admins 11/28/21 8pm
                //now seeding customers 11/28/21 8:05pm
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Christopher",
                    LastName = "Baker",
                    Email = "cbaker@freezing.co.uk",
                    UserName = "cbaker@freezing.co.uk",
                    ZipCode = 78733,
                    Birthday = new DateTime(1968, 11, 28),
                    StreetAddress = "1245 Lake America Blvd.",
                },
                // password and role are here
                Password = "hellothere",
                RoleName = "Customer",
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Michelle",
                    LastName = "Bradicus",
                    Email = "mb@puppy.com",
                    UserName = "mb@puppy.com",
                    ZipCode = 78261,
                    Birthday = new DateTime(1988, 2, 7),
                    StreetAddress = "1300 Small Pine Lane",
                },
                // password and role are here
                Password = "555533",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
            {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Franco",
                    LastName = "Broccoli",
                    Email = "fd@puppy.com",
                    UserName = "fd@puppy.com",
                    ZipCode = 77019,
                    Birthday = new DateTime(1999, 11, 7),
                    StreetAddress = "62 Cookie Rd",
                },
                // password and role are here
                Password = "666645",
                RoleName = "Customer",
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Wendy",
                    LastName = "Charile",
                    Email = "wendy@puppy.com",
                    UserName = "wendy@puppy.com",
                    ZipCode = 78713,
                    Birthday = new DateTime(1992, 10, 27),
                    StreetAddress = "202 Bellmoth Hall",
                },
                // password and role are here
                Password = "Kansas",
                RoleName = "Customer",
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Lim",
                    LastName = "Chou",
                    Email = "limchou@puppy.com",
                    UserName = "limchou@puppy.com",
                    ZipCode = 78266,
                    Birthday = new DateTime(1961, 11, 11),
                    StreetAddress = "1600 Barbara Lane",
                },
                // password and role are here
                Password = "Rockwall",
                RoleName = "Customer",
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Shan",
                    LastName = "Dave",
                    Email = "444444.Dave@aool.com",
                    UserName = "444444.Dave@aool.com",
                    ZipCode = 75208,
                    Birthday = new DateTime(1972, 12, 19),
                    StreetAddress = "234 Puppy Circle",
                },
                // password and role are here
                Password = "444444",
                RoleName = "Customer",
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    Email = "louann@puppy.com",
                    UserName = "louann@puppy.com",
                    ZipCode = 77010,
                    Birthday = new DateTime(1958, 8, 1),
                    StreetAddress = "700 S 9th Street W",
                },
                // password and role are here
                Password = "longhorns",
                RoleName = "Customer",
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    Email = "tfreeley@puppy.com",
                    UserName = "tfreeley@puppy.com",
                    ZipCode = 77009,
                    Birthday = new DateTime(2001, 7, 12),
                    StreetAddress = "4334 Meanview Ave.",
                },
                // password and role are here
                Password = "puppies",
                RoleName = "Customer",
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    Email = "mgar@puppy.com",
                    UserName = "mgar@puppy.com",
                    ZipCode = 77003,
                    Birthday = new DateTime(1956, 11, 17),
                    StreetAddress = "594 Puppyview",
                },
                // password and role are here
                Password = "horses",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Charles",
                    LastName = "Harley",
                    Email = "chaley@thug.com",
                    UserName = "chaley@thug.com",
                    ZipCode = 75261,
                    Birthday = new DateTime(1998, 5, 29),
                    StreetAddress = "One Ranger Pkwy",
                },
                // password and role are here
                Password = "mycats",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Jeffrey",
                    LastName = "Stark",
                    Email = "jeff@puppy.com",
                    UserName = "jeff@puppy.com",
                    ZipCode = 78705,
                    Birthday = new DateTime(1974, 5, 2),
                    StreetAddress = "337 40th St.",
                },
                // password and role are here
                Password = "jeffery",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
            {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "John",
                    LastName = "Hearn",
                    Email = "wjhearniii@umch.edu",
                    UserName = "wjhearniii@umch.edu",
                    ZipCode = 75237,
                    Birthday = new DateTime(1983, 12, 29),
                    StreetAddress = "4445 South First",
                },
                // password and role are here
                Password = "posicles",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Mark",
                    LastName = "Hicks",
                    Email = "hicks43@puppy.com",
                    UserName = "hicks43@puppy.com",
                    ZipCode = 78239,
                    Birthday = new DateTime(1989, 12, 16),
                    StreetAddress = "32 NE Mark Ln., Ste 910",
                },
                // password and role are here
                Password = "guac45",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Brad",
                    LastName = "Ingram",
                    Email = "bradsingram@mall.utexas.edu",
                    UserName = "bradsingram@mall.utexas.edu",
                    ZipCode = 78736,
                    Birthday = new DateTime(1958, 9, 18),
                    StreetAddress = "6548 La Chess St.",
                },
                // password and role are here
                Password = "father",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    Email = "father.Ingram@aool.com",
                    UserName = "father.Ingram@aool.com",
                    ZipCode = 78731,
                    Birthday = new DateTime(1975, 12, 9),
                    StreetAddress = "4564 Palm St.",
                },
                // password and role are here
                Password = "555897",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    Email = "victoria@puppy.com",
                    UserName = "victoria@puppy.com",
                    ZipCode = 78761,
                    Birthday = new DateTime(1981, 5, 29),
                    StreetAddress = "6639 Butterfly Ln.",
                },
                // password and role are here
                Password = "something",
                RoleName = "Customer",
            });
            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Brad",
                    LastName = "Lineback",
                    Email = "lineback@flush.net",
                    UserName = "lineback@flush.net",
                    ZipCode = 78293,
                    Birthday = new DateTime(1973, 5, 19),
                    StreetAddress = "1300 Pirateland St",
                },
                // password and role are here
                Password = "treelover",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Evan",
                    LastName = "Lowe",
                    Email = "elowe@netscrape.net",
                    UserName = "elowe@netscrape.net",
                    ZipCode = 78279,
                    Birthday = new DateTime(1993, 6, 7),
                    StreetAddress = "3201 Pineapple Drive",
                },
                // password and role are here
                Password = "headear",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Chuck",
                    LastName = "Luce",
                    Email = "luce_chuck@puppy.com",
                    UserName = "luce_chuck@puppy.com",
                    ZipCode = 78268,
                    Birthday = new DateTime(1995, 6, 11),
                    StreetAddress = "2345 Silent Clouds",
                },
                // password and role are here
                Password = "gooseyloosey",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Jennifer",
                    LastName = "MacLeod",
                    Email = "mackcloud@pimpdaddy.com",
                    UserName = "mackcloud@pimpdaddy.com",
                    ZipCode = 78731,
                    Birthday = new DateTime(1965, 10, 11),
                    StreetAddress = "2504 Far East Blvd.",
                },
                // password and role are here
                Password = "rainyday",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Elizabeth",
                    LastName = "Markham",
                    Email = "liz@puppy.com",
                    UserName = "liz@puppy.com",
                    ZipCode = 78732,
                    Birthday = new DateTime(1989, 6, 18),
                    StreetAddress = "7861 Chevy Mace Rd",
                },
                // password and role are here
                Password = "ember22",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Clarence",
                    LastName = "Martin",
                    Email = "mclarence@puppy.com",
                    UserName = "mclarence@puppy.com",
                    ZipCode = 77045,
                    Birthday = new DateTime(1984, 4, 28),
                    StreetAddress = "87 Alcedo St.",
                },
                // password and role are here
                Password = "lamemartin",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Gregory",
                    LastName = "Martinez",
                    Email = "lamemartin.Martin@aool.com",
                    UserName = "lamemartin.Martin@aool.com",
                    ZipCode = 77030,
                    Birthday = new DateTime(1981, 12, 27),
                    StreetAddress = "8295 Moon Blvd.",
                },
                // password and role are here
                Password = "gregory",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Charles",
                    LastName = "Miller",
                    Email = "cmiller@mapster.com",
                    UserName = "cmiller@mapster.com",
                    ZipCode = 77031,
                    Birthday = new DateTime(1987, 5, 5),
                    StreetAddress = "8962 Side St.",
                },
                // password and role are here
                Password = "mucky44",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Kelly",
                    LastName = "Nelson",
                    Email = "nelson.Kelly@puppy.com",
                    UserName = "nelson.Kelly@puppy.com",
                    ZipCode = 78703,
                    Birthday = new DateTime(1969, 8, 3),
                    StreetAddress = "2601 Green River",
                },
                // password and role are here
                Password = "Tree34",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Joe",
                    LastName = "Nguyen",
                    Email = "jojoe@puppy.com",
                    UserName = "jojoe@puppy.com",
                    ZipCode = 75238,
                    Birthday = new DateTime(1956, 2, 6),
                    StreetAddress = "1249 4th NW St.",
                },
                // password and role are here
                Password = "jvb485bg",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Bill",
                    LastName = "O'Reilly",
                    Email = "orielly@foxnets.com",
                    UserName = "orielly@foxnets.com",
                    ZipCode = 78260,
                    Birthday = new DateTime(1989, 3, 14),
                    StreetAddress = "8800 Gringo Drive",
                },
                // password and role are here
                Password = "Bobbygirl",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Anka",
                    LastName = "Radkovich",
                    Email = "or@puppy.com",
                    UserName = "or@puppy.com",
                    ZipCode = 75260,
                    Birthday = new DateTime(1952, 10, 26),
                    StreetAddress = "1300 Freaky",
                },
                // password and role are here
                Password = "radioactive",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Megan",
                    LastName = "Rhodes",
                    Email = "megrhodes@freezing.co.uk",
                    UserName = "megrhodes@freezing.co.uk",
                    ZipCode = 78707,
                    Birthday = new DateTime(1958, 3, 18),
                    StreetAddress = "4587 Rightfield Rd.",
                },
                // password and role are here
                Password = "gopigs",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Eryn",
                    LastName = "Rice",
                    Email = "erynrice@puppy.com",
                    UserName = "erynrice@puppy.com",
                    ZipCode = 78705,
                    Birthday = new DateTime(2000, 11, 2),
                    StreetAddress = "3405 Rio Small",
                },
                // password and role are here
                Password = "iloveme",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Jorge",
                    LastName = "Rodriguez",
                    Email = "jorge@hootmail.com",
                    UserName = "jorge@hootmail.com",
                    ZipCode = 77057,
                    Birthday = new DateTime(1979, 1, 1),
                    StreetAddress = "6788 Cotten Street",
                },
                // password and role are here
                Password = "565656",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Allen",
                    LastName = "Rogers",
                    Email = "ra@aoo.com",
                    UserName = "ra@aoo.com",
                    ZipCode = 78732,
                    Birthday = new DateTime(2000, 3, 12),
                    StreetAddress = "4965 Rabbit Hill",
                },
                // password and role are here
                Password = "treeman",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Olivier",
                    LastName = "Saint-Jean",
                    Email = "o_st-jean@home.com",
                    UserName = "o_st-jean@home.com",
                    ZipCode = 78292,
                    Birthday = new DateTime(1997, 5, 1),
                    StreetAddress = "255 Slap Dr.",
                },
                // password and role are here
                Password = "55htrq",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Sarah",
                    LastName = "Saunders",
                    Email = "ss34@puppy.com",
                    UserName = "ss34@puppy.com",
                    ZipCode = 78705,
                    Birthday = new DateTime(1994, 5, 31),
                    StreetAddress = "332 Fish C",
                },
                // password and role are here
                Password = "leaves",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "William",
                    LastName = "Sewell",
                    Email = "willsheff@email.com",
                    UserName = "willsheff@email.com",
                    ZipCode = 78709,
                    Birthday = new DateTime(1951, 12, 10),
                    StreetAddress = "2365 34st St.",
                },
                // password and role are here
                Password = "borbj44",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    Email = "sheff44@puppy.com",
                    UserName = "sheff44@puppy.com",
                    ZipCode = 78705,
                    Birthday = new DateTime(1993, 7, 2),
                    StreetAddress = "3886 Road A",
                },
                // password and role are here
                Password = "ldiul485",
                RoleName = "Customer",
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "John",
                    LastName = "Smith",
                    Email = "johnsmith187@puppy.com",
                    UserName = "johnsmith187@puppy.com",
                    ZipCode = 78280,
                    Birthday = new DateTime(1985, 6, 13),
                    StreetAddress = "23 Known Forge Dr.",
                },
                // password and role are here
                Password = "kribv75",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Dustin",
                    LastName = "Stroud",
                    Email = "dustroud@mail.com",
                    UserName = "dustroud@mail.com",
                    ZipCode = 75221,
                    Birthday = new DateTime(1974, 7, 14),
                    StreetAddress = "1212 Henrietta Rd",
                },
                // password and role are here
                Password = "klavjkb48",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Eric",
                    LastName = "Stuart",
                    Email = "eric_stuart@puppy.com",
                    UserName = "eric_stuart@puppy.com",
                    ZipCode = 78746,
                    Birthday = new DateTime(1968, 6, 17),
                    StreetAddress = "5576 Big Ring",
                },
                // password and role are here
                Password = "vkb451",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Peter",
                    LastName = "Stump",
                    Email = "peterstump@hootmail.com",
                    UserName = "peterstump@hootmail.com",
                    ZipCode = 77018,
                    Birthday = new DateTime(2001, 7, 23),
                    StreetAddress = "1300 Kellen Square",
                },
                // password and role are here
                Password = "kdsiu4",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Jeremy",
                    LastName = "Tanner",
                    Email = "tanner@puppy.com",
                    UserName = "tanner@puppy.com",
                    ZipCode = 77044,
                    Birthday = new DateTime(1973, 12, 28),
                    StreetAddress = "4347 Palmstead",
                },
                // password and role are here
                Password = "klrfbj45",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Allison",
                    LastName = "Taylor",
                    Email = "taylordjay@puppy.com",
                    UserName = "taylordjay@puppy.com",
                    ZipCode = 78705,
                    Birthday = new DateTime(1999, 9, 30),
                    StreetAddress = "467 Nueces St.",
                },
                // password and role are here
                Password = "lraggrhb854",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Rachel",
                    LastName = "Taylor",
                    Email = "lraggrhb854.Taylor@aool.com",
                    UserName = "lraggrhb854.Taylor@aool.com",
                    ZipCode = 78705,
                    Birthday = new DateTime(1956, 2, 24),
                    StreetAddress = "345 Shortview Dr.",
                },
                // password and role are here
                Password = "alsuib95",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Frank",
                    LastName = "Tee",
                    Email = "tee_frank@hootmail.com",
                    UserName = "tee_frank@hootmail.com",
                    ZipCode = 77004,
                    Birthday = new DateTime(1964, 11, 11),
                    StreetAddress = "5590 Big Dr.",
                },
                // password and role are here
                Password = "kd1734",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Clent",
                    LastName = "Tucker",
                    Email = "tuck33@puppy.com",
                    UserName = "tuck33@puppy.com",
                    ZipCode = 75315,
                    Birthday = new DateTime(1990, 6, 25),
                    StreetAddress = "3132 Main St.",
                },
                // password and role are here
                Password = "kjdb983",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Allen",
                    LastName = "Velasco",
                    Email = "avelasco@puppy.com",
                    UserName = "avelasco@puppy.com",
                    ZipCode = 75207,
                    Birthday = new DateTime(1966, 12, 13),
                    StreetAddress = "634 W. 4th",
                },
                // password and role are here
                Password = "odrb02",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Jake",
                    LastName = "West",
                    Email = "westj@pioneer.net",
                    UserName = "westj@pioneer.net",
                    ZipCode = 75323,
                    Birthday = new DateTime(1968, 2, 6),
                    StreetAddress = "RR 3244",
                },
                // password and role are here
                Password = "kndl847",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Louis",
                    LastName = "Winthorpe",
                    Email = "louielouie@puppy.com",
                    UserName = "louielouie@puppy.com",
                    ZipCode = 78746,
                    Birthday = new DateTime(1961, 7, 23),
                    StreetAddress = "2500 Madre Blvd",
                },
                // password and role are here
                Password = "lb2394",
                RoleName = "Customer",
            });

            AllUsers.Add(new AddUserModel()
            {

                User = new AppUser()
                {
                    //populate the user properties that are from the
                    //IdentityUser base class
                    FirstName = "Reagan",
                    LastName = "Wood",
                    Email = "rwood@voyager.net",
                    UserName = "rwood@voyager.net",
                    ZipCode = 78746,
                    Birthday = new DateTime(1988, 10, 24),
                    StreetAddress = "447 Westlake Dr.",
                },
                // password and role are here
                Password = "drai494",
                RoleName = "Customer",
            });


            //create flag to help with errors
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: " 
                    + errorFlag, ex);
            }

            return result;
        }
    }
}
