using Autofac;
using S3_Assessment_Web.BLL.Contexts;
using S3_Assessment_Web.BLL.Repostiories;
using S3_Assessment_Web.BLL.Services;
using S3_Assessment_Web.BLL.UnitOfWorks;
using System;

namespace S3_Assessment_Web.BLL
{
    public class BusinessModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public BusinessModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<BuildingRepository>().As<IBuildingRepository>().InstancePerLifetimeScope();
            builder.RegisterType<ObjectsRepository>().As<IObjectsRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DataFieldRepository>().As<IDataFieldRepository>().InstancePerLifetimeScope();
            builder.RegisterType<ReadingRepository>().As<IReadingRepository>().InstancePerLifetimeScope();

            builder.RegisterType<BuildingService>().As<IBuildingService>().InstancePerLifetimeScope();
            builder.RegisterType<ObjectsService>().As<IObjectsService>().InstancePerLifetimeScope();
            builder.RegisterType<DataFieldService>().As<IDataFieldService>().InstancePerLifetimeScope();
            builder.RegisterType<ReadingService>().As<IReadingService>().InstancePerLifetimeScope();

            builder.RegisterType<ApplicationUnitOfWork>().As<IApplicationUnitOfWork>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
