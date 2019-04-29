namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'113b818b-a14e-412e-8609-37e6b826e1aa', N'admin@vidly.com', 0, N'ADbSyLWUvPTU1b6KEPOjYg3yS/QYc1rtUfe09W5qLuSLUGr21p3bS6T24Vijtd5C+A==', N'c953936a-bf58-4519-a5f2-6e3eedbc1b54', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8d585aeb-7295-4358-ac36-0780caebc74e', N'guest@vidly.com', 0, N'ADXToa5WV+dqdEXV9qtVRbDaLaW4R4xLdwRR2YObmbu+vWLaRke12zmHs3C+ESiF/w==', N'cc149751-7b5e-464e-9444-f32cc368c460', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'29813db2-92a8-4600-b91d-635bd28a5ba2', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'113b818b-a14e-412e-8609-37e6b826e1aa', N'29813db2-92a8-4600-b91d-635bd28a5ba2')

");
        }
        
        public override void Down()
        {
        }
    }
}
