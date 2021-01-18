using S3_Assessment_Web.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S3_Assessment_Web.BLL.Services
{
    public interface IDataFieldService 
    {
        Task<IList<DataField>> GetAllAsync();
        void Add (DataField dataField);
    }
}
