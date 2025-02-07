using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT15_HRMS.Migrations
{
    /// <inheritdoc />
    public partial class AddPTOAndEmployeeLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Infos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    FN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LN = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    MD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infos", x => x.Id);
                });
        }
    }
}
