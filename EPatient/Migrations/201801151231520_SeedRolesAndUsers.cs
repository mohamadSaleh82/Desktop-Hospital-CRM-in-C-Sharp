namespace EPatient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRolesAndUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[Roles] ([Name]) VALUES ('Admin')
            INSERT INTO [dbo].[Roles] ([Name]) VALUES ('Operator')
            INSERT INTO [dbo].[Roles] ([Name]) VALUES ('Doctor')
            INSERT INTO [dbo].[Roles] ([Name]) VALUES ('Nurse')
            INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password], [RoleId]) VALUES ('Admin','Admin','admin','123',1)
            ");
        }
        
        public override void Down()
        {
        }
    }
}
