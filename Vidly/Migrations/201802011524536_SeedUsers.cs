namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9e687b50-3d4e-4cb9-9d85-9f505a8e089d', N'admin@vidly.com', 0, N'AFYL/C1NpctcZgAYt3BI/W51T2higpTdQgEEfun6nQXVDK+WR2BCOMxejmXqsZYjTw==', N'8f7a3f02-a410-4f13-97c1-b54c9f900d4a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c8abaea1-534a-487c-8b01-1414db4e0135', N'guest@vidly.com', 0, N'AAr4/wYdW+PLfmKnK7LeAQ+QkVDt2aI4K+ZYoBPZnp18BSFo0Q95LVfs7/kF0sGQRA==', N'b6dbc97e-dad8-4974-9157-ede7712b32db', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4f1643e6-24d0-49ce-bf76-a893e22f18ad', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9e687b50-3d4e-4cb9-9d85-9f505a8e089d', N'4f1643e6-24d0-49ce-bf76-a893e22f18ad')

            ");


        }
        
        public override void Down()
        {
        }
    }
}
