using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Domain.Entities.Data
{
    public class DataLog
    {
        public int Id { get; set; }

        //[StringLength(20, MinimumLength = 5, ErrorMessage = "Use 5-20 characters")]
        public string camid { get; set; }

        //[StringLength(20, MinimumLength = 5, ErrorMessage = "Use 5-20 characters")]
        public string devid { get; set; }

        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Use 5-100 characters")]
        public string devname { get; set; }
        public string? devno { get; set; }

        //public int time { get; set; }
        //public int timelocal { get; set; }
        public DateTimeOffset time { get; set; }
        public DateTimeOffset timelocal { get; set; }
        public DateTime LoggedTime { get; set; }

        [StringLength(50)]
        public string QRcode { get; set; }
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Use 5-100 characters")]
        public string name { get; set; }

        //[StringLength(250, MinimumLength = 5, ErrorMessage = "Use 5-250 characters")]
        public string? address { get; set; }
        public int? age { get; set; }

        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Use 5-100 characters")]
        public string? cardNum { get; set; }

        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Use 5-100 characters")]
        public string? certificateNumber { get; set; }

        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Use 5-100 characters")]
        public int? certificateType { get; set; }

        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Use 5-100 characters")]
        public string? commonUuid { get; set; }

        [DataType(DataType.EmailAddress)]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Use 5-100 characters")]
        public string? email { get; set; }

        //[StringLength(20, MinimumLength = 5, ErrorMessage = "Use 5-20 characters")]
        public string? gender { get; set; }

        //[StringLength(50, MinimumLength = 5, ErrorMessage = "Use 5-20 characters")]
        public string? groupId { get; set; }
        public string image { get; set; }
        public string orgimg { get; set; }

        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Use 5-100 characters")]
        public string? personId { get; set; }
        
        public string? personUuid { get; set; }
        
        public string? phone { get; set; }
        
        public float? temperature { get; set; }

        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Use 5-100 characters")]
        public string? temperatureAlarm { get; set; }
        public int? timestamp { get; set; }
        public int? trackId { get; set; }

        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Use 5-100 characters")]
        public string userId { get; set; }


    }
}
