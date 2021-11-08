﻿using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Domain.Entities.Data
{
    public class Face : AuditableEntity
    {
        [Key]
        public int FaceId { get; set; }
        public string QRcode { get; set; }
        //[Column("ATemp")]
        //public string Temperature { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string cardNum { get; set; }
        public string certificateNumber { get; set; }
        public int certificateType { get; set; }
        public string commonUuid { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string groupId { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public string orgimg { get; set; }
        public string personId { get; set; }
        public string personUuid { get; set; }
        public string phone { get; set; }
        [Column("Temperature")]
        public float temperature { get; set; }
        public string temperatureAlarm { get; set; }
        public int timestamp { get; set; }
        public int trackId { get; set; }
        public string userId { get; set; }
        public int LogId { get; set; }
        public ScanLogs ScanLogs { get; set; }
    }
}