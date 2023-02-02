using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinancialTips.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "dda8eaf5-3316-4b47-ab14-cae71fcf1c3c", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "bc529af5-cd43-45b3-a1e9-b916da7ddb8c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "59332dee-bc1c-42eb-ab1b-4e481e0a3dd6", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEHCqKuuzEVVgNJSnomQph5gbV7L0MWoWMckTBwxfKebifQDlKFCojyoyiFk9RZgkBQ==", null, false, "e6c86706-0354-434f-806e-35f90508673d", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "InstrumentDescription", "InstrumentName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 2, 3, 0, 51, 12, 529, DateTimeKind.Local).AddTicks(330), new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(1905), null, "Equity", "System" },
                    { 2, "System", new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2567), new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2571), null, "Futures", "System" },
                    { 3, "System", new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2574), null, "Options", "System" },
                    { 4, "System", new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2576), null, "Commodities", "System" },
                    { 5, "System", new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2578), new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2579), null, "Cryptocurrency", "System" }
                });

            migrationBuilder.InsertData(
                table: "Preferences",
                columns: new[] { "Id", "AverageIncome", "CommitmentPeriod", "CreatedBy", "DateCreated", "DateUpdated", "InvestAmount", "RiskMinMax", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 4750000, 36, "System", new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5888), new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5903), 10000, 30, "System" },
                    { 2, 1750000, 6, "System", new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5907), 350000, 50, "System" },
                    { 3, 6750000, 3, "System", new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5909), new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5910), 670000, 60, "System" },
                    { 4, 3750000, 7, "System", new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5913), 550000, 40, "System" },
                    { 5, 1100000, 10, "System", new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5916), 675000, 70, "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
