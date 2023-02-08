using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinancialTips.Server.Data.Migrations
{
    public partial class AddesNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Customers_CustomerID",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Plans_PlanId",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Plans_Customers_CustomerID",
                table: "Plans");

            migrationBuilder.DropForeignKey(
                name: "FK_Plans_Instruments_InstrumentID",
                table: "Plans");

            migrationBuilder.DropForeignKey(
                name: "FK_Plans_Preferences_PreferenceID",
                table: "Plans");

            migrationBuilder.AlterColumn<int>(
                name: "PreferenceID",
                table: "Plans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InstrumentID",
                table: "Plans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Plans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CustName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlanId",
                table: "Consultations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Consultations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "7f86ed73-37fb-4110-9c5f-d2d970c8ea5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "166d6d4c-1c30-47ba-bc82-3c5e0cf1df69");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb35a1d2-c9ce-4e1c-8a29-f8841c109ec9", "AQAAAAEAACcQAAAAEIhcg51znAKYIp5e4wN+p8ybZJIGyD4O4Uh1aLavSfJuWVVAC3PLxVkue+ACJudBHg==", "0baacce1-89c9-410c-9001-fb2b7222eec4" });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 6, 26, 0, 926, DateTimeKind.Local).AddTicks(8673), new DateTime(2023, 2, 9, 6, 26, 0, 928, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 6, 26, 0, 928, DateTimeKind.Local).AddTicks(1032), new DateTime(2023, 2, 9, 6, 26, 0, 928, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 6, 26, 0, 928, DateTimeKind.Local).AddTicks(1037), new DateTime(2023, 2, 9, 6, 26, 0, 928, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 6, 26, 0, 928, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 2, 9, 6, 26, 0, 928, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 6, 26, 0, 928, DateTimeKind.Local).AddTicks(1045), new DateTime(2023, 2, 9, 6, 26, 0, 928, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 6, 26, 0, 929, DateTimeKind.Local).AddTicks(4818), new DateTime(2023, 2, 9, 6, 26, 0, 929, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 6, 26, 0, 929, DateTimeKind.Local).AddTicks(4835), new DateTime(2023, 2, 9, 6, 26, 0, 929, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 6, 26, 0, 929, DateTimeKind.Local).AddTicks(4838), new DateTime(2023, 2, 9, 6, 26, 0, 929, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 6, 26, 0, 929, DateTimeKind.Local).AddTicks(4841), new DateTime(2023, 2, 9, 6, 26, 0, 929, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 6, 26, 0, 929, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 2, 9, 6, 26, 0, 929, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Customers_CustomerID",
                table: "Consultations",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Plans_PlanId",
                table: "Consultations",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plans_Customers_CustomerID",
                table: "Plans",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plans_Instruments_InstrumentID",
                table: "Plans",
                column: "InstrumentID",
                principalTable: "Instruments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plans_Preferences_PreferenceID",
                table: "Plans",
                column: "PreferenceID",
                principalTable: "Preferences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Customers_CustomerID",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Plans_PlanId",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Plans_Customers_CustomerID",
                table: "Plans");

            migrationBuilder.DropForeignKey(
                name: "FK_Plans_Instruments_InstrumentID",
                table: "Plans");

            migrationBuilder.DropForeignKey(
                name: "FK_Plans_Preferences_PreferenceID",
                table: "Plans");

            migrationBuilder.AlterColumn<int>(
                name: "PreferenceID",
                table: "Plans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstrumentID",
                table: "Plans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Plans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "PlanId",
                table: "Consultations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Consultations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "dda8eaf5-3316-4b47-ab14-cae71fcf1c3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "bc529af5-cd43-45b3-a1e9-b916da7ddb8c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59332dee-bc1c-42eb-ab1b-4e481e0a3dd6", "AQAAAAEAACcQAAAAEHCqKuuzEVVgNJSnomQph5gbV7L0MWoWMckTBwxfKebifQDlKFCojyoyiFk9RZgkBQ==", "e6c86706-0354-434f-806e-35f90508673d" });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 51, 12, 529, DateTimeKind.Local).AddTicks(330), new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2567), new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2578), new DateTime(2023, 2, 3, 0, 51, 12, 530, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5888), new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5909), new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Preferences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 2, 3, 0, 51, 12, 531, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Customers_CustomerID",
                table: "Consultations",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Plans_PlanId",
                table: "Consultations",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plans_Customers_CustomerID",
                table: "Plans",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plans_Instruments_InstrumentID",
                table: "Plans",
                column: "InstrumentID",
                principalTable: "Instruments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plans_Preferences_PreferenceID",
                table: "Plans",
                column: "PreferenceID",
                principalTable: "Preferences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
