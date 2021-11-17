using Microsoft.EntityFrameworkCore.Migrations;

namespace CaraDotNetCore5V2.Infrastructure.Migrations.ApplicationDb
{
    public partial class Datalogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogId",
                table: "DataLogs");

            migrationBuilder.AlterColumn<int>(
                name: "timelocal",
                table: "DataLogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "time",
                table: "DataLogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "timelocal",
                table: "DataLogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "time",
                table: "DataLogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LogId",
                table: "DataLogs",
                type: "int",
                nullable: true);
        }
    }
}
