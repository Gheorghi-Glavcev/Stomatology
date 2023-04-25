using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stomatology.Migrations
{
    /// <inheritdoc />
    public partial class n1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Doctors_DoctorId",
                table: "Procedures");

            migrationBuilder.DropIndex(
                name: "IX_Procedures_DoctorId",
                table: "Procedures");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Procedures");

            migrationBuilder.CreateTable(
                name: "Doctor_Procedure",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    ProcedureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor_Procedure", x => new { x.ProcedureId, x.DoctorId });
                    table.ForeignKey(
                        name: "FK_Doctor_Procedure_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctor_Procedure_Procedures_ProcedureId",
                        column: x => x.ProcedureId,
                        principalTable: "Procedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Procedure_DoctorId",
                table: "Doctor_Procedure",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor_Procedure");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Procedures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_DoctorId",
                table: "Procedures",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Doctors_DoctorId",
                table: "Procedures",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");
        }
    }
}
