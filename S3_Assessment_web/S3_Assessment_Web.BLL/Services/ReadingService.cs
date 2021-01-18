using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.BLL.UnitOfWorks;
using S3_Assessment_Web.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.BLL.Services
{
    public class ReadingService : IReadingService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;

        public ReadingService(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public void Add(Reading reading)
        {
            _applicationUnitOfWork.ReadingRepository.Add(reading);
            _applicationUnitOfWork.Complete();
        }

        public async Task<IList<Reading>> GetAllAsync()
        {
            return await _applicationUnitOfWork.ReadingRepository.GetAllAsync();
        }

        public async Task<List<List<double>>> GetReadingsAsync(SearchModel searchCriteria)
        {
            var data = await _applicationUnitOfWork.ReadingRepository.GetReadingsAsync(searchCriteria);

            var finalResult = data.ConvertAll(x => new List<double> {
                (x.Timestamp - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds,  
                Convert.ToDouble(x.Value)
            });

            return finalResult;
        }
    }
}
