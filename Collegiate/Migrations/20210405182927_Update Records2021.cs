using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Collegiate.Migrations
{
    public partial class UpdateRecords2021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "267ECF2D-E9E0-EC5A-BA50-0F78C452AEEE",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "1eece235-1581-47d0-80cf-2f33d47f22be", "4225a7a1-e63e-4f2d-b7bc-a24b7ff89dc8", new DateTime(2021, 4, 5, 14, 29, 27, 90, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3344C500-2985-D75D-1E1A-AB1E13F554EF",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "8fe195dd-1556-4df6-8512-91a1a5ba73e1", "bed043e7-fd8d-4c64-aec9-bd8d9f3ce915", new DateTime(2021, 4, 5, 14, 29, 27, 90, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "339ACF0D-CCCB-C231-298F-CA948C00BCD6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "610f7e8f-b0c7-4eae-83fa-ebf22ac1e245", "a8a15845-7238-4f54-a2c8-06edd3c6e099", new DateTime(2021, 4, 5, 14, 29, 27, 90, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4B941445-7EA2-BB82-5913-D87BE1CB1768",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "b1884ae8-80c2-4c55-9553-62deeea1b9e2", "1095a79b-80bb-4235-9797-40ab206aaf07", new DateTime(2021, 4, 5, 14, 29, 27, 90, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55D5ADBB-50F6-E6BF-905F-2D72E4105231",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "cde4befa-afd4-4af6-a46a-f09add7bb840", "e55fc615-4b87-4ae1-b599-38106cbc09d4", new DateTime(2021, 4, 5, 14, 29, 27, 90, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56D6F8FA-A0F5-5EAA-351E-29A7A8DD8627",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "beb246ec-0650-4dd6-b4e1-4078428d8936", "c3dfc2d9-500d-4141-bdf8-58996bf11119", new DateTime(2021, 4, 5, 14, 29, 27, 90, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "897978AF-644E-40D1-1D47-60E19C08CBDD",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "3893fdd8-23b5-4249-a3f0-0e22960bc3e9", "cd15310f-c095-4817-a7b7-5b69f3ca666b", new DateTime(2021, 4, 5, 14, 29, 27, 90, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B8C63411-A600-B238-E734-E0F4FDD505F0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "e1d7bcf9-4995-4354-ac40-ed950fe162b9", "0ea751c6-9ca3-4eb0-ab8b-d4460b04373e", new DateTime(2021, 4, 5, 14, 29, 27, 90, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "33e66e34-3067-40fc-acd6-bb13dc52410b", "849ca9ab-c91c-4fad-ab4b-3a57abe97dca", new DateTime(2021, 4, 5, 14, 29, 27, 86, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DDD1ADD9-5AD9-33FC-FB9B-C901B27D232A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "51651ef5-d227-469e-8d66-5a570f23cab9", "be8748f1-593a-4992-99a7-f60a3e6c3803", new DateTime(2021, 4, 5, 14, 29, 27, 90, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "1d0dfb0d-efdc-48eb-bc77-2c5b8520e5b0",
                column: "ArrivalTime",
                value: new DateTime(2021, 4, 23, 17, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "26d39cb7-4b4d-4e99-860f-1465277e3adc",
                column: "ArrivalTime",
                value: new DateTime(2021, 4, 23, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "30836417-2d86-4fe2-b8b3-cbc964d8f46b",
                column: "ArrivalTime",
                value: new DateTime(2021, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "3bf8d706-472e-4497-b4e6-111fb4ebf24c",
                column: "ArrivalTime",
                value: new DateTime(2021, 4, 15, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "4661cc56-b9cf-4704-9553-894aae98436a",
                column: "ArrivalTime",
                value: new DateTime(2021, 4, 16, 16, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "6357d0f6-463a-44ba-887b-0648b6ba33dc",
                column: "ArrivalTime",
                value: new DateTime(2021, 4, 17, 22, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "a87df131-18b8-4762-9d24-dc6e679458ba",
                column: "ArrivalTime",
                value: new DateTime(2021, 4, 17, 14, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "adf3fbad-0ed9-4a9d-880b-1e8b2271bcdb",
                column: "ArrivalTime",
                value: new DateTime(2021, 4, 22, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "b17c6728-1008-4ebb-b39c-57a41f490b24",
                column: "ArrivalTime",
                value: new DateTime(2021, 4, 15, 17, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "c4436384-9cd1-453c-8880-30e1de5c71aa",
                column: "ArrivalTime",
                value: new DateTime(2021, 4, 22, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RiderRequests",
                keyColumn: "RiderRequestId",
                keyValue: "05378CE6-F765-4FC7-9F95-3B6E47633CFA",
                column: "DepartureTime",
                value: new DateTime(2021, 4, 15, 10, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RiderRequests",
                keyColumn: "RiderRequestId",
                keyValue: "097E9CF0-793B-48E0-B851-D2DDB882ABB3",
                column: "DepartureTime",
                value: new DateTime(2021, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RiderRequests",
                keyColumn: "RiderRequestId",
                keyValue: "5253DA99-5E44-44C8-ADDE-86FD48731810",
                column: "DepartureTime",
                value: new DateTime(2021, 4, 16, 10, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RiderRequests",
                keyColumn: "RiderRequestId",
                keyValue: "F87EB0B8-F687-41FB-8973-D5211B01ACD3",
                column: "DepartureTime",
                value: new DateTime(2021, 4, 15, 15, 30, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "267ECF2D-E9E0-EC5A-BA50-0F78C452AEEE",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "0a0af034-6faf-4496-a525-95cea3798c38", "33c47454-a560-4c52-b446-8853c890ba98", new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3344C500-2985-D75D-1E1A-AB1E13F554EF",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "c6fa86aa-f078-4786-9220-b4f1cfe73235", "d45d442f-f935-49d1-b07e-91ae50b50376", new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "339ACF0D-CCCB-C231-298F-CA948C00BCD6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "0a307fe9-6e14-4ad6-b5bd-7e689e8221e8", "01fa33d5-6451-479c-a25a-406246f75512", new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4B941445-7EA2-BB82-5913-D87BE1CB1768",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "4dcef05e-722f-45b4-a48e-d5a047517dd2", "0bfa7e40-1df8-4a80-8d76-99b6f1b821b5", new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55D5ADBB-50F6-E6BF-905F-2D72E4105231",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "bea1ed4f-040a-480a-9c18-11e768a0c4de", "4d825967-481a-4790-b910-1527974f7fd4", new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56D6F8FA-A0F5-5EAA-351E-29A7A8DD8627",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "d16533d4-490c-4500-950f-be58ddc5f154", "c19bbe1a-2b2f-4aeb-8841-9296f83ce15b", new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "897978AF-644E-40D1-1D47-60E19C08CBDD",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "a3c8224b-277d-44d0-b6bc-2726bc9eae3b", "526cacd0-7357-44fb-a6c1-cb48e94e5b76", new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B8C63411-A600-B238-E734-E0F4FDD505F0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "1d1a2bd2-a8a9-4be6-a520-db65ea861588", "aab2ee67-0ae0-4f66-bcff-119075441601", new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "b9c1044e-23e2-492e-a0f0-01d68a021172", "8c089565-5109-40b6-b250-b144060f6675", new DateTime(2021, 3, 11, 21, 19, 59, 123, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DDD1ADD9-5AD9-33FC-FB9B-C901B27D232A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "650a4c3f-e9ea-4e21-bfe2-ff981e39be1a", "f4533877-3735-4828-8426-1e8458334ff6", new DateTime(2021, 3, 11, 21, 19, 59, 127, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "1d0dfb0d-efdc-48eb-bc77-2c5b8520e5b0",
                column: "ArrivalTime",
                value: new DateTime(2020, 4, 23, 17, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "26d39cb7-4b4d-4e99-860f-1465277e3adc",
                column: "ArrivalTime",
                value: new DateTime(2020, 4, 23, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "30836417-2d86-4fe2-b8b3-cbc964d8f46b",
                column: "ArrivalTime",
                value: new DateTime(2020, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "3bf8d706-472e-4497-b4e6-111fb4ebf24c",
                column: "ArrivalTime",
                value: new DateTime(2020, 4, 15, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "4661cc56-b9cf-4704-9553-894aae98436a",
                column: "ArrivalTime",
                value: new DateTime(2020, 4, 16, 16, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "6357d0f6-463a-44ba-887b-0648b6ba33dc",
                column: "ArrivalTime",
                value: new DateTime(2020, 4, 17, 22, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "a87df131-18b8-4762-9d24-dc6e679458ba",
                column: "ArrivalTime",
                value: new DateTime(2020, 4, 17, 14, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "adf3fbad-0ed9-4a9d-880b-1e8b2271bcdb",
                column: "ArrivalTime",
                value: new DateTime(2020, 4, 22, 12, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "b17c6728-1008-4ebb-b39c-57a41f490b24",
                column: "ArrivalTime",
                value: new DateTime(2020, 4, 15, 17, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DriverOffers",
                keyColumn: "DriverOfferId",
                keyValue: "c4436384-9cd1-453c-8880-30e1de5c71aa",
                column: "ArrivalTime",
                value: new DateTime(2020, 4, 22, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RiderRequests",
                keyColumn: "RiderRequestId",
                keyValue: "05378CE6-F765-4FC7-9F95-3B6E47633CFA",
                column: "DepartureTime",
                value: new DateTime(2020, 4, 15, 10, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RiderRequests",
                keyColumn: "RiderRequestId",
                keyValue: "097E9CF0-793B-48E0-B851-D2DDB882ABB3",
                column: "DepartureTime",
                value: new DateTime(2020, 4, 16, 13, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RiderRequests",
                keyColumn: "RiderRequestId",
                keyValue: "5253DA99-5E44-44C8-ADDE-86FD48731810",
                column: "DepartureTime",
                value: new DateTime(2020, 4, 16, 10, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RiderRequests",
                keyColumn: "RiderRequestId",
                keyValue: "F87EB0B8-F687-41FB-8973-D5211B01ACD3",
                column: "DepartureTime",
                value: new DateTime(2020, 4, 15, 15, 30, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
