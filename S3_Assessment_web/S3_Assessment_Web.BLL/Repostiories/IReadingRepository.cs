using S3_Assessment_Web.BLL.Contexts;
using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.DAL.Repositories;
using S3_Assessment_Web.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.BLL.Repostiories
{
    public interface IReadingRepository : IRepository<Reading, ApplicationDbContext>
    {
        public Task<List<ReadingViewModel>> GetReadingsAsync(SearchModel searchCriteria);
        
    }
}
