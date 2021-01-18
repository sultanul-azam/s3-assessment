using System;
using System.Collections.Generic;
using System.Text;

namespace S3_Assessment_Web.DAL.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        void Complete();
    }
}
