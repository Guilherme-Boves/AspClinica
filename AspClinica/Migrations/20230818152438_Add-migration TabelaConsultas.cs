using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspClinica.Migrations
{
    /// <inheritdoc />
    public partial class AddmigrationTabelaConsultas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    ConsultaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PacienteId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PsicologoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HorarioInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioFinal = table.Column<DateTime>(type: "datetime2", nullable: false)
                    // outras colunas relevantes para as consultas
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.ConsultaId);
                    table.ForeignKey(
                        name: "FK_Consultas_Usuarios_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict); // Pode ser Cascade também, dependendo da lógica de exclusão
                    table.ForeignKey(
                        name: "FK_Consultas_Usuarios_PsicologoId",
                        column: x => x.PsicologoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict); // Pode ser Cascade também, dependendo da lógica de exclusão
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultas");
        }
    }
}
