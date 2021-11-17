using AspNetCoreHero.Abstractions.Domain;
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



        public int attrAge { get; set; }
        public int attrBeauty { get; set; }
        public string attrExpression { get; set; }
        public string attrEye { get; set; }
        public string attrGender { get; set; }
        public string attrGlass { get; set; }
        public string attrMouth { get; set; }
        public string attrMustache { get; set; }
        public string attrSkinColor { get; set; }
        public string attrSmile { get; set; }
        public string authType { get; set; }
        public int bgHeight { get; set; }
        public int bgWidth { get; set; }
        public double blurProb { get; set; }
        public string cap { get; set; }
        public int coordX0 { get; set; }
        public int coordX1 { get; set; }
        public int coordY0 { get; set; }
        public int coordY1 { get; set; }
        public string debugStage { get; set; }
        public string ethic { get; set; }
        public int frameId { get; set; }
        public double headPitch { get; set; }
        public double headRoll { get; set; }
        public double headYaw { get; set; }
        public int imageX0 { get; set; }
        public int imageX1 { get; set; }
        public int imageY0 { get; set; }
        public int imageY1 { get; set; }
        public string irimg { get; set; }
        public int irimgX0 { get; set; }
        public int irimgX1 { get; set; }
        public int irimgY0 { get; set; }
        public int irimgY1 { get; set; }
        public int liveness { get; set; }
        public string plateId { get; set; }
        public string respirator { get; set; }
        public string respiratorLevel { get; set; }
        public double score { get; set; }
        public double similarity { get; set; }
        public string status { get; set; }
    }
}