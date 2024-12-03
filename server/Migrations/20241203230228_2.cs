using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gfa.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RatingId",
                table: "Person",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlayerPace = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerShot = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerPass = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerDribling = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerDefense = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerPhysique = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerGoalkeeping = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonTeam",
                columns: table => new
                {
                    PeopleId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTeam", x => new { x.PeopleId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_PersonTeam_Person_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonTeam_Team_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TournamentTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TournamentTable_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_RatingId",
                table: "Person",
                column: "RatingId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonTeam_TeamsId",
                table: "PersonTeam",
                column: "TeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentTable_TeamId",
                table: "TournamentTable",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Rating_RatingId",
                table: "Person",
                column: "RatingId",
                principalTable: "Rating",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Rating_RatingId",
                table: "Person");

            migrationBuilder.DropTable(
                name: "PersonTeam");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "TournamentTable");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Person_RatingId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "RatingId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Person");
        }
    }
}
