using S3_Assessment_Web.BLL.Repostiories;
using S3_Assessment_Web.DAL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace S3_Assessment_Web.BLL.UnitOfWorks
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        IBuildingRepository BuildingRepository { get; set; }
        IObjectsRepository ObjectsRepository { get; set; }
        IDataFieldRepository DataFieldRepository { get; set; }
        IReadingRepository ReadingRepository { get; set; }
    }
}
