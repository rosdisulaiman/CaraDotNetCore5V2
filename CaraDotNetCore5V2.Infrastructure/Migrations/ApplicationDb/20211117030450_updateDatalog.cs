using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaraDotNetCore5V2.Infrastructure.Migrations.ApplicationDb
{
    public partial class updateDatalog : Migration
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
                    time = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    timelocal = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LoggedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QRcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    cardNum = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    certificateNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    certificateType = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    commonUuid = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    groupId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orgimg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    personUuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    temperature = table.Column<float>(type: "real", nullable: true),
                    temperatureAlarm = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    timestamp = table.Column<int>(type: "int", nullable: true),
                    trackId = table.Column<int>(type: "int", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScanLogs",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    camid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devmac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    @event = table.Column<string>(name: "event", type: "nvarchar(max)", nullable: true),
                    @operator = table.Column<string>(name: "operator", type: "nvarchar(max)", nullable: true),
                    time = table.Column<int>(type: "int", nullable: false),
                    timelocal = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoggedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScanLogs", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Face",
                columns: table => new
                {
                    FaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QRcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    cardNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    certificateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    certificateType = table.Column<int>(type: "int", nullable: false),
                    commonUuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    groupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orgimg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personUuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperature = table.Column<float>(type: "real", nullable: false),
                    temperatureAlarm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    timestamp = table.Column<int>(type: "int", nullable: false),
                    trackId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogId = table.Column<int>(type: "int", nullable: false),
                    ScanLogsLogId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Face", x => x.FaceId);
                    table.ForeignKey(
                        name: "FK_Face_ScanLogs_ScanLogsLogId",
                        column: x => x.ScanLogsLogId,
                        principalTable: "ScanLogs",
                        principalColumn: "LogId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Face_ScanLogsLogId",
                table: "Face",
                column: "ScanLogsLogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataLogs");

            migrationBuilder.DropTable(
                name: "Face");

            migrationBuilder.DropTable(
                name: "ScanLogs");
        }
    }
}
