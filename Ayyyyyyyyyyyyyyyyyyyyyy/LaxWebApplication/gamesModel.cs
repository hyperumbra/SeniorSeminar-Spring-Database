using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laxWebApplication
{
    public class gamesModel

    {
        //Initializes the required fields in the Database
        [Required]
        public String homeTeam { get; set; }
        public String visitingTeam { get; set; }
        public DateTime datePlayed { get; set; }
        //public Guid gameCode { get; set; }

        //Initializes the primary key in the Database
        [Key]
        public Guid gameCode { get; set; }

        //Default Constructor
        public gamesModel()
        {

        }

        //Full Constructor
        public gamesModel(String homeTeam, String visitingTeam, DateTime datePlayed, String gameCode)
        {
            this.homeTeam = homeTeam;
            this.visitingTeam = visitingTeam;
            this.datePlayed = datePlayed;
            //this.gameCode = gameCode;
        }
    }
}