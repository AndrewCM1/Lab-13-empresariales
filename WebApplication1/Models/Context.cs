using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Detail> Details { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Definir relaciones y restricciones aquí si es necesario
        //    modelBuilder.Entity<Invoice>()
        //        .HasOne(i => i.Customer)
        //        .WithMany(c => c.Invoices)
        //        .HasForeignKey(i => i.CustomerId);

        //    modelBuilder.Entity<Detail>()
        //        .HasOne(d => d.Product)
        //        .WithMany(p => p.Details)
        //        .HasForeignKey(d => d.ProductId);

        //    modelBuilder.Entity<Detail>()
        //        .HasOne(d => d.Invoice)
        //        .WithMany(i => i.Details)
        //        .HasForeignKey(d => d.InvoiceId);
        //}
        

    }
}
