using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW3.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DataOfBirth", "FirstName", "HiredData", "LastName", "OfficeId", "TitleId" },
                values: new object[] { 1, new DateTime(1998, 10, 5, 5, 5, 5, 0, DateTimeKind.Unspecified), ",dw;l", new DateTime(2005, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "dsa", 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1);
        }
    }
}
