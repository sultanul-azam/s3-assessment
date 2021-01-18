using S3_Assessment_Web.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace S3_Assessment_Web.BLL.Entities
{    
    public class Reading
    {            
        public Int64 Id { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
        public int ObjectId { get; set; }
        public Objects Objects { get; set; }
        public int DataFieldId { get; set; }
        public DataField DataField { get; set; }
        public Decimal Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
