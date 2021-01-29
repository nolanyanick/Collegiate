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
                    Type = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(nullable: false),
                    Address1 = table.Column<string>(nullable: false),
                    Address2 = table.Column<string>(nullable: true),
                    LocationName = table.Column<string>(nullable: false),
                    PickupLocationDescription = table.Column<string>(nullable: false)
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
                name: "Preferences",
                columns: table => new
                {
                    PreferenceId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Smoking = table.Column<bool>(nullable: false),
                    Music = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferences", x => x.PreferenceId);
                    table.ForeignKey(
                        name: "FK_Preferences_AspNetUsers_UserId",
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

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<string>(nullable: false),
                    DepartureTime = table.Column<DateTime>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    DestinationAddressId = table.Column<string>(nullable: true),
                    DepartureAddressId = table.Column<string>(nullable: true),
                    ToNMC = table.Column<bool>(nullable: false),
                    TripFull = table.Column<bool>(nullable: false),
                    SeatsAvailable = table.Column<int>(nullable: false),
                    DriverID = table.Column<string>(nullable: true),
                    ToMeetLocationDesc = table.Column<string>(nullable: true),
                    FromMeetLocationDesc = table.Column<string>(nullable: true),
                    DriverOfferId = table.Column<string>(nullable: true),
                    OnTime = table.Column<bool>(nullable: false),
                    Campus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                    table.ForeignKey(
                        name: "FK_Trips_Addresses_DepartureAddressId",
                        column: x => x.DepartureAddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trips_Addresses_DestinationAddressId",
                        column: x => x.DestinationAddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trips_DriverOffers_DriverOfferId",
                        column: x => x.DriverOfferId,
                        principalTable: "DriverOffers",
                        principalColumn: "DriverOfferId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    DriverOfferId = table.Column<string>(nullable: true),
                    TripId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_DriverOffers_DriverOfferId",
                        column: x => x.DriverOfferId,
                        principalTable: "DriverOffers",
                        principalColumn: "DriverOfferId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
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
                    UserId = table.Column<string>(nullable: true),
                    TripId = table.Column<string>(nullable: true)
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
                        name: "FK_RiderRequests_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiderRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TripUsers",
                columns: table => new
                {
                    TripId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripUsers", x => new { x.UserId, x.TripId });
                    table.ForeignKey(
                        name: "FK_TripUsers_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactEmail", "CreatedOn", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", 0, "d045b521-7ee0-498c-bb4c-f76b474b69b5", "a.aliquet@anteiaculis.net", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "eget.ipsum.Donec@nondui.co.uk", false, "Aquila", "Carroll", false, null, null, null, "Password1", "1-231-520-8702", null, false, "4de6351b-b02a-4e8b-8a37-1662a5a8e36f", false, new DateTime(2020, 4, 13, 18, 43, 49, 578, DateTimeKind.Local).AddTicks(349), "interdum.libero.dui@acurnaUt.net" },
                    { "B8C63411-A600-B238-E734-E0F4FDD505F0", 0, "ccd17be3-ea50-4e3b-ba58-45cbde0ba3d6", "a.neque@Suspendissealiquetmolestie.edu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "risus.odio.auctor@non.edu", false, "Garrison", "Baldwin", false, null, null, null, "Password1", "1-231-811-9180", null, false, "7efd977f-a4a3-4a5e-8635-24a04c85196a", false, new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6180), "ac.mattis@malesuadafamesac.com" },
                    { "DDD1ADD9-5AD9-33FC-FB9B-C901B27D232A", 0, "166624c9-4a9a-400b-9db0-03105a20b3b1", "conubia.nostra@diamPellentesquehabitant.org", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quisque.porttitor@convallisantelectus.com", false, "Arden", "Landry", false, null, null, null, "Password1", "1-231-502-5970", null, false, "891ebd70-b36c-4944-b46e-1727cc6e49db", false, new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6360), "iaculis@sapienmolestieorci.org" },
                    { "55D5ADBB-50F6-E6BF-905F-2D72E4105231", 0, "b9a443e2-8935-4c78-b209-b1b4341bb923", "dolor@nec.co.uk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "netus.et@porttitortellus.edu", false, "Brady", "Livingston", false, null, null, null, "Password1", "1-231-153-4083", null, false, "64a3fd4b-1a28-4355-ba3b-4e5c9e5bc89c", false, new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6387), "laoreet@massa.net" },
                    { "4B941445-7EA2-BB82-5913-D87BE1CB1768", 0, "28e53e3d-935e-4501-b2f3-3e7c7b526f34", "mauris.Integer.sem@et.co.uk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tincidunt.adipiscing.Mauris@Maecenas.ca", false, "Kaden", "Mcclure", false, null, null, null, "Password1", "1-231-415-5106", null, false, "55f0e195-1433-4d6f-b044-3eb8589cde79", false, new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6403), "magna.Praesent.interdum@Curabitursedtortor.ca" },
                    { "897978AF-644E-40D1-1D47-60E19C08CBDD", 0, "0f941700-86e6-4d82-b2b6-183b2d0d93aa", "eget@iaculislacuspede.ca", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "libero.Proin.mi@Integer.co.uk", false, "Alice", "Vargas", false, null, null, null, "Password1", "1-231-353-5712", null, false, "ec58ed21-c5d6-4bd2-bd7a-397451aa74be", false, new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6416), "porttitor@felisorciadipiscing.co.uk" },
                    { "339ACF0D-CCCB-C231-298F-CA948C00BCD6", 0, "4e84fa28-2217-4a90-b32e-3e80efced8b6", "dui.Cum@Sedcongue.edu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sapien.cursus@dolor.com", false, "Aidan", "Suarez", false, null, null, null, "Password1", "1-231-323-5744", null, false, "f59b2e60-db5e-40c1-9b05-f833bf414e7c", false, new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6481), "Vivamus@Fusce.ca" },
                    { "56D6F8FA-A0F5-5EAA-351E-29A7A8DD8627", 0, "db489dbd-07c4-4fe0-bdc4-8816d22915a6", "erat.Vivamus@elementumpurusaccumsan.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donec@Nulla.edu", false, "Zachery", "Powers", false, null, null, null, "Password1", "1-231-317-4825", null, false, "630b8255-63b1-46cd-add2-b5a4a5fd6cb0", false, new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6494), "ligula.consectetuer.rhoncus@maurissagittis.com" },
                    { "267ECF2D-E9E0-EC5A-BA50-0F78C452AEEE", 0, "d8de02c8-5c43-44e3-bb19-a949aab32a08", "consectetuer.adipiscing.elit@facilisis.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curabitur.egestas@etlacinia.net", false, "Hunter", "Simpson", false, null, null, null, "Password1", "1-231-415-1510", null, false, "e5809476-3959-495c-85ac-6bece48a1642", false, new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6508), "orci@Aliquam.com" },
                    { "3344C500-2985-D75D-1E1A-AB1E13F554EF", 0, "bcf33b0e-e225-4457-8d04-038a5a9d02e1", "Ut@tellusimperdietnon.org", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ipsum.primis.in@nascetur.net", false, "Emerson", "Cleveland", false, null, null, null, "Password1", "1-231-357-6886", null, false, "0e047457-0bb3-4415-b469-f68f216af405", false, new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6523), "tellus@dignissimpharetra.ca" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "Address1", "Address2", "City", "LocationName", "PickupLocationDescription", "Type", "UserId", "Zip" },
                values: new object[,]
                {
                    { "0343fbc8-a866-4e7e-aaf6-b095f12a70ce", "2899 Lafrainer Rd.", null, "Traverse City", "Grandma's House", "I'll be at kings Court Right outside the sign on Lafranier", 0, "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49686" },
                    { "5d56bd1d-8bf7-4c2c-8b55-984186650386", "8917 E 34 Rd", null, "Cadilliac", "Walmart", "It's the only walmart in Cadilliac I'll be at the main enterance", 1, "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49601" },
                    { "2abc4f72-8a6c-4419-ac65-465b229ae5a4", "809 North Cedar St", null, "Kalkaska", "Shell", "I'll be at the main enterance", 1, "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49646" },
                    { "96308717-4d4c-46ed-8e58-51412d5d9645", "9812 Honor Hwy", null, "Honor", "Cherry Bowl", "I'll be at the main enterance", 1, "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49640" },
                    { "7070fb2e-76b3-4e1c-808e-836fd5668cbe", "205 Madison Ave", "Apt 209", "Kingsley", "My Place", "I'll be at the main enterance", 0, "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49640" },
                    { "00000000-0000-0000-0000-000000000000", "1701 East Front St", null, "Traverse City", "NMC", "You choose Location", 2, "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64", "49686" }
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
                columns: new[] { "RiderRequestId", "AddressId", "ArrivalTime", "Campus", "DepartureTime", "OfferClosed", "ReturnTime", "RiderComments", "ToNMC", "TripId", "UserId" },
                values: new object[,]
                {
                    { "F87EB0B8-F687-41FB-8973-D5211B01ACD3", "0343fbc8-a866-4e7e-aaf6-b095f12a70ce", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 4, 15, 15, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "B8C63411-A600-B238-E734-E0F4FDD505F0" },
                    { "097E9CF0-793B-48E0-B851-D2DDB882ABB3", "5d56bd1d-8bf7-4c2c-8b55-984186650386", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "B8C63411-A600-B238-E734-E0F4FDD505F0" },
                    { "05378CE6-F765-4FC7-9F95-3B6E47633CFA", "00000000-0000-0000-0000-000000000000", new DateTime(2020, 4, 15, 12, 30, 0, 0, DateTimeKind.Unspecified), "Main", new DateTime(2020, 4, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 4, 15, 15, 30, 0, 0, DateTimeKind.Unspecified), null, true, null, "B8C63411-A600-B238-E734-E0F4FDD505F0" },
                    { "5253DA99-5E44-44C8-ADDE-86FD48731810", "00000000-0000-0000-0000-000000000000", new DateTime(2020, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), "Main", new DateTime(2020, 4, 16, 10, 30, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), null, true, null, "B8C63411-A600-B238-E734-E0F4FDD505F0" }
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
                name: "IX_Comments_DriverOfferId",
                table: "Comments",
                column: "DriverOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TripId",
                table: "Comments",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

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
                name: "IX_Preferences_UserId",
                table: "Preferences",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RiderRequests_AddressId",
                table: "RiderRequests",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_RiderRequests_TripId",
                table: "RiderRequests",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_RiderRequests_UserId",
                table: "RiderRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DepartureAddressId",
                table: "Trips",
                column: "DepartureAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DestinationAddressId",
                table: "Trips",
                column: "DestinationAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DriverOfferId",
                table: "Trips",
                column: "DriverOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_TripUsers_TripId",
                table: "TripUsers",
                column: "TripId");

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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Preferences");

            migrationBuilder.DropTable(
                name: "RiderRequests");

            migrationBuilder.DropTable(
                name: "TripUsers");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "DriverOffers");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
