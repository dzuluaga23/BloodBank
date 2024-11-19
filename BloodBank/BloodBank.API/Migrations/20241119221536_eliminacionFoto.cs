using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBank.API.Migrations
{
    /// <inheritdoc />
    public partial class eliminacionFoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Donantes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Donantes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
