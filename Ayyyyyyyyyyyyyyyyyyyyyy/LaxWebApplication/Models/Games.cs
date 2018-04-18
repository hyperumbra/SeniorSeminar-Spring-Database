using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaxWebApplication.Models
{
    public class Games
    {
        [Required]
        public String HomeTeam { get; set; }
        public String VisitingTeam { get; set; }
        public DateTime DatePlayed { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public virtual List<GameEvents> GameEventsList { get; set; }
        public Games()
        {
            GameEventsList = new List<GameEvents>();
        }
    }
}
