using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerStore.Data.Migrations
{
    public partial class PopulateFlowerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT [dbo].[Flower] ON
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(1, N'African Violet Flower', N'imgs/African_Violet_Flower.jpg', 52.99, 5, 2)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(2, N'Beach trio', N'imgs/Beach_trio.jpg', 15.99, 10, 3)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(3, N'Brahma Kamal Flower', N'imgs/Brahma_Kamal_Flower.jpg', 34.99, 0, 5)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(4, N'Buddie', N'imgs/Buddie.jpg', 67.99, 8, 4)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(5, N'buddy trio', N'imgs/buddy_trio.jpg', 32.99, 7, 3)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(6, N'Celosia Plumosa Flower', N'imgs/Celosia_Plumosa_Flower.jpg', 13.99, 5, 4)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(7, N'Curcuma Alismatifolia Flower', N'imgs/Curcuma_Alismatifolia_Flower.jpg', 46.99, 78, 2)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(8, N'Cutie pie', N'imgs/Cutie_pie.jpg', 31.99, 5, 1)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(9, N'Gloriosa Carsonii Flower', N'imgs/Gloriosa_Carsonii_Flower.jpg', 56.99, 3, 1)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(10, N'Halo', N'imgs/Halo.jpg', 85.99, 5, 4)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(11, N'Jasmine Flower', N'imgs/Jasmine_Flower.jpg', 44.99, 5, 2)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(12, N'Lotus Flower', N'imgs/Lotus_Flower.jpg', 54.99, 23, 3)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(13, N'Mandevilla Flower', N'imgs/Mandevilla_Flower.jpg', 42.99, 6, 4)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(14, N'Mothers mason jar', N'imgs/Mothers_mason_jar.jpg', 56.99, 78, 2)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(15, N'Persian Blue Allium', N'imgs/Persian_Blue_Allium.jpg', 33.99, 5, 5)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(16, N'Phlox Flower', N'imgs/Phlox_Flower.jpg', 66.99, 4, 1)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(17, N'Pink Orchid Flower', N'imgs/Pink_Orchid_Flower.jpg', 23.99, 5, 3)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(18, N'sunny days', N'imgs/sunny_days.jpg', 78.99, 4, 3)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(19, N'threes company', N'imgs/threes_company.jpg', 34.99, 5, 4)
                INSERT INTO[dbo].[Flower] ([Id], [Name], [Image], [price], [Quantity], [TypeId]) VALUES(20, N'Zaluzianskya Ovata Flower', N'imgs/Zaluzianskya_Ovata_Flower.jpg', 90.99, 5, 5)
                SET IDENTITY_INSERT [dbo].[Flower] OFF
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
