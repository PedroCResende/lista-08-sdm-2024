using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaApi.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InicioFuncionamento",
                table: "Bibliotecas",
                newName: "Inicio_Funcionamento");

            migrationBuilder.RenameColumn(
                name: "FimFuncionamento",
                table: "Bibliotecas",
                newName: "Fim_Funcionamento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Inicio_Funcionamento",
                table: "Bibliotecas",
                newName: "InicioFuncionamento");

            migrationBuilder.RenameColumn(
                name: "Fim_Funcionamento",
                table: "Bibliotecas",
                newName: "FimFuncionamento");
        }
    }
}
