using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.BLL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.BLL.Services
{
    public class ObjectsService : IObjectsService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public ObjectsService(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public void Add(Objects objects)
        {
            _applicationUnitOfWork.ObjectsRepository.Add(objects);
            _applicationUnitOfWork.Complete();
        }

        public async Task<IList<Objects>> GetAllAsync()
        {
            return await _applicationUnitOfWork.ObjectsRepository.GetAllAsync();
        }
    }
}
