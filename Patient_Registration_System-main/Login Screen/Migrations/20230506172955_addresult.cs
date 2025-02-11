using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_Registration_System.Migrations
{
    /// <inheritdoc />
    public partial class Addresult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ModuleCode",
                table: "Results",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Results",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "grade",
                table: "Results",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModuleCode",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "Results");
        }
    }
}
