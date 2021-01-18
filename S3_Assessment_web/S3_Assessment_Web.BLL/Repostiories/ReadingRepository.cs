using Microsoft.EntityFrameworkCore;
using S3_Assessment_Web.BLL.Contexts;
using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.DAL.Repositories;
using S3_Assessment_Web.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.BLL.Repostiories
{    
    public class ReadingRepository : Repository<Reading, ApplicationDbContext>, IReadingRepository
    {
        
        public ReadingRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
           
        }

        public async Task<List<ReadingViewModel>> GetReadingsAsync(SearchModel searchCriteria)
        {
            var readingDbSet = _dbContext.Readings.AsQueryable();

            if (searchCriteria.BuildingId != null) 
            {
                readingDbSet = readingDbSet.Where(x => x.BuildingId == searchCriteria.BuildingId);
            }

            if (searchCriteria.ObjectId != null)
            {
                readingDbSet = readingDbSet.Where(x => x.ObjectId == searchCriteria.ObjectId);
            }

            if (searchCriteria.DateFieldId != null)
            {
                readingDbSet = readingDbSet.Where(x => x.DataFieldId == searchCriteria.DateFieldId);
            }

            if (searchCriteria.FromDate != null && searchCriteria.ToDate != null)
            {
                readingDbSet = readingDbSet.Where(x => x.Timestamp >= searchCriteria.FromDate && x.Timestamp <= searchCriteria.ToDate);
            }

            var result  = await readingDbSet.Select(x => new ReadingViewModel
            {
                Value = x.Value,
                Timestamp = x.Timestamp
            }).ToListAsync();
           
            return result;
        }
    }
}
