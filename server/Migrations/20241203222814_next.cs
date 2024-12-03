using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gfa.Migrations
{
    /// <inheritdoc />
    public partial class next : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Person",
                newName: "Surname");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "Person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Person",
                newName: "Name");
        }
    }
}
