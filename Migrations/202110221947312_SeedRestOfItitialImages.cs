namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRestOfItitialImages : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO dbo.Images (Id, Name, Images) values( 2,'Die Hard',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\Die_Hard.jpg', SINGLE_BLOB) as Images))");
            Sql("INSERT INTO dbo.Images (Id, Name, Images) values( 3, 'The Terminator',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\The_Terminator.jpg', SINGLE_BLOB) as Images))");
            Sql("INSERT INTO dbo.Images (Id, Name, Images) values( 4, 'Toy Story',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\Toy_Story.jpg', SINGLE_BLOB) as Images))");
            Sql("INSERT INTO dbo.Images (Id, Name, Images) values( 5, 'Titanic',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\Titanic.jpg', SINGLE_BLOB) as Images))");
            Sql("INSERT INTO dbo.Images (Id, Name, Images) values(8, 'Troy',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\Troy.jpg', SINGLE_BLOB) as Images))");
            Sql("INSERT INTO dbo.Images (Id, Name, Images) values( 9, 'Black Widow',(SELECT * FROM OPENROWSET(BULK N'C:\\Users\\jerus\\source\\repos\\vidly\\Content\\Images\\Black_Widow.jpg', SINGLE_BLOB) as Images))");

        }

        public override void Down()
        {
        }
    }
}
