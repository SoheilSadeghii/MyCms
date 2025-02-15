namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PageComments",
                c => new
                    {
                        GroupID = c.Int(nullable: false, identity: true),
                        GroupTitle = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.GroupID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        PageID = c.Int(nullable: false, identity: true),
                        GroupID = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 250),
                        ShortDescription = c.String(nullable: false, maxLength: 350),
                        Text = c.String(nullable: false),
                        Visit = c.Int(nullable: false),
                        ImageName = c.String(),
                        ShowInSlider = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        PageGroup_CommentID = c.Int(),
                    })
                .PrimaryKey(t => t.PageID)
                .ForeignKey("dbo.PageGroups", t => t.PageGroup_CommentID)
                .Index(t => t.PageGroup_CommentID);
            
            CreateTable(
                "dbo.PageGroups",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        PageID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 150),
                        Email = c.String(maxLength: 200),
                        WebSite = c.String(maxLength: 200),
                        Comment = c.String(nullable: false, maxLength: 500),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID);
            
            CreateTable(
                "dbo.PagePageComments",
                c => new
                    {
                        Page_PageID = c.Int(nullable: false),
                        PageComment_GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Page_PageID, t.PageComment_GroupID })
                .ForeignKey("dbo.Pages", t => t.Page_PageID, cascadeDelete: true)
                .ForeignKey("dbo.PageComments", t => t.PageComment_GroupID, cascadeDelete: true)
                .Index(t => t.Page_PageID)
                .Index(t => t.PageComment_GroupID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pages", "PageGroup_CommentID", "dbo.PageGroups");
            DropForeignKey("dbo.PagePageComments", "PageComment_GroupID", "dbo.PageComments");
            DropForeignKey("dbo.PagePageComments", "Page_PageID", "dbo.Pages");
            DropIndex("dbo.PagePageComments", new[] { "PageComment_GroupID" });
            DropIndex("dbo.PagePageComments", new[] { "Page_PageID" });
            DropIndex("dbo.Pages", new[] { "PageGroup_CommentID" });
            DropTable("dbo.PagePageComments");
            DropTable("dbo.PageGroups");
            DropTable("dbo.Pages");
            DropTable("dbo.PageComments");
        }
    }
}
