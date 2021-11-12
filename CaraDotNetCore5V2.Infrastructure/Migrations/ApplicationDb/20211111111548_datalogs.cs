using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaraDotNetCore5V2.Infrastructure.Migrations.ApplicationDb
{
    public partial class datalogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    camid = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    devid = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    devmac = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    devname = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    devno = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    time = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    timelocal = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    type = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LoggedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QRcode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    cardNum = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    certificateNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    certificateType = table.Column<int>(type: "int", nullable: false),
                    commonUuid = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(75)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    groupId = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    orgimg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personId = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    personUuid = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    temperature = table.Column<float>(type: "real", nullable: false),
                    temperatureAlarm = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    timestamp = table.Column<int>(type: "int", nullable: false),
                    trackId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(50)", nullable: true)
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
