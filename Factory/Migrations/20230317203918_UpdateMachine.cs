using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class UpdateMachine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers");

            migrationBuilder.DropIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Engineers");

            migrationBuilder.UpdateData(
                table: "Engineers",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Engineers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Engineers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Engineers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId");
        }
    }
}
