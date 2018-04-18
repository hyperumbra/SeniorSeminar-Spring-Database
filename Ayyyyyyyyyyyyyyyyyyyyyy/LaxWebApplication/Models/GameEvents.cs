using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaxWebApplication.Models
{
    public class GameEvents
    {
        [Required]
        public String Team { get; set;   }
        public String EventType { get; set; }
        public String PenaltyType { get; set; }
        public int ActingTeamMemberNumber { get; set; }
        public int AssistingTeamMember { get; set; }
        public int HomeScore { get; set; }
        public int VisitorScore { get; set; }
        public int PenaltyTime { get; set; }

        [Key]
        public int EventTime { get; set; }
    }
}
