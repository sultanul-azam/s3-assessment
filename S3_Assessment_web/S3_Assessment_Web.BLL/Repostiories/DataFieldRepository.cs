using S3_Assessment_Web.BLL.Contexts;
using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace S3_Assessment_Web.BLL.Repostiories
{    
    public class DataFieldRepository : Repository<DataField, ApplicationDbContext>, IDataFieldRepository
    {
        public DataFieldRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
