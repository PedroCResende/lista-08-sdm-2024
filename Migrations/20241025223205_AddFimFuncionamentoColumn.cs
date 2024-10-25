using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaApi.Migrations
{
    /// <inheritdoc />
    public partial class AddFimFuncionamentoColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FimFuncionamento",
                table: "Bibliotecas");

            migrationBuilder.DropColumn(
                name: "InicioFuncionamento",
                table: "Bibliotecas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Inauguracao",
                table: "Bibliotecas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fim_Funcionamento",
                table: "Bibliotecas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inicio_Funcionamento",
                table: "Bibliotecas",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fim_Funcionamento",
                table: "Bibliotecas");

            migrationBuilder.DropColumn(
                name: "Inicio_Funcionamento",
                table: "Bibliotecas");

            migrationBuilder.AlterColumn<string>(
                name: "Inauguracao",
                table: "Bibliotecas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "FimFuncionamento",
                table: "Bibliotecas",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "InicioFuncionamento",
                table: "Bibliotecas",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
