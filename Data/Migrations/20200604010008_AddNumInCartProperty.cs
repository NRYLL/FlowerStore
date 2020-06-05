using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerStore.Data.Migrations
{
    public partial class AddNumInCartProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumInCart",
                table: "Flower",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumInCart",
                table: "Flower");
        }
    }
}
