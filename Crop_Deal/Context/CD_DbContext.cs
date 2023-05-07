using Crop_Deal.Models;
using Microsoft.EntityFrameworkCore;

namespace Crop_Deal.Context
{
    public class CD_DbContext : DbContext
    {
        public CD_DbContext(DbContextOptions<CD_DbContext> options) : base(options) 
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Crops> Crop { get; set; }
        public DbSet<Crop_Details> Crop_Detail { get; set;}
        public DbSet<Invoice>  Invoices { get; set; }
        public DbSet<Bank_Details> Bank { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
