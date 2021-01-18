using S3_Assessment_Web.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace S3_Assessment_Web.BLL.Entities
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }       
        public IList<Reading> BuildingReadings { get; set; }
    }
}
