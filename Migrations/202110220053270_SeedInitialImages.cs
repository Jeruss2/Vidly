namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedInitialImages : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Images(Id, Name, Images) values( 1, 'Hangover',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\Hangover.jpg', SINGLE_BLOB) as Images))");
            //Sql("INSERT INTO dbo.Images (Name, Images) values('Die Hard',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\Die_Hard.jpg', SINGLE_BLOB) as Images)");
            //Sql("INSERT INTO dbo.Images (Name, Images) values('The Terminator',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\The_Terminator.jpg', SINGLE_BLOB) as Images)");
            //Sql("INSERT INTO dbo.Images (Name, Images) values('Toy Story',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\Toy_Story.jpg', SINGLE_BLOB) as Images)");
            //Sql("INSERT INTO dbo.Images (Name, Images) values('Titanic',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\Titanic.jpg', SINGLE_BLOB) as Images)");
            //Sql("INSERT INTO dbo.Images (Name, Images) values('Troy',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\Troy.jpg', SINGLE_BLOB) as Images)");
            //Sql("INSERT INTO dbo.Images (Name, Images) values('Black Widow',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\Black_Widow.jpg', SINGLE_BLOB) as Images)");

        }
        
        public override void Down()
        {
        }
    }
}
