using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerStore.Data.Migrations
{
    public partial class ModifyImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT[dbo].[Flower] ON
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/African_Violet_Flower.jpg' WHERE[id]=1
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Beach_trio.jpg' WHERE[id]=2
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Brahma_Kamal_Flower.jpg' WHERE[id]=3
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Buddie.jpg' WHERE[id]=4
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/buddy_trio.jpg' WHERE[id]=5
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Celosia_Plumosa_Flower.jpg' WHERE[id]=6
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Curcuma_Alismatifolia_Flower.jpg' WHERE[id]=7
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Cutie_pie.jpg' WHERE[id]=8
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Gloriosa_Carsonii_Flower.jpg' WHERE[id]=9
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Halo.jpg' WHERE[id]=10
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Jasmine_Flower.jpg' WHERE[id]=11
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Lotus_Flower.jpg' WHERE[id]=12
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Mandevilla_Flower.jpg' WHERE[id]=13
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Mothers_mason_jar.jpg' WHERE[id]=14
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Persian_Blue_Allium.jpg' WHERE[id]=15
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Phlox_Flower.jpg' WHERE[id]=16
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Pink_Orchid_Flower.jpg' WHERE[id]=17
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/sunny_days.jpg' WHERE[id]=18
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/threes_company.jpg' WHERE[id]=19
                    UPDATE[dbo].[Flower] SET[Image]=N'/imgs/Zaluzianskya_Ovata_Flower.jpg' WHERE[id]=20
                SET IDENTITY_INSERT[dbo].[Flower] OFF
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
