using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_EF_Session14.Data
{
    internal class ApplicationDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=DEPI_EF_Session14;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        // =============================================================================
        //                E-commerce Database Context
        // =============================================================================

        public DbSet<Domain.E_commerce.Customer> Customers { get; set; }
        public DbSet<Domain.E_commerce.Order> Orders { get; set; }
        public DbSet<Domain.E_commerce.OrderDetail> OrderDetails { get; set; }
        public DbSet<Domain.E_commerce.Product> Products { get; set; }
        public DbSet<Domain.E_commerce.Category> Categories { get; set; }

        // =============================================================================
        //               Library System Database Context
        // =============================================================================
        public DbSet<Domain.Libaray_System.Borrower> Borrowers { get; set; }
        public DbSet<Domain.Libaray_System.Book> Books { get; set; }
        public DbSet<Domain.Libaray_System.Loan> Loans { get; set; }
        public DbSet<Domain.Libaray_System.Author> Authors { get; set; }
        // =============================================================================
        //               Health Care System Database Context
        // =============================================================================
        public DbSet<Domain.Health_Care_System.Patient> Patients { get; set; }
        public DbSet<Domain.Health_Care_System.Doctor> Doctors { get; set; }
        public DbSet<Domain.Health_Care_System.Appointment> Appointments { get; set; }





    }
}
