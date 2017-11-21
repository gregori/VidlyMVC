namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9e64ae9e-e3c5-4900-8b82-0146844cbe78', N'guest@vidly.com', 0, N'AIyYcwx04tCthrdSsNdUk/PX463D1of3ZHLq2gHctqzdjsGNU31wbEen5QNnyYW/iw==', N'42eb39fe-b383-4643-9154-fa9e6f9b5453', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b92c6b37-5af3-4503-914c-b4f3a3d0d062', N'admin@vidly.com', 0, N'AHDPkQz/zd8MeKrVNCGwZmQSkU1D3VhIfkz5d4N1olll14XYhmfsWNvrzCz7Fhh1oQ==', N'b7a7a553-df8e-48c5-9fee-c8fc3f9f4304', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'eaafa8b8-e6de-45a2-bf0e-af6e9e051d11', N'CanManageCustomers')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b92c6b37-5af3-4503-914c-b4f3a3d0d062', N'eaafa8b8-e6de-45a2-bf0e-af6e9e051d11')
");
        }
        
        public override void Down()
        {
        }
    }
}
