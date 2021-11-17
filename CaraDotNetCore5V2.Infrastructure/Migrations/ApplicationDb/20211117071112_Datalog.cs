using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaraDotNetCore5V2.Infrastructure.Migrations.ApplicationDb
{
    public partial class Datalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogId = table.Column<int>(type: "int", nullable: true),
                    camid = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    devid = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    devname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    devno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time = table.Column<int>(type: "int", nullable: true),
                    timelocal = table.Column<int>(type: "int", nullable: true),
                    LoggedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QRcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    cardNum = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    certificateNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    certificateType = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    commonUuid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    groupId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orgimg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    personUuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    temperature = table.Column<float>(type: "real", nullable: true),
                    temperatureAlarm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    timestamp = table.Column<int>(type: "int", nullable: true),
                    trackId = table.Column<int>(type: "int", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataLogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataLogs");
        }
    }
}
