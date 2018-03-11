using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laxProject
{
    public class gameEventsModel

    {
        //Initializes the required fields in the Database
        [Required]
        public String team { get; set; }
        public int actingTeamMemberNumber { get; set; }
        public int assistingTeamMemberNumber { get; set; }
        public String eventType { get; set; }
        public int homeScore { get; set; }
        public int visitorScore { get; set; }
        public String penaltyType { get; set; }
        public int penaltyTime { get; set; }
        public DateTime eventTime { get; set; }

        //Initializes the primary key in the Database
        [Key]
        public int eventTime { get; set; }

        //Default Constructor
        public gameEventsModel()
        {

        }

        //Full Constructor
        public gameEventsModel(String team, int actingTeamMemberNumber, int assistingTeamMemberNumber,
            String eventType, int homeScore, int visitorScore, String penaltyType, int penaltyTime, DateTime eventTime)
        {
            this.team = team;
            this.actingTeamMemberNumber = actingTeamMemberNumber;
            this.assistingTeamMemberNumber = assistingTeamMemberNumber;
            this.eventType = eventType;
            this.homeScore = homeScore;
            this.visitorScore = visitorScore;
            this.penaltyType = penaltyType;
            this.penaltyTime = penaltyTime;
            this.eventTime = eventTime;
        }
    }
}
