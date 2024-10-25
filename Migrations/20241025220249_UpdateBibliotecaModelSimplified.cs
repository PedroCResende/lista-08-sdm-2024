using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBibliotecaModelSimplified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Inicio_Funcionamento",
                table: "Bibliotecas",
                newName: "InicioFuncionamento");

            migrationBuilder.RenameColumn(
                name: "Fim_Funcionamento",
                table: "Bibliotecas",
                newName: "FimFuncionamento");

            migrationBuilder.AlterColumn<string>(
                name: "Inauguracao",
                table: "Bibliotecas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InicioFuncionamento",
                table: "Bibliotecas",
                newName: "Inicio_Funcionamento");

            migrationBuilder.RenameColumn(
                name: "FimFuncionamento",
                table: "Bibliotecas",
                newName: "Fim_Funcionamento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Inauguracao",
                table: "Bibliotecas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
