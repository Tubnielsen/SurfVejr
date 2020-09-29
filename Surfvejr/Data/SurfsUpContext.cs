using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Surfvejr.Models;

namespace Surfvejr.Data
{
    public class SurfsUpContext : DbContext
    {
        public SurfsUpContext (DbContextOptions<SurfsUpContext> options)
            : base(options)
        {

        }

        public DbSet<SurfSpot> SurfSpots { get; set; }
        public DbSet<SpotData> SpotData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SurfSpot>().ToTable("Surf_spot");
            modelBuilder.Entity<SpotData>().ToTable("Spot_data");
        }
    }
}
