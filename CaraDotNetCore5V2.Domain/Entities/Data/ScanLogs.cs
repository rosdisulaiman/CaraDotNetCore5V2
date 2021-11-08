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
    public class ScanLogs : AuditableEntity
    {
        [Key]
        public int LogId { get; set; }
        public string camid { get; set; }
        public string devid { get; set; }
        public string devmac { get; set; }
        public string devname { get; set; }
        public string devno { get; set; }
        [Column("event")]
        public string _event { get; set; }
        public List<Face> Faces { get; set; }
        [Column("operator")]
        public string Operator { get; set; }
        public int time { get; set; }
        public int timelocal { get; set; }
        public string type { get; set; }
        public DateTime LoggedTime { get; set; } = DateTime.Now;
    }
}
