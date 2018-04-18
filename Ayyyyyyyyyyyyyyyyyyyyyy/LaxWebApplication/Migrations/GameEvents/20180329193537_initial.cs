using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LaxWebApplication.Migrations.GameEvents
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameEvents",
                columns: table => new
                {
                    EventTime = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActingTeamMemberNumber = table.Column<int>(nullable: false),
                    AssistingTeamMember = table.Column<int>(nullable: false),
                    EventType = table.Column<string>(nullable: true),
                    HomeScore = table.Column<int>(nullable: false),
                    PenaltyTime = table.Column<int>(nullable: false),
                    PenaltyType = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: false),
                    VisitorScore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameEvents", x => x.EventTime);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameEvents");
        }
    }
}
