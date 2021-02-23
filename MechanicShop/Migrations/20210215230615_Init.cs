using Microsoft.EntityFrameworkCore.Migrations;

namespace MechanicShop.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "management",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    management_Name = table.Column<string>(nullable: true),
                    management_Email = table.Column<string>(nullable: true),
                    management_Mobile = table.Column<string>(nullable: true),
                    management_Position = table.Column<string>(nullable: true),
                    management_Contract = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_management", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "management");
        }
    }
}
