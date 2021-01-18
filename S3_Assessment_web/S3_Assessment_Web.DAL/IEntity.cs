using System;
using System.Collections.Generic;
using System.Text;

namespace S3_Assessment_Web.DAL
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
