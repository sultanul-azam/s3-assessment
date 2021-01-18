using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S3_Assessment_Web.ViewModels.ViewModels
{
    public class SearchModel
    {
        public int? BuildingId { get; set; }
        public int? ObjectId { get; set; }
        public int? DateFieldId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
