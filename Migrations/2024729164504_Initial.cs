using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentInformation.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    marks1 = table.Column<int>(type: "int", nullable: false),
                    marks2 = table.Column<int>(type: "int", nullable: false),
                    marks3 = table.Column<int>(type: "int", nullable: false),
                    marks4 = table.Column<int>(type: "int", nullable: false),
                    marks5 = table.Column<int>(type: "int", nullable: false),
                    marks6 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
