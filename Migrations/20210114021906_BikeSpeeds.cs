using Microsoft.EntityFrameworkCore.Migrations;

namespace Kiss_Andrei_Proiect.Migrations
{
    public partial class BikeSpeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BikeSpeeds",
                table: "Bikes",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BikeSpeeds",
                table: "Bikes");
        }
    }
}
