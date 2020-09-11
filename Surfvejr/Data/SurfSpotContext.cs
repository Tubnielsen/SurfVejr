using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Surfvejr.Models;

namespace Surfvejr.Data
{
    public class SurfSpotContext : DbContext
    {
        public SurfSpotContext (DbContextOptions<SurfSpotContext> options)
            : base(options)
        {

        }

        public DbSet<SurfSpot> SurfSpots { get; set; }
    }
}
