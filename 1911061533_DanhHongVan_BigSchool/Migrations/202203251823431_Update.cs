namespace _1911061533_DanhHongVan_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "DataTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "DataTime", c => c.DateTime(nullable: false));
        }
    }
}
