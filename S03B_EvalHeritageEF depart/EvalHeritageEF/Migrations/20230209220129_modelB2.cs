using Microsoft.EntityFrameworkCore.Migrations;

namespace EvalHeritageEF.Migrations
{
    public partial class modelB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehiculeB2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicencePlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicule_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NbrVoile = table.Column<int>(type: "int", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Couleur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbrPassagers = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculeB2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehiculeB2");
        }
    }
}
