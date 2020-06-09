using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerStore.Data.Migrations
{
    public partial class AddFlowerDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT[dbo].[Flower] ON
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=1
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=2
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=3
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=4
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=5
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=6
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=7
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=8
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=9
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=10
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=11
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=12
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=13
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=14
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=15
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=16
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=17
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=18
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=19
                    UPDATE [dbo].[Flower] SET [Description]='Bouquet includes Designers Collection of a beautiful mix of at least 12 stems of assorted flowers or a single type of flower, like Red Roses.' WHERE[id]=20
                SET IDENTITY_INSERT[dbo].[Flower] OFF
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
