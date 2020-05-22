namespace CafeteriaPS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CofeeOrders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameArticle = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 50),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Description = c.String(maxLength: 50),
                        Quantity = c.Int(nullable: false),
                        ArticleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .Index(t => t.ArticleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ArticleId", "dbo.Articles");
            DropIndex("dbo.Orders", new[] { "ArticleId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Articles");
        }
    }
}
