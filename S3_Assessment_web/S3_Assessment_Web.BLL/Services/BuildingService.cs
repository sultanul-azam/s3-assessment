using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.BLL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.BLL.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;

        public BuildingService(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public void AddBuilding(Building building)
        {
            _applicationUnitOfWork.BuildingRepository.Add(building);
            _applicationUnitOfWork.Complete();
        }

        public async Task<IList<Building>> GetAllBuildingsAsync()
        {
            return await _applicationUnitOfWork.BuildingRepository.GetAllAsync();
        }
    }
}
