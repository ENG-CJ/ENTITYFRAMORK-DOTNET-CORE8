using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libraries.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePublishedYearColumnType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

            // Add the PublishedYear column again as an int
            migrationBuilder.AddColumn<int>(
                name: "PublishedYear",
                table: "Books",
                nullable: false,
                defaultValue: 0); // Use a default value to prevent errors

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
