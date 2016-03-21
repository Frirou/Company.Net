using CompanyDomain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CompanyData.Configurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FirstName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .HasMaxLength(50);

            this.Property(t => t.DaytimePhone)
                .HasMaxLength(50);

            this.Property(t => t.EmailAddress)
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .HasMaxLength(50);

            this.Property(t => t.CompanyManager)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Customers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.DaytimePhone).HasColumnName("DaytimePhone");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.CompanyManager).HasColumnName("CompanyManager");
            this.Property(t => t.IsCompany).HasColumnName("IsCompany");
        }
    }
}
