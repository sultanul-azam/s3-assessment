using S3_Assessment_Web.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.BLL.Services
{
    public interface IObjectsService
    {
        Task<IList<Objects>> GetAllAsync();
        void Add(Objects objects);
    }
}
