using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerStore.Data.Migrations
{
	public partial class PopulateFlowerTypes : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql(@"
				SET IDENTITY_INSERT [dbo].[FlowerTypes] ON
				INSERT INTO [dbo].[FlowerTypes] ([Id], [Name]) VALUES (1, N'Christmas')
				INSERT INTO [dbo].[FlowerTypes] ([Id], [Name]) VALUES (2, N'Valentines Day')
				INSERT INTO [dbo].[FlowerTypes] ([Id], [Name]) VALUES (3, N'Mothers Day')
				INSERT INTO [dbo].[FlowerTypes] ([Id], [Name]) VALUES (4, N'Spring')
				INSERT INTO [dbo].[FlowerTypes] ([Id], [Name]) VALUES (5, N'Gift')
				SET IDENTITY_INSERT [dbo].[FlowerTypes] OFF
			");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{

		}
	}
}
