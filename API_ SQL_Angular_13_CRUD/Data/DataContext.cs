using Microsoft.EntityFrameworkCore;

namespace API__SQL_Angular_13_CRUD.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Inspection> Inspections { get; set; }

        public DbSet<InspectionType> InspectionTypes { get; set; }

        public DbSet<Status> Statuses { get; set; }
    }
}
