using System;
using System.Collections.Generic;
using System.Text;
using Collegiate.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Collegiate.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public override DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<DriverOffer> DriverOffers { get; set; }

        public DbSet<RiderRequest> RiderRequests { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { Id = "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", FirstName = "Aquila", LastName = "Carroll", UserName = "interdum.libero.dui@acurnaUt.net", Email = "eget.ipsum.Donec@nondui.co.uk", Phone = "1-231-520-8702", ContactEmail = "a.aliquet@anteiaculis.net", PasswordHash = "Password1" },
                new User { Id = "B8C63411-A600-B238-E734-E0F4FDD505F0", FirstName = "Garrison", LastName = "Baldwin", UserName = "ac.mattis@malesuadafamesac.com", Email = "risus.odio.auctor@non.edu", Phone = "1-231-811-9180", ContactEmail = "a.neque@Suspendissealiquetmolestie.edu", PasswordHash = "Password1" },
                new User { Id = "DDD1ADD9-5AD9-33FC-FB9B-C901B27D232A", FirstName = "Arden", LastName = "Landry", UserName = "iaculis@sapienmolestieorci.org", Email = "Quisque.porttitor@convallisantelectus.com", Phone = "1-231-502-5970", ContactEmail = "conubia.nostra@diamPellentesquehabitant.org", PasswordHash = "Password1" },
                new User { Id = "55D5ADBB-50F6-E6BF-905F-2D72E4105231", FirstName = "Brady", LastName = "Livingston", UserName = "laoreet@massa.net", Email = "netus.et@porttitortellus.edu", Phone = "1-231-153-4083", ContactEmail = "dolor@nec.co.uk", PasswordHash = "Password1" },
                new User { Id = "4B941445-7EA2-BB82-5913-D87BE1CB1768", FirstName = "Kaden", LastName = "Mcclure", UserName = "magna.Praesent.interdum@Curabitursedtortor.ca", Email = "tincidunt.adipiscing.Mauris@Maecenas.ca", Phone = "1-231-415-5106", ContactEmail = "mauris.Integer.sem@et.co.uk", PasswordHash = "Password1" },
                new User { Id = "897978AF-644E-40D1-1D47-60E19C08CBDD", FirstName = "Alice", LastName = "Vargas", UserName = "porttitor@felisorciadipiscing.co.uk", Email = "libero.Proin.mi@Integer.co.uk", Phone = "1-231-353-5712", ContactEmail = "eget@iaculislacuspede.ca", PasswordHash = "Password1" },
                new User { Id = "339ACF0D-CCCB-C231-298F-CA948C00BCD6", FirstName = "Aidan", LastName = "Suarez", UserName = "Vivamus@Fusce.ca", Email = "sapien.cursus@dolor.com", Phone = "1-231-323-5744", ContactEmail = "dui.Cum@Sedcongue.edu", PasswordHash = "Password1" },
                new User { Id = "56D6F8FA-A0F5-5EAA-351E-29A7A8DD8627", FirstName = "Zachery", LastName = "Powers", UserName = "ligula.consectetuer.rhoncus@maurissagittis.com", Email = "Donec@Nulla.edu", Phone = "1-231-317-4825", ContactEmail = "erat.Vivamus@elementumpurusaccumsan.com", PasswordHash = "Password1" },
                new User { Id = "267ECF2D-E9E0-EC5A-BA50-0F78C452AEEE", FirstName = "Hunter", LastName = "Simpson", UserName = "orci@Aliquam.com", Email = "Curabitur.egestas@etlacinia.net", Phone = "1-231-415-1510", ContactEmail = "consectetuer.adipiscing.elit@facilisis.com", PasswordHash = "Password1" },
                new User { Id = "3344C500-2985-D75D-1E1A-AB1E13F554EF", FirstName = "Emerson", LastName = "Cleveland", UserName = "tellus@dignissimpharetra.ca", Email = "ipsum.primis.in@nascetur.net", Phone = "1-231-357-6886", ContactEmail = "Ut@tellusimperdietnon.org", PasswordHash = "Password1" }

            );

            //seed addresses
            modelBuilder.Entity<Address>().HasData(
                new Address { AddressId = "0343fbc8-a866-4e7e-aaf6-b095f12a70ce", UserId = "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", Type = "Residence", Address1 = "2899 Lafrainer Rd.", City = "Traverse City", PickupLocationDescription = "I'll be at kings Court Right outside the sign on Lafranier", Zip = "49686", LocationName = "Grandma's House" },
                new Address { AddressId = "5d56bd1d-8bf7-4c2c-8b55-984186650386", UserId = "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", Type = "MeetingPlace", Address1 = "8917 E 34 Rd", City = "Cadilliac", PickupLocationDescription = "It's the only walmart in Cadilliac I'll be at the main enterance", Zip = "49601", LocationName = "Walmart" },
                new Address { AddressId = "2abc4f72-8a6c-4419-ac65-465b229ae5a4", UserId = "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", Type = "MeetingPlace", Address1 = "809 North Cedar St", City = "Kalkaska", PickupLocationDescription = "I'll be at the main enterance", Zip = "49646", LocationName = "Shell" },
                new Address { AddressId = "96308717-4d4c-46ed-8e58-51412d5d9645", UserId = "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", Type = "MeetingPlace", Address1 = "9812 Honor Hwy", City = "Honor", PickupLocationDescription = "I'll be at the main enterance", Zip = "49640", LocationName = "Cherry Bowl" },
                new Address { AddressId = "7070fb2e-76b3-4e1c-808e-836fd5668cbe", UserId = "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", Type = "Residence", Address1 = "205 Madison Ave", Address2 = "Apt 209", City = "Kingsley", PickupLocationDescription = "I'll be at the main enterance", Zip = "49640", LocationName = "My Place" },
                new Address { AddressId = "00000000-0000-0000-0000-000000000000", UserId = "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", Type = "Campus", Address1 = "1701 East Front St", City = "Traverse City", PickupLocationDescription = "You choose Location", Zip = "49686", LocationName = "NMC"}
            );

            //seed Driver
            modelBuilder.Entity<Driver>().HasData(
                new Driver { DriverId = "546bded4-592c-4ee1-bc34-601c47049f1b", UserId = "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", DriverRating = 4, VehicleId = "303a164e-2159-40fd-bfbd-88b3f9dd2c4a" },
                new Driver { DriverId = "81acb598-9150-4b45-881d-58164979c82a", UserId = "B8C63411-A600-B238-E734-E0F4FDD505F0", DriverRating = 4, VehicleId = "95affda5-e695-4937-8053-aea3b71f541f" },
                new Driver { DriverId = "fa1fa970-e30d-4116-8ba9-8f7a88d27b97", UserId = "DDD1ADD9-5AD9-33FC-FB9B-C901B27D232A", DriverRating = 4, VehicleId = "486114be-6706-4122-ad40-e812bcc459d7" },
                new Driver { DriverId = "9769de71-8f92-4c31-acb6-1e754c2076e4", UserId = "55D5ADBB-50F6-E6BF-905F-2D72E4105231", DriverRating = 4, VehicleId = "1717adf7-6a34-4907-baa0-23d211262892" },
                new Driver { DriverId = "c2ebd11f-0e4b-412f-82d4-e57f86e554b6", UserId = "4B941445-7EA2-BB82-5913-D87BE1CB1768", DriverRating = 4, VehicleId = "cddb3123-00dd-4872-81ab-ce620ae20fde" }
                );

            modelBuilder.Entity<DriverOffer>().HasData(
                new DriverOffer { DriverId = "546bded4-592c-4ee1-bc34-601c47049f1b", DriverOfferId = "3bf8d706-472e-4497-b4e6-111fb4ebf24c", DepartureTime = Convert.ToDateTime("4/15/2020 10:30:00 AM"), ArrivalTime = Convert.ToDateTime("4/15/2021 12:30:00 PM"), ReturnTime = Convert.ToDateTime("4 / 15 / 2020 3:30:00 PM"), Campus= "Main Campus", ToNMC = true,  SeatsAvailable = 3, ToMeetLocationDesc = "I plan on dropping everybody off at the Library Parking Lot", OfferClosed = false},
                new DriverOffer { DriverId = "546bded4-592c-4ee1-bc34-601c47049f1b", DriverOfferId = "b17c6728-1008-4ebb-b39c-57a41f490b24", DepartureTime = Convert.ToDateTime("4/15/2020 3:30:00 PM"), ArrivalTime = Convert.ToDateTime("4/15/2021 5:30:00 PM"), AddressId = "0343fbc8-a866-4e7e-aaf6-b095f12a70ce", ToNMC = false, SeatsAvailable = 3, FromMeetLocationDesc= "I plan on picking people up at the Library Parking Lot", OfferClosed = false },
                new DriverOffer { DriverId = "546bded4-592c-4ee1-bc34-601c47049f1b", DriverOfferId = "30836417-2d86-4fe2-b8b3-cbc964d8f46b", DepartureTime = Convert.ToDateTime("4/16/2020 11:30:00 AM"), ArrivalTime = Convert.ToDateTime("4/16/2021 1:30:00 PM"), ReturnTime = Convert.ToDateTime("4/16/2020 1:30:00 PM"), Campus = "Aero Park", ToNMC = true, SeatsAvailable = 3, ToMeetLocationDesc = "I plan on dropping everybody off at main building enterance", OfferClosed = false },
                new DriverOffer { DriverId = "546bded4-592c-4ee1-bc34-601c47049f1b", DriverOfferId = "4661cc56-b9cf-4704-9553-894aae98436a", DepartureTime = Convert.ToDateTime("4/16/2020 1:30:00 PM"), ArrivalTime = Convert.ToDateTime("4/16/2021 4:30:00 PM"), AddressId = "5d56bd1d-8bf7-4c2c-8b55-984186650386", Campus = "Main Campus", ToNMC = false, SeatsAvailable = 3, ToMeetLocationDesc = "I plan on dropping everybody off at the back of the parking lot at Walmart", OfferClosed = false },
                new DriverOffer { DriverId = "546bded4-592c-4ee1-bc34-601c47049f1b", DriverOfferId = "6357d0f6-463a-44ba-887b-0648b6ba33dc", DepartureTime = Convert.ToDateTime("4/17/2020 9:00:00 AM"), ArrivalTime = Convert.ToDateTime("4/17/2021 10:30:00 PM"), ReturnTime = Convert.ToDateTime("4/17/2020 5:30:00 PM"), Campus = "Main Campus", ToNMC = true, SeatsAvailable = 3, ToMeetLocationDesc = "I plan on dropping everybody off at the Library Parking Lot", OfferClosed = false },
                new DriverOffer { DriverId = "546bded4-592c-4ee1-bc34-601c47049f1b", DriverOfferId = "a87df131-18b8-4762-9d24-dc6e679458ba", DepartureTime = Convert.ToDateTime("4/17/2020 1:30:00 PM"), ArrivalTime = Convert.ToDateTime("4/17/2021 2:30:00 PM"), AddressId = "5d56bd1d-8bf7-4c2c-8b55-984186650386", Campus = "Main Campus", ToNMC = false, SeatsAvailable = 3, ToMeetLocationDesc = "I plan on dropping everybody off at the back of the parking lot at Walmart", OfferClosed = false },
                new DriverOffer { DriverId = "546bded4-592c-4ee1-bc34-601c47049f1b", DriverOfferId = "adf3fbad-0ed9-4a9d-880b-1e8b2271bcdb", DepartureTime = Convert.ToDateTime("4/22/2020 10:30:00 AM"), ArrivalTime = Convert.ToDateTime("4/22/2021 12:30:00 PM"), ReturnTime= Convert.ToDateTime("4/22/2020 3:30:00 PM"), Campus = "Main Campus", ToNMC = true, SeatsAvailable = 3, ToMeetLocationDesc = "I plan on dropping everybody off at the Library Parking Lot", OfferClosed = false },
                new DriverOffer { DriverId = "546bded4-592c-4ee1-bc34-601c47049f1b", DriverOfferId = "c4436384-9cd1-453c-8880-30e1de5c71aa", DepartureTime = Convert.ToDateTime("4/22/2020 3:30:00 PM"), ArrivalTime = Convert.ToDateTime("4/22/2021 6:30:00 PM"), AddressId = "5d56bd1d-8bf7-4c2c-8b55-984186650386", Campus = "Main Campus", ToNMC = false, SeatsAvailable = 3, ToMeetLocationDesc = "I plan on dropping everybody off at the back of the parking lot at Walmart", OfferClosed = false },
                new DriverOffer { DriverId = "546bded4-592c-4ee1-bc34-601c47049f1b", DriverOfferId = "26d39cb7-4b4d-4e99-860f-1465277e3adc", DepartureTime = Convert.ToDateTime("4/23/2020 11:30:00 AM"), ArrivalTime = Convert.ToDateTime("4/23/2021 12:30:00 PM"), ReturnTime= Convert.ToDateTime("4/23/20 4:30:00 PM"), Campus = "Main Campus", ToNMC = true, SeatsAvailable = 3, ToMeetLocationDesc = "I plan on dropping everybody off at the Library Parking Lot", OfferClosed = false },
                new DriverOffer { DriverId = "546bded4-592c-4ee1-bc34-601c47049f1b", DriverOfferId = "1d0dfb0d-efdc-48eb-bc77-2c5b8520e5b0", DepartureTime = Convert.ToDateTime("4/23/2020 4:30:00 PM"), ArrivalTime = Convert.ToDateTime("4/23/2021 5:30:00 PM"), AddressId = "5d56bd1d-8bf7-4c2c-8b55-984186650386", Campus = "Main Campus", ToNMC = false, SeatsAvailable = 3, ToMeetLocationDesc = "I plan on dropping everybody off at the back of the parking lot at Walmart", OfferClosed = false }
                );

            modelBuilder.Entity<RiderRequest>().HasData(
                new RiderRequest { UserId = "B8C63411-A600-B238-E734-E0F4FDD505F0", RiderRequestId = "05378CE6-F765-4FC7-9F95-3B6E47633CFA", Campus = "Main", DepartureTime = Convert.ToDateTime("4/15/2021 10:30:00 AM"), ArrivalTime = Convert.ToDateTime("4/15/2020 12:30:00 PM"), ToNMC = true, ReturnTime = Convert.ToDateTime("4/15/2020 3:30:00 PM"), OfferClosed = false, AddressId = "00000000-0000-0000-0000-000000000000"},
                new RiderRequest { UserId = "B8C63411-A600-B238-E734-E0F4FDD505F0", RiderRequestId = "F87EB0B8-F687-41FB-8973-D5211B01ACD3", DepartureTime = Convert.ToDateTime("4/15/2021 3:30:00 PM"), ToNMC = false, OfferClosed = false, AddressId = "0343fbc8-a866-4e7e-aaf6-b095f12a70ce" },
                new RiderRequest { UserId = "B8C63411-A600-B238-E734-E0F4FDD505F0", RiderRequestId = "5253DA99-5E44-44C8-ADDE-86FD48731810", Campus = "Main", DepartureTime = Convert.ToDateTime("4/16/2021 10:30:00 AM"), ArrivalTime = Convert.ToDateTime("4/16/2020 1:30:00 PM"), ToNMC = true, ReturnTime = Convert.ToDateTime("4/16/2020 1:30:00 PM"), OfferClosed = false, AddressId = "00000000-0000-0000-0000-000000000000"},
                new RiderRequest { UserId = "B8C63411-A600-B238-E734-E0F4FDD505F0", RiderRequestId = "097E9CF0-793B-48E0-B851-D2DDB882ABB3", DepartureTime = Convert.ToDateTime("4/16/2021 1:30:00 PM"), ToNMC = false, AddressId = "5d56bd1d-8bf7-4c2c-8b55-984186650386" }
                );

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle { VehicleId = "A603CA52-6B09-4C34-B647-0D9B7AF5CFBA", DriverID = "546bded4-592c-4ee1-bc34-601c47049f1b", Year = "2012", Make = "Ford", Model = "Taurus", MaxSeating = 3 }
                );

        }
    }
}
