using Microsoft.EntityFrameworkCore.Migrations;

namespace EvalHeritageEF.Migrations
{
    public partial class modelD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehiculeD",
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
                    table.PrimaryKey("PK_VehiculeD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BateauD",
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
                    table.PrimaryKey("PK_BateauD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BateauD_VehiculeD_Id",
                        column: x => x.Id,
                        principalTable: "VehiculeD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VoitureD",
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
                    table.PrimaryKey("PK_VoitureD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoitureD_VehiculeD_Id",
                        column: x => x.Id,
                        principalTable: "VehiculeD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BateauD");

            migrationBuilder.DropTable(
                name: "VoitureD");

            migrationBuilder.DropTable(
                name: "VehiculeD");
        }
    }
}
