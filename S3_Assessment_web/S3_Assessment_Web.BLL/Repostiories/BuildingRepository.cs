using Microsoft.EntityFrameworkCore;
using S3_Assessment_Web.BLL.Contexts;
using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.BLL.Repostiories
{    
    public class BuildingRepository : Repository<Building, ApplicationDbContext>, IBuildingRepository
    {
        public BuildingRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IList<Building>> GetAllBuildingsAsync()
        {
            return await _dbContext.Buildings.ToListAsync();
        }
    }
}
