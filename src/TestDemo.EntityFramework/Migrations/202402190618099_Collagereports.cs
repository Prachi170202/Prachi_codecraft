namespace TestDemo.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Collagereports : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Collagereports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        internshipreport = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Collagereport_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.IsDeleted);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Collagereports", new[] { "IsDeleted" });
            DropTable("dbo.Collagereports",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Collagereport_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
