using Microsoft.EntityFrameworkCore.Migrations;

namespace AccidentesTransito.App.Persistencia.Migrations
{
    public partial class TerceraMigracion0310 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peatones_Accidentes_AccidenteId",
                table: "Peatones");

            migrationBuilder.DropIndex(
                name: "IX_Peatones_AccidenteId",
                table: "Peatones");

            migrationBuilder.DropColumn(
                name: "AccidenteId",
                table: "Peatones");

            migrationBuilder.CreateTable(
                name: "AccidenteConductorVehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccidenteId = table.Column<int>(type: "int", nullable: true),
                    ConductorId = table.Column<int>(type: "int", nullable: true),
                    VehiculoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccidenteConductorVehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccidenteConductorVehiculo_Accidentes_AccidenteId",
                        column: x => x.AccidenteId,
                        principalTable: "Accidentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccidenteConductorVehiculo_Conductores_ConductorId",
                        column: x => x.ConductorId,
                        principalTable: "Conductores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccidenteConductorVehiculo_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccidentePeaton",
                columns: table => new
                {
                    AccidentesId = table.Column<int>(type: "int", nullable: false),
                    PeatonesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccidentePeaton", x => new { x.AccidentesId, x.PeatonesId });
                    table.ForeignKey(
                        name: "FK_AccidentePeaton_Accidentes_AccidentesId",
                        column: x => x.AccidentesId,
                        principalTable: "Accidentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccidentePeaton_Peatones_PeatonesId",
                        column: x => x.PeatonesId,
                        principalTable: "Peatones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccidenteConductorVehiculo_AccidenteId",
                table: "AccidenteConductorVehiculo",
                column: "AccidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_AccidenteConductorVehiculo_ConductorId",
                table: "AccidenteConductorVehiculo",
                column: "ConductorId");

            migrationBuilder.CreateIndex(
                name: "IX_AccidenteConductorVehiculo_VehiculoId",
                table: "AccidenteConductorVehiculo",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_AccidentePeaton_PeatonesId",
                table: "AccidentePeaton",
                column: "PeatonesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccidenteConductorVehiculo");

            migrationBuilder.DropTable(
                name: "AccidentePeaton");

            migrationBuilder.AddColumn<int>(
                name: "AccidenteId",
                table: "Peatones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Peatones_AccidenteId",
                table: "Peatones",
                column: "AccidenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peatones_Accidentes_AccidenteId",
                table: "Peatones",
                column: "AccidenteId",
                principalTable: "Accidentes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
