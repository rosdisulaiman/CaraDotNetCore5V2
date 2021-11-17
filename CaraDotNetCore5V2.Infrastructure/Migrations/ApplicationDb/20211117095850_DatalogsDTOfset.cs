using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaraDotNetCore5V2.Infrastructure.Migrations.ApplicationDb
{
    public partial class DatalogsDTOfset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "timelocal",
                table: "DataLogs",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "time",
                table: "DataLogs",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "timelocal",
                table: "DataLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<int>(
                name: "time",
                table: "DataLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");
        }
    }
}
