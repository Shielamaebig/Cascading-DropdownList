namespace Cascading_DropdownList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountryModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Countries");
        }
    }
}
