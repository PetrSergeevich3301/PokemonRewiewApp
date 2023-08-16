using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonRewiewApp.Migrations
{
    /// <inheritdoc />
    public partial class FixedNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Coutrties_CountryId",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coutrties",
                table: "Coutrties");

            migrationBuilder.RenameTable(
                name: "Coutrties",
                newName: "Countries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Countries_CountryId",
                table: "Owners",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Countries_CountryId",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Coutrties");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coutrties",
                table: "Coutrties",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Coutrties_CountryId",
                table: "Owners",
                column: "CountryId",
                principalTable: "Coutrties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
