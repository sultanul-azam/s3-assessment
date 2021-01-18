using S3_Assessment_Web.BLL.Contexts;
using S3_Assessment_Web.BLL.Entities;
using S3_Assessment_Web.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace S3_Assessment_Web.BLL.Repostiories
{
    public interface IObjectsRepository : IRepository<Objects, ApplicationDbContext>
    {
         
    }
}
