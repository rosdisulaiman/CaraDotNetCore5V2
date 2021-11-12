using Microsoft.EntityFrameworkCore.Migrations;

namespace CaraDotNetCore5V2.Infrastructure.Migrations.ApplicationDb
{
    public partial class AddViewDbSql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                create view ViewDataLog1 as
                SELECT distinct [Id]
					,[LogId]
                      ,[camid]
                      ,[devid]
                      ,[devname]
                      ,[devno]
                      ,dateadd(s,[time],'19700101 8:00:00:00') as time
                      ,dateadd(s,[timelocal],'19700101 8:00:00:00') as timelocal
                      ,[LoggedTime]
                      ,[QRcode]
                      ,[name]
                      ,[address]
                      ,[age]
                      ,[cardNum]
                      ,[certificateNumber]
                      ,[certificateType]
                      ,[commonUuid]
                      ,[email]
                      ,[gender]
                      ,[groupId]
                      ,[image]
                      ,[orgimg]
                      ,[personId]
                      ,[personUuid]
                      ,[phone]
                      ,[temperature]
                      ,[temperatureAlarm]
                      ,[timestamp]
                      ,[trackId]
                      ,[userId]
                  FROM [CaraDotNetCore5V2].[dbo].[DataLogs]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" drop view ViewDataLog1; ");
        }
    }
}
