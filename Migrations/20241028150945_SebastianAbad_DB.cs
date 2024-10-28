using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SebastianAbad_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class SebastianAbad_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SA_Tabla1",
                columns: table => new
                {
                    SA_CARROID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SA_MecanicosAcargo = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    SA_Modelo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SA_Marca = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SA_Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SA_Gasolina = table.Column<bool>(type: "bit", nullable: false),
                    SA_FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_Tabla1", x => x.SA_CARROID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SA_Tabla1");
        }
    }
}
