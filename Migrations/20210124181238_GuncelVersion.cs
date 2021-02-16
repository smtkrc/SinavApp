using Microsoft.EntityFrameworkCore.Migrations;

namespace SinavProje.Migrations
{
    public partial class GuncelVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Sorulars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tarih",
                table: "SoruDetays",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Sorulars");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "SoruDetays");
        }
    }
}
