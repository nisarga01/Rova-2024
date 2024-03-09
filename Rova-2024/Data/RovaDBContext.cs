using Microsoft.EntityFrameworkCore;
using Rova_2024.Models;
using System.Collections.Generic;

namespace Rova_2024.Data
{
    public class RovaDBContext : DbContext
    {
        public RovaDBContext(DbContextOptions<RovaDBContext> options) : base(options) { }

        public DbSet<SellerCommercialDetails> SellerCommercialDetails { get; set; } = default!;
        public DbSet<Sellers> Sellers { get; set; } = default;

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<SellerCommercialDetails>()
        //        .HasOne(s => s.Sellers)               // Navigation property
        //        .WithOne()                          // One-to-one relationship
        //        .HasForeignKey<SellerCommercialDetails>(s => s.Seller_Id);  // Foreign key property
        //}

    }
}
