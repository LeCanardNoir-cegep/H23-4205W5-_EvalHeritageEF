using Microsoft.EntityFrameworkCore.Migrations;

namespace EvalHeritageEF.Migrations
{
    public partial class modelA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BateauA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NbrVoile = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longueur = table.Column<int>(type: "int", nullable: false),
                    PiloteAutomatique = table.Column<bool>(type: "bit", nullable: false),
                    NbrMats = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicencePlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BateauA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoitureA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Couleur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbrPassagers = table.Column<int>(type: "int", nullable: false),
                    NbrVitesses = table.Column<int>(type: "int", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CameraRecule = table.Column<bool>(type: "bit", nullable: false),
                    BoiteManuelle = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicencePlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoitureA", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BateauA");

            migrationBuilder.DropTable(
                name: "VoitureA");
        }
    }
}
