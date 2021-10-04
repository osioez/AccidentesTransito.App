using Microsoft.EntityFrameworkCore.Migrations;

namespace AccidentesTransito.App.Persistencia.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_Agente_AgenteId",
                table: "Accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Accidente_Barrio_BarrioId",
                table: "Accidente");

            migrationBuilder.DropForeignKey(
                name: "FK_Peaton_Accidente_AccidenteId",
                table: "Peaton");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Accidente_AccidenteId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Conductor_ConductorId",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_TipoVehiculo_TipoVehiculoId",
                table: "Vehiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculo",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_AccidenteId",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_ConductorId",
                table: "Vehiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoVehiculo",
                table: "TipoVehiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peaton",
                table: "Peaton");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conductor",
                table: "Conductor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Barrio",
                table: "Barrio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agente",
                table: "Agente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accidente",
                table: "Accidente");

            migrationBuilder.DropColumn(
                name: "AccidenteId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "ConductorId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "CondutorEsPropietario",
                table: "Vehiculo");

            migrationBuilder.RenameTable(
                name: "Vehiculo",
                newName: "Vehiculos");

            migrationBuilder.RenameTable(
                name: "TipoVehiculo",
                newName: "TiposVehiculos");

            migrationBuilder.RenameTable(
                name: "Peaton",
                newName: "Peatones");

            migrationBuilder.RenameTable(
                name: "Conductor",
                newName: "Conductores");

            migrationBuilder.RenameTable(
                name: "Barrio",
                newName: "Barrios");

            migrationBuilder.RenameTable(
                name: "Agente",
                newName: "Agentes");

            migrationBuilder.RenameTable(
                name: "Accidente",
                newName: "Accidentes");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculo_TipoVehiculoId",
                table: "Vehiculos",
                newName: "IX_Vehiculos_TipoVehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Peaton_AccidenteId",
                table: "Peatones",
                newName: "IX_Peatones_AccidenteId");

            migrationBuilder.RenameIndex(
                name: "IX_Accidente_BarrioId",
                table: "Accidentes",
                newName: "IX_Accidentes_BarrioId");

            migrationBuilder.RenameIndex(
                name: "IX_Accidente_AgenteId",
                table: "Accidentes",
                newName: "IX_Accidentes_AgenteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposVehiculos",
                table: "TiposVehiculos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peatones",
                table: "Peatones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conductores",
                table: "Conductores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Barrios",
                table: "Barrios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agentes",
                table: "Agentes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accidentes",
                table: "Accidentes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accidentes_Agentes_AgenteId",
                table: "Accidentes",
                column: "AgenteId",
                principalTable: "Agentes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accidentes_Barrios_BarrioId",
                table: "Accidentes",
                column: "BarrioId",
                principalTable: "Barrios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Peatones_Accidentes_AccidenteId",
                table: "Peatones",
                column: "AccidenteId",
                principalTable: "Accidentes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_TiposVehiculos_TipoVehiculoId",
                table: "Vehiculos",
                column: "TipoVehiculoId",
                principalTable: "TiposVehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidentes_Agentes_AgenteId",
                table: "Accidentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Accidentes_Barrios_BarrioId",
                table: "Accidentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Peatones_Accidentes_AccidenteId",
                table: "Peatones");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_TiposVehiculos_TipoVehiculoId",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposVehiculos",
                table: "TiposVehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peatones",
                table: "Peatones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conductores",
                table: "Conductores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Barrios",
                table: "Barrios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agentes",
                table: "Agentes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accidentes",
                table: "Accidentes");

            migrationBuilder.RenameTable(
                name: "Vehiculos",
                newName: "Vehiculo");

            migrationBuilder.RenameTable(
                name: "TiposVehiculos",
                newName: "TipoVehiculo");

            migrationBuilder.RenameTable(
                name: "Peatones",
                newName: "Peaton");

            migrationBuilder.RenameTable(
                name: "Conductores",
                newName: "Conductor");

            migrationBuilder.RenameTable(
                name: "Barrios",
                newName: "Barrio");

            migrationBuilder.RenameTable(
                name: "Agentes",
                newName: "Agente");

            migrationBuilder.RenameTable(
                name: "Accidentes",
                newName: "Accidente");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_TipoVehiculoId",
                table: "Vehiculo",
                newName: "IX_Vehiculo_TipoVehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Peatones_AccidenteId",
                table: "Peaton",
                newName: "IX_Peaton_AccidenteId");

            migrationBuilder.RenameIndex(
                name: "IX_Accidentes_BarrioId",
                table: "Accidente",
                newName: "IX_Accidente_BarrioId");

            migrationBuilder.RenameIndex(
                name: "IX_Accidentes_AgenteId",
                table: "Accidente",
                newName: "IX_Accidente_AgenteId");

            migrationBuilder.AddColumn<int>(
                name: "AccidenteId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConductorId",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CondutorEsPropietario",
                table: "Vehiculo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculo",
                table: "Vehiculo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoVehiculo",
                table: "TipoVehiculo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peaton",
                table: "Peaton",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conductor",
                table: "Conductor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Barrio",
                table: "Barrio",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agente",
                table: "Agente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accidente",
                table: "Accidente",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_AccidenteId",
                table: "Vehiculo",
                column: "AccidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_ConductorId",
                table: "Vehiculo",
                column: "ConductorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_Agente_AgenteId",
                table: "Accidente",
                column: "AgenteId",
                principalTable: "Agente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accidente_Barrio_BarrioId",
                table: "Accidente",
                column: "BarrioId",
                principalTable: "Barrio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Peaton_Accidente_AccidenteId",
                table: "Peaton",
                column: "AccidenteId",
                principalTable: "Accidente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Accidente_AccidenteId",
                table: "Vehiculo",
                column: "AccidenteId",
                principalTable: "Accidente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Conductor_ConductorId",
                table: "Vehiculo",
                column: "ConductorId",
                principalTable: "Conductor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_TipoVehiculo_TipoVehiculoId",
                table: "Vehiculo",
                column: "TipoVehiculoId",
                principalTable: "TipoVehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
