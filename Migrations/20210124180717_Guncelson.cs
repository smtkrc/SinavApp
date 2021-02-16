using Microsoft.EntityFrameworkCore.Migrations;

namespace SinavProje.Migrations
{
    public partial class Guncelson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SoruDetays",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoruBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoruMetin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S1A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S1B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S1C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S1D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S2D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S3A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S3B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S3C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S3D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S4A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S4B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S4C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S4D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SC1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SC2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SC3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SC4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoruDetays", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoruDetays");
        }
    }
}
