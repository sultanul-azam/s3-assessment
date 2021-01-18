using Microsoft.EntityFrameworkCore;
using S3_Assessment_Web.BLL.Entities;

namespace S3_Assessment_Web.BLL.Contexts
{
    public interface IApplicationDbContext
    {
        DbSet<Building> Buildings { get; set; }
        DbSet<Objects> Objects { get; set; }
        DbSet<DataField> DataFields { get; set; }
        DbSet<Reading> Readings { get; set; }
    }
}
