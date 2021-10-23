namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConnectImagesWithMovie : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Movies", "ImageId");
            AddForeignKey("dbo.Movies", "ImageId", "dbo.Images", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "ImageId", "dbo.Images");
            DropIndex("dbo.Movies", new[] { "ImageId" });
        }
    }
}
