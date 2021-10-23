namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialImages : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Images = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "ImageId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ImageId");
            DropTable("dbo.Images");
        }
    }
}
