using EF6DataBase.Model;
using System.Data.Entity;

namespace EF6DataBase
{
    public class EFDBContext : DbContext
    {
        public EFDBContext():base("name=ConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFDBContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
