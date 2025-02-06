using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT15_HRMS.Migrations
{
    /// <inheritdoc />
    public partial class MyFirstMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "infos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_infos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infos");
        }
    }
}
