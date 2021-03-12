using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Collegiate.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ContactEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(nullable: false),
                    Address1 = table.Column<string>(nullable: false),
                    Address2 = table.Column<string>(nullable: true),
                    LocationName = table.Column<string>(nullable: false),
                    PickupLocationDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    DriverRating = table.Column<double>(nullable: false),
                    VehicleId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_Drivers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiderRequests",
                columns: table => new
                {
                    RiderRequestId = table.Column<string>(nullable: false),
                    DepartureTime = table.Column<DateTime>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    ReturnTime = table.Column<DateTime>(nullable: false),
                    AddressId = table.Column<string>(nullable: true),
                    ToNMC = table.Column<bool>(nullable: false),
                    RiderComments = table.Column<string>(nullable: true),
                    Campus = table.Column<string>(nullable: true),
                    OfferClosed = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiderRequests", x => x.RiderRequestId);
                    table.ForeignKey(
                        name: "FK_RiderRequests_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiderRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DriverOffers",
                columns: table => new
                {
                    DriverOfferId = table.Column<string>(nullable: false),
                    DriverId = table.Column<string>(nullable: true),
                    DepartureTime = table.Column<DateTime>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    ReturnTime = table.Column<DateTime>(nullable: false),
                    AddressId = table.Column<string>(nullable: true),
                    ToNMC = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    OfferClosed = table.Column<bool>(nullable: false),
                    Campus = table.Column<string>(nullable: true),
                    ToMeetLocationDesc = table.Column<string>(nullable: true),
                    FromMeetLocationDesc = table.Column<string>(nullable: true),
                    SeatsAvailable = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverOffers", x => x.DriverOfferId);
                    table.ForeignKey(
                        name: "FK_DriverOffers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DriverOffers_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DriverOffers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<string>(nullable: false),
                    DriverID = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    MaxSeating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicles_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactEmail", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", 0, "b9c1044e-23e2-492e-a0f0-01d68a021172", "a.aliquet@anteiaculis.net", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "eget.ipsum.Donec@nondui.co.uk", false, "Aquila", "Carroll", false, null, null, null, "Password1", "1-231-520-8702", null, false, "8c089565-5109-40b6-b250-b144060f6675", false, new DateTime(2021, 3, 11, 21, 19, 59, 123, DateTimeKind.Local).AddTicks(7355), "interdum.libero.dui@acurnaUt.net" },
                    { "B8C63411-A600-B238-E734-E0F4FDD505F0", 0, "1d1a2bd2-a8a9-4be6-a520-db65ea861588", "a.neque@Suspendissealiquetmolestie.edu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "risus.odio.auctor@non.edu", false, "Garrison", "Baldwin", false, null, null, null, "Password1", "1-231-811-9180", null, false, "aab2ee67-0ae0-4f66-bcff-119075441601", false, new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5746), "ac.mattis@malesuadafamesac.com" },
                    { "DDD1ADD9-5AD9-33FC-FB9B-C901B27D232A", 0, "650a4c3f-e9ea-4e21-bfe2-ff981e39be1a", "conubia.nostra@diamPellentesquehabitant.org", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quisque.porttitor@convallisantelectus.com", false, "Arden", "Landry", false, null, null, null, "Password1", "1-231-502-5970", null, false, "f4533877-3735-4828-8426-1e8458334ff6", false, new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5858), "iaculis@sapienmolestieorci.org" },
                    { "55D5ADBB-50F6-E6BF-905F-2D72E4105231", 0, "bea1ed4f-040a-480a-9c18-11e768a0c4de", "dolor@nec.co.uk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "netus.et@porttitortellus.edu", false, "Brady", "Livingston", false, null, null, null, "Password1", "1-231-153-4083", null, false, "4d825967-481a-4790-b910-1527974f7fd4", false, new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5885), "laoreet@massa.net" },
                    { "4B941445-7EA2-BB82-5913-D87BE1CB1768", 0, "4dcef05e-722f-45b4-a48e-d5a047517dd2", "mauris.Integer.sem@et.co.uk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tincidunt.adipiscing.Mauris@Maecenas.ca", false, "Kaden", "Mcclure", false, null, null, null, "Password1", "1-231-415-5106", null, false, "0bfa7e40-1df8-4a80-8d76-99b6f1b821b5", false, new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5894), "magna.Praesent.interdum@Curabitursedtortor.ca" },
                    { "897978AF-644E-40D1-1D47-60E19C08CBDD", 0, "a3c8224b-277d-44d0-b6bc-2726bc9eae3b", "eget@iaculislacuspede.ca", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "libero.Proin.mi@Integer.co.uk", false, "Alice", "Vargas", false, null, null, null, "Password1", "1-231-353-5712", null, false, "526cacd0-7357-44fb-a6c1-cb48e94e5b76", false, new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5903), "porttitor@felisorciadipiscing.co.uk" },
                    { "339ACF0D-CCCB-C231-298F-CA948C00BCD6", 0, "0a307fe9-6e14-4ad6-b5bd-7e689e8221e8", "dui.Cum@Sedcongue.edu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sapien.cursus@dolor.com", false, "Aidan", "Suarez", false, null, null, null, "Password1", "1-231-323-5744", null, false, "01fa33d5-6451-479c-a25a-406246f75512", false, new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5916), "Vivamus@Fusce.ca" },
                    { "56D6F8FA-A0F5-5EAA-351E-29A7A8DD8627", 0, "d16533d4-490c-4500-950f-be58ddc5f154", "erat.Vivamus@elementumpurusaccumsan.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donec@Nulla.edu", false, "Zachery", "Powers", false, null, null, null, "Password1", "1-231-317-4825", null, false, "c19bbe1a-2b2f-4aeb-8841-9296f83ce15b", false, new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5924), "ligula.consectetuer.rhoncus@maurissagittis.com" },
                    { "267ECF2D-E9E0-EC5A-BA50-0F78C452AEEE", 0, "0a0af034-6faf-4496-a525-95cea3798c38", "consectetuer.adipiscing.elit@facilisis.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curabitur.egestas@etlacinia.net", false, "Hunter", "Simpson", false, null, null, null, "Password1", "1-231-415-1510", null, false, "33c47454-a560-4c52-b446-8853c890ba98", false, new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5935), "orci@Aliquam.com" },
                    { "3344C500-2985-D75D-1E1A-AB1E13F554EF", 0, "c6fa86aa-f078-4786-9220-b4f1cfe73235", "Ut@tellusimperdietnon.org", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ipsum.primis.in@nascetur.net", false, "Emerson", "Cleveland", false, null, null, null, "Password1", "1-231-357-6886", null, false, "d45d442f-f935-49d1-b07e-91ae50b50376", false, new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5944), "tellus@dignissimpharetra.ca" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "Address1", "Address2", "City", "LocationName", "PickupLocationDescription", "Type", "UserId", "Zip" },
                values: new object[,]
                {
                    { "0343fbc8-a866-4e7e-aaf6-b095f12a70ce", "2899 Lafrainer Rd.", null, "Traverse City", "Grandma's House", "I'll be at kings Court Right outside the sign on Lafranier", "Residence", "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49686" },
                    { "5d56bd1d-8bf7-4c2c-8b55-984186650386", "8917 E 34 Rd", null, "Cadilliac", "Walmart", "It's the only walmart in Cadilliac I'll be at the main enterance", "MeetingPlace", "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49601" },
                    { "2abc4f72-8a6c-4419-ac65-465b229ae5a4", "809 North Cedar St", null, "Kalkaska", "Shell", "I'll be at the main enterance", "MeetingPlace", "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49646" },
                    { "96308717-4d4c-46ed-8e58-51412d5d9645", "9812 Honor Hwy", null, "Honor", "Cherry Bowl", "I'll be at the main enterance", "MeetingPlace", "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49640" },
                    { "7070fb2e-76b3-4e1c-808e-836fd5668cbe", "205 Madison Ave", "Apt 209", "Kingsley", "My Place", "I'll be at the main enterance", "Residence", "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49640" },
                    { "00000000-0000-0000-0000-000000000000", "1701 East Front St", null, "Traverse City", "NMC", "You choose Location", "Campus", "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49686" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverId", "DriverRating", "UserId", "VehicleId" },
                values: new object[,]
                {
                    { "546bded4-592c-4ee1-bc34-601c47049f1b", 4.0, "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "303a164e-2159-40fd-bfbd-88b3f9dd2c4a" },
                    { "81acb598-9150-4b45-881d-58164979c82a", 4.0, "B8C63411-A600-B238-E734-E0F4FDD505F0", "95affda5-e695-4937-8053-aea3b71f541f" },
                    { "fa1fa970-e30d-4116-8ba9-8f7a88d27b97", 4.0, "DDD1ADD9-5AD9-33FC-FB9B-C901B27D232A", "486114be-6706-4122-ad40-e812bcc459d7" },
                    { "9769de71-8f92-4c31-acb6-1e754c2076e4", 4.0, "55D5ADBB-50F6-E6BF-905F-2D72E4105231", "1717adf7-6a34-4907-baa0-23d211262892" },
                    { "c2ebd11f-0e4b-412f-82d4-e57f86e554b6", 4.0, "4B941445-7EA2-BB82-5913-D87BE1CB1768", "cddb3123-00dd-4872-81ab-ce620ae20fde" }
                });

            migrationBuilder.InsertData(
                table: "DriverOffers",
                columns: new[] { "DriverOfferId", "AddressId", "ArrivalTime", "Campus", "DepartureTime", "DriverId", "FromMeetLocationDesc", "OfferClosed", "ReturnTime", "SeatsAvailable", "ToMeetLocationDesc", "ToNMC", "UserId" },
                values: new object[,]
                {
                    { "3bf8d706-472e-4497-b4e6-111fb4ebf24c", null, new DateTime(2020, 4, 15, 12, 30, 0, 0, DateTimeKind.Unspecified), "Main Campus", new DateTime(2020, 4, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), "546bded4-592c-4ee1-bc34-601c47049f1b", null, false, new DateTime(2020, 4, 15, 15, 30, 0, 0, DateTimeKind.Unspecified), 3, "I plan on dropping everybody off at the Library Parking Lot", true, null },
                    { "b17c6728-1008-4ebb-b39c-57a41f490b24", "0343fbc8-a866-4e7e-aaf6-b095f12a70ce", new DateTime(2020, 4, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 4, 15, 15, 30, 0, 0, DateTimeKind.Unspecified), "546bded4-592c-4ee1-bc34-601c47049f1b", "I plan on picking people up at the Library Parking Lot", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, false, null },
                    { "30836417-2d86-4fe2-b8b3-cbc964d8f46b", null, new DateTime(2020, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), "Aero Park", new DateTime(2020, 4, 16, 11, 30, 0, 0, DateTimeKind.Unspecified), "546bded4-592c-4ee1-bc34-601c47049f1b", null, false, new DateTime(2020, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), 3, "I plan on dropping everybody off at main building enterance", true, null },
                    { "4661cc56-b9cf-4704-9553-894aae98436a", "5d56bd1d-8bf7-4c2c-8b55-984186650386", new DateTime(2020, 4, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), "Main Campus", new DateTime(2020, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), "546bded4-592c-4ee1-bc34-601c47049f1b", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "I plan on dropping everybody off at the back of the parking lot at Walmart", false, null },
                    { "6357d0f6-463a-44ba-887b-0648b6ba33dc", null, new DateTime(2020, 4, 17, 22, 30, 0, 0, DateTimeKind.Unspecified), "Main Campus", new DateTime(2020, 4, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "546bded4-592c-4ee1-bc34-601c47049f1b", null, false, new DateTime(2020, 4, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), 3, "I plan on dropping everybody off at the Library Parking Lot", true, null },
                    { "a87df131-18b8-4762-9d24-dc6e679458ba", "5d56bd1d-8bf7-4c2c-8b55-984186650386", new DateTime(2020, 4, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), "Main Campus", new DateTime(2020, 4, 17, 13, 30, 0, 0, DateTimeKind.Unspecified), "546bded4-592c-4ee1-bc34-601c47049f1b", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "I plan on dropping everybody off at the back of the parking lot at Walmart", false, null },
                    { "adf3fbad-0ed9-4a9d-880b-1e8b2271bcdb", null, new DateTime(2020, 4, 22, 12, 30, 0, 0, DateTimeKind.Unspecified), "Main Campus", new DateTime(2020, 4, 22, 10, 30, 0, 0, DateTimeKind.Unspecified), "546bded4-592c-4ee1-bc34-601c47049f1b", null, false, new DateTime(2020, 4, 22, 15, 30, 0, 0, DateTimeKind.Unspecified), 3, "I plan on dropping everybody off at the Library Parking Lot", true, null },
                    { "c4436384-9cd1-453c-8880-30e1de5c71aa", "5d56bd1d-8bf7-4c2c-8b55-984186650386", new DateTime(2020, 4, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), "Main Campus", new DateTime(2020, 4, 22, 15, 30, 0, 0, DateTimeKind.Unspecified), "546bded4-592c-4ee1-bc34-601c47049f1b", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "I plan on dropping everybody off at the back of the parking lot at Walmart", false, null },
                    { "26d39cb7-4b4d-4e99-860f-1465277e3adc", null, new DateTime(2020, 4, 23, 12, 30, 0, 0, DateTimeKind.Unspecified), "Main Campus", new DateTime(2020, 4, 23, 11, 30, 0, 0, DateTimeKind.Unspecified), "546bded4-592c-4ee1-bc34-601c47049f1b", null, false, new DateTime(2020, 4, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 3, "I plan on dropping everybody off at the Library Parking Lot", true, null },
                    { "1d0dfb0d-efdc-48eb-bc77-2c5b8520e5b0", "5d56bd1d-8bf7-4c2c-8b55-984186650386", new DateTime(2020, 4, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), "Main Campus", new DateTime(2020, 4, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), "546bded4-592c-4ee1-bc34-601c47049f1b", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "I plan on dropping everybody off at the back of the parking lot at Walmart", false, null }
                });

            migrationBuilder.InsertData(
                table: "RiderRequests",
                columns: new[] { "RiderRequestId", "AddressId", "ArrivalTime", "Campus", "DepartureTime", "OfferClosed", "ReturnTime", "RiderComments", "ToNMC", "UserId" },
                values: new object[,]
                {
                    { "F87EB0B8-F687-41FB-8973-D5211B01ACD3", "0343fbc8-a866-4e7e-aaf6-b095f12a70ce", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 4, 15, 15, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "B8C63411-A600-B238-E734-E0F4FDD505F0" },
                    { "097E9CF0-793B-48E0-B851-D2DDB882ABB3", "5d56bd1d-8bf7-4c2c-8b55-984186650386", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "B8C63411-A600-B238-E734-E0F4FDD505F0" },
                    { "05378CE6-F765-4FC7-9F95-3B6E47633CFA", "00000000-0000-0000-0000-000000000000", new DateTime(2020, 4, 15, 12, 30, 0, 0, DateTimeKind.Unspecified), "Main", new DateTime(2020, 4, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 4, 15, 15, 30, 0, 0, DateTimeKind.Unspecified), null, true, "B8C63411-A600-B238-E734-E0F4FDD505F0" },
                    { "5253DA99-5E44-44C8-ADDE-86FD48731810", "00000000-0000-0000-0000-000000000000", new DateTime(2020, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), "Main", new DateTime(2020, 4, 16, 10, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), null, true, "B8C63411-A600-B238-E734-E0F4FDD505F0" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "DriverID", "Make", "MaxSeating", "Model", "Year" },
                values: new object[] { "A603CA52-6B09-4C34-B647-0D9B7AF5CFBA", "546bded4-592c-4ee1-bc34-601c47049f1b", "Ford", 3, "Taurus", "2012" });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverOffers_AddressId",
                table: "DriverOffers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverOffers_DriverId",
                table: "DriverOffers",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverOffers_UserId",
                table: "DriverOffers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_UserId",
                table: "Drivers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RiderRequests_AddressId",
                table: "RiderRequests",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_RiderRequests_UserId",
                table: "RiderRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DriverID",
                table: "Vehicles",
                column: "DriverID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DriverOffers");

            migrationBuilder.DropTable(
                name: "RiderRequests");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
