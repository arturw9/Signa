using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Signa.Migrations
{
    /// <inheritdoc />
    public partial class AlterAtrbutosPessoa2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "PESSOA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PESSOA",
                table: "PESSOA",
                column: "PESSOA_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PESSOA",
                table: "PESSOA");

            migrationBuilder.RenameTable(
                name: "PESSOA",
                newName: "Pessoas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "PESSOA_ID");
        }
    }
}
