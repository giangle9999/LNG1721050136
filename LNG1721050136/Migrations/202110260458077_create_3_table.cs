namespace LNG1721050136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_3_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        perSonID = c.String(nullable: false, maxLength: 20),
                        perSonName = c.String(maxLength: 50),
                        Faculty = c.String(maxLength: 50),
                        Department = c.String(maxLength: 50),
                        University = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.perSonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
