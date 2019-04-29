using System.Web.UI.WebControls;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id,Name) VALUES ('1','Comedy')");
            Sql("INSERT INTO Genres(Id,Name) VALUES ('2','Horror')");
            Sql("INSERT INTO Genres(Id,Name) VALUES ('3','Romance')");
            Sql("INSERT INTO Genres(Id,Name) VALUES ('4','Action')");
        }
        
        public override void Down()
        {
        }
    }
}