using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Signa.Migrations
{
    /// <inheritdoc />
    public partial class AlterAtrbutosPessoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeFantasia",
                table: "Pessoas",
                newName: "NOME_FANTASIA");

            migrationBuilder.RenameColumn(
                name: "CnpjCpf",
                table: "Pessoas",
                newName: "CNPJ_CPF");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "Pessoas",
                newName: "PESSOA_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NOME_FANTASIA",
                table: "Pessoas",
                newName: "NomeFantasia");

            migrationBuilder.RenameColumn(
                name: "CNPJ_CPF",
                table: "Pessoas",
                newName: "CnpjCpf");

            migrationBuilder.RenameColumn(
                name: "PESSOA_ID",
                table: "Pessoas",
                newName: "PessoaId");
        }
    }
}
