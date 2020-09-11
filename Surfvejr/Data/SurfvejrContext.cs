using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Surfvejr.Models;

namespace Surfvejr.Data
{
    public class SurfvejrContext : DbContext
    {
        public SurfvejrContext (DbContextOptions<SurfvejrContext> options)
            : base(options)
        {
        }

        public DbSet<Surfvejr.Models.SurfSpot> SurfSpot { get; set; }
    }
}
