using S3_Assessment_Web.BLL.Contexts;
using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.BLL.Repostiories
{
    public interface IBuildingRepository : IRepository<Building, ApplicationDbContext>
    {
        Task<IList<Building>> GetAllBuildingsAsync();
    }
}
