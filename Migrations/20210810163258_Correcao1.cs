using Microsoft.EntityFrameworkCore.Migrations;

namespace money.Migrations
{
    public partial class Correcao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Usuario_UsuarioId",
                table: "Contas");

            migrationBuilder.DropForeignKey(
                name: "FK_Finalidades_Usuario_UsuarioId",
                table: "Finalidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Rendas_Usuario_UsuarioId",
                table: "Rendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Usuarios_UsuarioId",
                table: "Contas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Finalidades_Usuarios_UsuarioId",
                table: "Finalidades",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rendas_Usuarios_UsuarioId",
                table: "Rendas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Usuarios_UsuarioId",
                table: "Contas");

            migrationBuilder.DropForeignKey(
                name: "FK_Finalidades_Usuarios_UsuarioId",
                table: "Finalidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Rendas_Usuarios_UsuarioId",
                table: "Rendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Usuario_UsuarioId",
                table: "Contas",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Finalidades_Usuario_UsuarioId",
                table: "Finalidades",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rendas_Usuario_UsuarioId",
                table: "Rendas",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
