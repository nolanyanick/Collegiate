using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Collegiate.Migrations
{
    public partial class modelUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "00000000-0000-0000-0000-000000000000",
                column: "Type",
                value: "Campus");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "0343fbc8-a866-4e7e-aaf6-b095f12a70ce",
                column: "Type",
                value: "Residence");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "2abc4f72-8a6c-4419-ac65-465b229ae5a4",
                column: "Type",
                value: "MeetingPlace");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "5d56bd1d-8bf7-4c2c-8b55-984186650386",
                column: "Type",
                value: "MeetingPlace");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "7070fb2e-76b3-4e1c-808e-836fd5668cbe",
                column: "Type",
                value: "Residence");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "96308717-4d4c-46ed-8e58-51412d5d9645",
                column: "Type",
                value: "MeetingPlace");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "267ECF2D-E9E0-EC5A-BA50-0F78C452AEEE",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "eb382331-219a-434c-8a9d-7fec45e097df", "184ad3ab-8324-4ef7-bbb1-407299a9594a", new DateTime(2020, 4, 14, 16, 18, 45, 213, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3344C500-2985-D75D-1E1A-AB1E13F554EF",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "b0b790c1-d946-49d2-8920-135c9f7b0109", "45cbfe93-8944-43f7-bd54-1b496f6ff625", new DateTime(2020, 4, 14, 16, 18, 45, 213, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "339ACF0D-CCCB-C231-298F-CA948C00BCD6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "bc35247c-a2d5-45d0-b69a-5cb8d898eff5", "c721932d-f6e6-4ad1-bba1-e9312ec4a016", new DateTime(2020, 4, 14, 16, 18, 45, 213, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4B941445-7EA2-BB82-5913-D87BE1CB1768",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "dfb18e94-331f-421d-999d-18a4d2627575", "9ad89b24-9188-4496-8ac1-1af80b71c81f", new DateTime(2020, 4, 14, 16, 18, 45, 213, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55D5ADBB-50F6-E6BF-905F-2D72E4105231",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "70ad10f4-400d-4141-be9a-a1ad8455803b", "65300544-06f8-4c50-84ab-fb8dad2ac794", new DateTime(2020, 4, 14, 16, 18, 45, 213, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56D6F8FA-A0F5-5EAA-351E-29A7A8DD8627",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "650d0f71-e206-4af7-83b3-e9462e11738e", "4f38cc6c-ba01-45f2-8b93-a58687f84aba", new DateTime(2020, 4, 14, 16, 18, 45, 213, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "897978AF-644E-40D1-1D47-60E19C08CBDD",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "b6d01393-1c90-4a00-b7b2-92885342b577", "2b246bce-97d4-431d-99c0-ac56be313410", new DateTime(2020, 4, 14, 16, 18, 45, 213, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B8C63411-A600-B238-E734-E0F4FDD505F0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "528bf37c-f8f6-4b0d-9499-c70e0204a91e", "81651db2-a2d7-40f9-9d25-c5df35d74807", new DateTime(2020, 4, 14, 16, 18, 45, 213, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "f1b75dde-a8be-4547-9d82-0b6a86412e56", "9036d538-2808-4af0-bd0d-2ccc39107639", new DateTime(2020, 4, 14, 16, 18, 45, 210, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DDD1ADD9-5AD9-33FC-FB9B-C901B27D232A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "0d6b1515-33a5-4bd4-b736-904627fc96be", "50353471-eef5-4d0a-9de0-4a7b85e69dfd", new DateTime(2020, 4, 14, 16, 18, 45, 213, DateTimeKind.Local).AddTicks(3220) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Addresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "00000000-0000-0000-0000-000000000000",
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "0343fbc8-a866-4e7e-aaf6-b095f12a70ce",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "2abc4f72-8a6c-4419-ac65-465b229ae5a4",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "5d56bd1d-8bf7-4c2c-8b55-984186650386",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "7070fb2e-76b3-4e1c-808e-836fd5668cbe",
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: "96308717-4d4c-46ed-8e58-51412d5d9645",
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "267ECF2D-E9E0-EC5A-BA50-0F78C452AEEE",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "d8de02c8-5c43-44e3-bb19-a949aab32a08", "e5809476-3959-495c-85ac-6bece48a1642", new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3344C500-2985-D75D-1E1A-AB1E13F554EF",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "bcf33b0e-e225-4457-8d04-038a5a9d02e1", "0e047457-0bb3-4415-b469-f68f216af405", new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "339ACF0D-CCCB-C231-298F-CA948C00BCD6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "4e84fa28-2217-4a90-b32e-3e80efced8b6", "f59b2e60-db5e-40c1-9b05-f833bf414e7c", new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4B941445-7EA2-BB82-5913-D87BE1CB1768",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "28e53e3d-935e-4501-b2f3-3e7c7b526f34", "55f0e195-1433-4d6f-b044-3eb8589cde79", new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55D5ADBB-50F6-E6BF-905F-2D72E4105231",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "b9a443e2-8935-4c78-b209-b1b4341bb923", "64a3fd4b-1a28-4355-ba3b-4e5c9e5bc89c", new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56D6F8FA-A0F5-5EAA-351E-29A7A8DD8627",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "db489dbd-07c4-4fe0-bdc4-8816d22915a6", "630b8255-63b1-46cd-add2-b5a4a5fd6cb0", new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "897978AF-644E-40D1-1D47-60E19C08CBDD",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "0f941700-86e6-4d82-b2b6-183b2d0d93aa", "ec58ed21-c5d6-4bd2-bd7a-397451aa74be", new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B8C63411-A600-B238-E734-E0F4FDD505F0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "ccd17be3-ea50-4e3b-ba58-45cbde0ba3d6", "7efd977f-a4a3-4a5e-8635-24a04c85196a", new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFF12317-DB43-B3AC-7AA4-3A8DB536ED64",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "d045b521-7ee0-498c-bb4c-f76b474b69b5", "4de6351b-b02a-4e8b-8a37-1662a5a8e36f", new DateTime(2020, 4, 13, 18, 43, 49, 578, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DDD1ADD9-5AD9-33FC-FB9B-C901B27D232A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UpdatedOn" },
                values: new object[] { "166624c9-4a9a-400b-9db0-03105a20b3b1", "891ebd70-b36c-4944-b46e-1727cc6e49db", new DateTime(2020, 4, 13, 18, 43, 49, 581, DateTimeKind.Local).AddTicks(6360) });
        }
    }
}
