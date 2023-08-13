using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApi.Migrations
{
    /// <inheritdoc />
    public partial class blogapis2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Blog",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "ShortDesc",
                table: "Blog",
                newName: "shortDesc");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Blog",
                newName: "desc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "Blog",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "shortDesc",
                table: "Blog",
                newName: "ShortDesc");

            migrationBuilder.RenameColumn(
                name: "desc",
                table: "Blog",
                newName: "Desc");
        }
    }
}
