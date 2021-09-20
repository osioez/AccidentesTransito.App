using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccidentesTransito.App.Persistencia.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccidenteId",
                table: "Peaton",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Agente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentoIdentidad = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdAgente = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Barrio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barrio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conductor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentoIdentidad = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoLicencia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoVehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accidente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgenteId = table.Column<int>(type: "int", nullable: true),
                    GeoRreferenciaX = table.Column<float>(type: "real", nullable: false),
                    GeoRreferenciaY = table.Column<float>(type: "real", nullable: false),
                    BarrioId = table.Column<int>(type: "int", nullable: true),
                    CantidadLesionados = table.Column<int>(type: "int", nullable: false),
                    CantidadFallecidos = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accidente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accidente_Agente_AgenteId",
                        column: x => x.AgenteId,
                        principalTable: "Agente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accidente_Barrio_BarrioId",
                        column: x => x.BarrioId,
                        principalTable: "Barrio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacidadPasajeros = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<int>(type: "int", nullable: false),
                    TipoVehiculoId = table.Column<int>(type: "int", nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConductorId = table.Column<int>(type: "int", nullable: true),
                    CondutorEsPropietario = table.Column<bool>(type: "bit", nullable: false),
                    AccidenteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Accidente_AccidenteId",
                        column: x => x.AccidenteId,
                        principalTable: "Accidente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Conductor_ConductorId",
                        column: x => x.ConductorId,
                        principalTable: "Conductor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculo_TipoVehiculo_TipoVehiculoId",
                        column: x => x.TipoVehiculoId,
                        principalTable: "TipoVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peaton_AccidenteId",
                table: "Peaton",
                column: "AccidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_AgenteId",
                table: "Accidente",
                column: "AgenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_BarrioId",
                table: "Accidente",
                column: "BarrioId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_AccidenteId",
                table: "Vehiculo",
                column: "AccidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_ConductorId",
                table: "Vehiculo",
                column: "ConductorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_TipoVehiculoId",
                table: "Vehiculo",
                column: "TipoVehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peaton_Accidente_AccidenteId",
                table: "Peaton",
                column: "AccidenteId",
                principalTable: "Accidente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peaton_Accidente_AccidenteId",
                table: "Peaton");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Accidente");

            migrationBuilder.DropTable(
                name: "Conductor");

            migrationBuilder.DropTable(
                name: "TipoVehiculo");

            migrationBuilder.DropTable(
                name: "Agente");

            migrationBuilder.DropTable(
                name: "Barrio");

            migrationBuilder.DropIndex(
                name: "IX_Peaton_AccidenteId",
                table: "Peaton");

            migrationBuilder.DropColumn(
                name: "AccidenteId",
                table: "Peaton");
        }
    }
}
