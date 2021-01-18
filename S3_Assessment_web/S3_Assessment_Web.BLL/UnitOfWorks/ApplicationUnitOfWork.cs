using S3_Assessment_Web.BLL.Contexts;
using S3_Assessment_Web.BLL.Repostiories;
using S3_Assessment_Web.BLL.UnitOfWorks;
using S3_Assessment_Web.DAL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace S3_Assessment_Web.BLL.UnitOfWorks
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {    
        public IBuildingRepository BuildingRepository { get; set ; }
        public IObjectsRepository ObjectsRepository { get; set; }
        public IDataFieldRepository DataFieldRepository { get; set; }
        public IReadingRepository ReadingRepository { get; set; }

        public ApplicationUnitOfWork(ApplicationDbContext context, IBuildingRepository buildingRepository, IObjectsRepository objectsRepository, IDataFieldRepository dataFieldRepository, IReadingRepository readingRepository) : base(context)
        {
            BuildingRepository = buildingRepository;
            ObjectsRepository = objectsRepository;
            DataFieldRepository = dataFieldRepository;
            ReadingRepository = readingRepository;
        }
    }
}
