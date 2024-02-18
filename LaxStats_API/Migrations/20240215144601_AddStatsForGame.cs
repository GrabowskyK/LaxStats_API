using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaxStatsAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddStatsForGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventGoals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeGoal = table.Column<TimeSpan>(type: "time", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    AssistId = table.Column<int>(type: "int", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventGoals_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventGoals_Players_AssistId",
                        column: x => x.AssistId,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EventGoals_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EventPenalties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeEvent = table.Column<TimeSpan>(type: "time", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    PenaltyType = table.Column<int>(type: "int", nullable: false),
                    TimePenalty = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPenalties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventPenalties_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventPenalties_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FaceOffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q1 = table.Column<int>(type: "int", nullable: false),
                    Q2 = table.Column<int>(type: "int", nullable: false),
                    Q3 = table.Column<int>(type: "int", nullable: false),
                    Q4 = table.Column<int>(type: "int", nullable: false),
                    OverTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaceOffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaceOffs_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groundballs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q1 = table.Column<int>(type: "int", nullable: false),
                    Q2 = table.Column<int>(type: "int", nullable: false),
                    Q3 = table.Column<int>(type: "int", nullable: false),
                    Q4 = table.Column<int>(type: "int", nullable: false),
                    OverTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groundballs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groundballs_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q1 = table.Column<int>(type: "int", nullable: false),
                    Q2 = table.Column<int>(type: "int", nullable: false),
                    Q3 = table.Column<int>(type: "int", nullable: false),
                    Q4 = table.Column<int>(type: "int", nullable: false),
                    OverTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shots_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShotsWides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q1 = table.Column<int>(type: "int", nullable: false),
                    Q2 = table.Column<int>(type: "int", nullable: false),
                    Q3 = table.Column<int>(type: "int", nullable: false),
                    Q4 = table.Column<int>(type: "int", nullable: false),
                    OverTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShotsWides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShotsWides_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timeouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TookTimeout = table.Column<TimeSpan>(type: "time", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timeouts_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventGoals_AssistId",
                table: "EventGoals",
                column: "AssistId");

            migrationBuilder.CreateIndex(
                name: "IX_EventGoals_GameId",
                table: "EventGoals",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_EventGoals_PlayerId",
                table: "EventGoals",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_EventPenalties_GameId",
                table: "EventPenalties",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_EventPenalties_PlayerId",
                table: "EventPenalties",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FaceOffs_GameId",
                table: "FaceOffs",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Groundballs_GameId",
                table: "Groundballs",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Shots_GameId",
                table: "Shots",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_ShotsWides_GameId",
                table: "ShotsWides",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Timeouts_GameId",
                table: "Timeouts",
                column: "GameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventGoals");

            migrationBuilder.DropTable(
                name: "EventPenalties");

            migrationBuilder.DropTable(
                name: "FaceOffs");

            migrationBuilder.DropTable(
                name: "Groundballs");

            migrationBuilder.DropTable(
                name: "Shots");

            migrationBuilder.DropTable(
                name: "ShotsWides");

            migrationBuilder.DropTable(
                name: "Timeouts");
        }
    }
}
