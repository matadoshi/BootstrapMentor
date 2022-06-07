using Microsoft.EntityFrameworkCore.Migrations;

namespace BootstrapMentor.Migrations
{
    public partial class AddSurnameColumnToTrainerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Trainers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Trainers");
        }
    }
}
