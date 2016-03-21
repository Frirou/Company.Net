using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CompanyData.Configurations;
using CompanyDomain.Entities;

namespace CompanyData
{
    public partial class CompanyDBContext : DbContext
    {
        static CompanyDBContext()
        {
            Database.SetInitializer<CompanyDBContext>(null);
        }

        public CompanyDBContext()
            : base("Name=CompanyDBContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }
    }
}
