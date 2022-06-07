using Microsoft.EntityFrameworkCore.Migrations;

namespace BootstrapMentor.Migrations
{
    public partial class RemoveTittleColumnToCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tittle",
                table: "Courses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tittle",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
