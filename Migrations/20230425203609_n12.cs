using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stomatology.Migrations
{
    /// <inheritdoc />
    public partial class n12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Procedure_Doctors_DoctorId",
                table: "Doctor_Procedure");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Procedure_Procedures_ProcedureId",
                table: "Doctor_Procedure");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor_Procedure",
                table: "Doctor_Procedure");

            migrationBuilder.RenameTable(
                name: "Doctor_Procedure",
                newName: "Doctors_Procedures");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_Procedure_DoctorId",
                table: "Doctors_Procedures",
                newName: "IX_Doctors_Procedures_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors_Procedures",
                table: "Doctors_Procedures",
                columns: new[] { "ProcedureId", "DoctorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Procedures_Doctors_DoctorId",
                table: "Doctors_Procedures",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Procedures_Procedures_ProcedureId",
                table: "Doctors_Procedures",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Procedures_Doctors_DoctorId",
                table: "Doctors_Procedures");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Procedures_Procedures_ProcedureId",
                table: "Doctors_Procedures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors_Procedures",
                table: "Doctors_Procedures");

            migrationBuilder.RenameTable(
                name: "Doctors_Procedures",
                newName: "Doctor_Procedure");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_Procedures_DoctorId",
                table: "Doctor_Procedure",
                newName: "IX_Doctor_Procedure_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor_Procedure",
                table: "Doctor_Procedure",
                columns: new[] { "ProcedureId", "DoctorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Procedure_Doctors_DoctorId",
                table: "Doctor_Procedure",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Procedure_Procedures_ProcedureId",
                table: "Doctor_Procedure",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
