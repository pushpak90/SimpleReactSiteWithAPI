using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API8.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Forms",
                table: "Forms");

            migrationBuilder.RenameTable(
                name: "Forms",
                newName: "TBL_Prospect");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_Prospect",
                table: "TBL_Prospect",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_Prospect",
                table: "TBL_Prospect");

            migrationBuilder.RenameTable(
                name: "TBL_Prospect",
                newName: "Forms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forms",
                table: "Forms",
                column: "Id");
        }
    }
}
