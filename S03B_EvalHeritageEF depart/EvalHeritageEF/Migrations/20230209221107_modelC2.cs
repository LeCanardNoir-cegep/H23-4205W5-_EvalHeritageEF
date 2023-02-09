using Microsoft.EntityFrameworkCore.Migrations;

namespace EvalHeritageEF.Migrations
{
    public partial class modelC2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehiculeC2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicencePlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculeC2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BateauC2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NbrVoile = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longueur = table.Column<int>(type: "int", nullable: false),
                    PiloteAutomatique = table.Column<bool>(type: "bit", nullable: false),
                    NbrMats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BateauC2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BateauC2_VehiculeC2_Id",
                        column: x => x.Id,
                        principalTable: "VehiculeC2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VoitureC2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Couleur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbrPassagers = table.Column<int>(type: "int", nullable: false),
                    NbrVitesses = table.Column<int>(type: "int", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CameraRecule = table.Column<bool>(type: "bit", nullable: false),
                    BoiteManuelle = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoitureC2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoitureC2_VehiculeC2_Id",
                        column: x => x.Id,
                        principalTable: "VehiculeC2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BateauC2");

            migrationBuilder.DropTable(
                name: "VoitureC2");

            migrationBuilder.DropTable(
                name: "VehiculeC2");
        }
    }
}
