using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LaxWebApplication.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    DatePlayed = table.Column<DateTime>(nullable: false),
                    HomeTeam = table.Column<string>(nullable: false),
                    VisitingTeam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "GameEvents",
                columns: table => new
                {
                    EventTime = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActingTeamMemberNumber = table.Column<int>(nullable: false),
                    AssistingTeamMember = table.Column<int>(nullable: false),
                    EventType = table.Column<string>(nullable: true),
                    GamesGuid = table.Column<Guid>(nullable: true),
                    HomeScore = table.Column<int>(nullable: false),
                    PenaltyTime = table.Column<int>(nullable: false),
                    PenaltyType = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: false),
                    VisitorScore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameEvents", x => x.EventTime);
                    table.ForeignKey(
                        name: "FK_GameEvents_Games_GamesGuid",
                        column: x => x.GamesGuid,
                        principalTable: "Games",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameEvents_GamesGuid",
                table: "GameEvents",
                column: "GamesGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameEvents");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
