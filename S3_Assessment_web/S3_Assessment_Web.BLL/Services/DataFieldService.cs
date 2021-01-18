using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.BLL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.BLL.Services
{
    public class DataFieldService : IDataFieldService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public DataFieldService(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }
        public void Add(DataField dataField)
        {
            _applicationUnitOfWork.DataFieldRepository.Add(dataField);
            _applicationUnitOfWork.Complete();
        }

        public async Task<IList<DataField>> GetAllAsync()
        {
            return await _applicationUnitOfWork.DataFieldRepository.GetAllAsync();
        }
    }
}
