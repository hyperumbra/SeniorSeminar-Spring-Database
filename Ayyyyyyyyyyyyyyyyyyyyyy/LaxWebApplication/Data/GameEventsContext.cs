using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LaxWebApplication.Models
{
    public class GameEventsContext : DbContext
    {
        public GameEventsContext (DbContextOptions<GameEventsContext> options)
            : base(options)
        {
        }

        public DbSet<LaxWebApplication.Models.GameEvents> GameEvents { get; set; }
    }
}
