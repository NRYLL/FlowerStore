using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerStore.Data.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount] ) VALUES (N'53a81706-890b-496c-a9f7-6e2345253f81', N'admin@nryll.com', N'ADMIN@NRYLL.COM', N'admin@nryll.com', N'ADMIN@NRYLL.COM', 1, N'AQAAAAEAACcQAAAAEKPuuPMKYuu7xenF8ATpEHhmW3aaT4WL/ZyTG7Y3p8J3Hw4Ieqkrlys9uW3vpqKctQ==', N'AYGNDKEKXGEC7JKUMMDCES4LCQ537IVO', N'76d518cb-0cc6-4e4f-bb73-e8b479fee4ff', NULL, 0, 0, NULL, 1, 0 )
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b4a40dbb-0665-48ff-9b19-b899dfedf337', N'CanManageFlower')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'53a81706-890b-496c-a9f7-6e2345253f81', N'b4a40dbb-0665-48ff-9b19-b899dfedf337')
            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
