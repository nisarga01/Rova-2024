using Microsoft.EntityFrameworkCore;
using Rova_2024.Models;
using System.Collections.Generic;

namespace Rova_2024.Data
{
    public class RovaDBContext : DbContext
    {
        public RovaDBContext(DbContextOptions<RovaDBContext> options) : base(options) { }

        public DbSet<SellersOnboarding> SellerOnboarding { get; set; } = default!;
        public DbSet<Sellers> Sellers { get; set; } = default;
    }
}
