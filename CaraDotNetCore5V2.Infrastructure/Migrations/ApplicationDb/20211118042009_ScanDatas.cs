using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaraDotNetCore5V2.Infrastructure.Migrations.ApplicationDb
{
    public partial class ScanDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    camid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    timelocal = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LoggedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QRcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    cardNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    certificateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    certificateType = table.Column<int>(type: "int", nullable: true),
                    commonUuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    groupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orgimg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personUuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    temperature = table.Column<float>(type: "real", nullable: true),
                    temperatureAlarm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    timestamp = table.Column<int>(type: "int", nullable: true),
                    trackId = table.Column<int>(type: "int", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    attrAge = table.Column<int>(type: "int", nullable: false),
                    attrBeauty = table.Column<int>(type: "int", nullable: false),
                    attrExpression = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attrEye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attrGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attrGlass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attrMouth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attrMustache = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attrSkinColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attrSmile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    authType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bgHeight = table.Column<int>(type: "int", nullable: false),
                    bgWidth = table.Column<int>(type: "int", nullable: false),
                    blurProb = table.Column<double>(type: "float", nullable: false),
                    cap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coordX0 = table.Column<int>(type: "int", nullable: false),
                    coordX1 = table.Column<int>(type: "int", nullable: false),
                    coordY0 = table.Column<int>(type: "int", nullable: false),
                    coordY1 = table.Column<int>(type: "int", nullable: false),
                    debugStage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ethic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    frameId = table.Column<int>(type: "int", nullable: false),
                    headPitch = table.Column<double>(type: "float", nullable: false),
                    headRoll = table.Column<double>(type: "float", nullable: false),
                    headYaw = table.Column<double>(type: "float", nullable: false),
                    imageX0 = table.Column<int>(type: "int", nullable: false),
                    imageX1 = table.Column<int>(type: "int", nullable: false),
                    imageY0 = table.Column<int>(type: "int", nullable: false),
                    imageY1 = table.Column<int>(type: "int", nullable: false),
                    irimg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    irimgX0 = table.Column<int>(type: "int", nullable: false),
                    irimgX1 = table.Column<int>(type: "int", nullable: false),
                    irimgY0 = table.Column<int>(type: "int", nullable: false),
                    irimgY1 = table.Column<int>(type: "int", nullable: false),
                    liveness = table.Column<int>(type: "int", nullable: false),
                    plateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    respirator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    respiratorLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    score = table.Column<double>(type: "float", nullable: false),
                    similarity = table.Column<double>(type: "float", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
