using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerStore.Data.Migrations
{
    public partial class AddDescriptionToFlowerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Flower",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Flower");
        }
    }
}
