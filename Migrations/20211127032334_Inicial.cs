using Microsoft.EntityFrameworkCore.Migrations;

namespace Entrenamiento_Bateo.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bateadores",
                columns: table => new
                {
                    BateadorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    PorcentajeBateo = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeRecta = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeCurva = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeCambio = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeSlider = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeNudillo = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeHits = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeHitsRectas = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeHitsCurvas = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeHitsSliders = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeHitsCambios = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeHitsNudillos = table.Column<double>(type: "REAL", nullable: false),
                    BolasLanzadas = table.Column<double>(type: "REAL", nullable: false),
                    BolasBateadas = table.Column<double>(type: "REAL", nullable: false),
                    RectasLanzadas = table.Column<double>(type: "REAL", nullable: false),
                    CurvasLanzadas = table.Column<double>(type: "REAL", nullable: false),
                    SlidersLanzados = table.Column<double>(type: "REAL", nullable: false),
                    CambiosLanzados = table.Column<double>(type: "REAL", nullable: false),
                    NudillosLanzados = table.Column<double>(type: "REAL", nullable: false),
                    Hits = table.Column<double>(type: "REAL", nullable: false),
                    HitsRectas = table.Column<double>(type: "REAL", nullable: false),
                    HitsCurvas = table.Column<double>(type: "REAL", nullable: false),
                    HitsSliders = table.Column<double>(type: "REAL", nullable: false),
                    HitsCambios = table.Column<double>(type: "REAL", nullable: false),
                    HitsNudillos = table.Column<double>(type: "REAL", nullable: false),
                    Fouls = table.Column<double>(type: "REAL", nullable: false),
                    Afeccion = table.Column<double>(type: "REAL", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: true),
                    RectasBateadas = table.Column<double>(type: "REAL", nullable: false),
                    CurvasBateadas = table.Column<double>(type: "REAL", nullable: false),
                    SlidersBateadas = table.Column<double>(type: "REAL", nullable: false),
                    CambiosBateados = table.Column<double>(type: "REAL", nullable: false),
                    NudillosBateados = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bateadores", x => x.BateadorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bateadores");
        }
    }
}
