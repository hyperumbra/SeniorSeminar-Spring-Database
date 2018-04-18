using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LaxWebApplication.Models
{
    public class GamesContext : DbContext
    {
        public GamesContext (DbContextOptions<GamesContext> options)
            : base(options)
        {
        }

        public DbSet<LaxWebApplication.Models.Games> Games { get; set; }
    }
}
