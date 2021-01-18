using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.BLL.Services
{
    public interface IReadingService
    {
        Task<IList<Reading>> GetAllAsync();
        void Add (Reading reading);

        public Task<List<List<double>>> GetReadingsAsync(SearchModel searchCriteria);
    }
}
