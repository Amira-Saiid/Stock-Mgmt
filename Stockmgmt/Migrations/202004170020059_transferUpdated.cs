namespace Stockmgmt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class transferUpdated : DbMigration
    {
        public override void Up()
        {

            AddColumn("Transfer_Product", "Quantity", c => c.Int());
            AddColumn("Transfer_Product", "To_Stock", c => c.String());
            AddColumn("Transfer_Product", "From_Stock", c => c.String());
            AddColumn("Transfer_Product", "Expiry_Date", c => c.DateTime());
            AddColumn("Transfer_Product", "Prodn_Date", c => c.DateTime());
            AddColumn("Transfer_Product", "Supp_Name", c => c.String());






            //    CreateTable(
            //        "dbo.Measure_Unit",
            //        c => new
            //            {
            //                Unit_Id = c.Int(nullable: false, identity: true),
            //                Unit_Name = c.String(nullable: false, maxLength: 50, unicode: false),
            //            })
            //        .PrimaryKey(t => t.Unit_Id);

            //    CreateTable(
            //        "dbo.Product",
            //        c => new
            //            {
            //                Product_Id = c.Int(nullable: false, identity: true),
            //                Product_Name = c.String(nullable: false, maxLength: 50, unicode: false),
            //            })
            //        .PrimaryKey(t => t.Product_Id);

            //    CreateTable(
            //        "dbo.Permission_Product",
            //        c => new
            //            {
            //                Permission_Id = c.Int(nullable: false),
            //                Product_Id = c.Int(nullable: false),
            //                Prodn_Date = c.DateTime(nullable: false, storeType: "date"),
            //                Expiry_Date = c.DateTime(nullable: false, storeType: "date"),
            //                Quantity = c.Int(nullable: false),
            //            })
            //        .PrimaryKey(t => new { t.Permission_Id, t.Product_Id })
            //        .ForeignKey("dbo.Permission", t => t.Permission_Id)
            //        .ForeignKey("dbo.Product", t => t.Product_Id)
            //        .Index(t => t.Permission_Id)
            //        .Index(t => t.Product_Id);

            //    CreateTable(
            //        "dbo.Permission",
            //        c => new
            //            {
            //                Permission_Id = c.Int(nullable: false, identity: true),
            //                Permission_Name = c.String(nullable: false, maxLength: 50, unicode: false),
            //                Permission_Type = c.String(nullable: false, maxLength: 50, unicode: false),
            //                Stock_Id = c.Int(nullable: false),
            //                Per_Id = c.Int(nullable: false),
            //            })
            //        .PrimaryKey(t => t.Permission_Id)
            //        .ForeignKey("dbo.Person", t => t.Per_Id)
            //        .Index(t => t.Per_Id);

            //    CreateTable(
            //        "dbo.Person",
            //        c => new
            //            {
            //                Per_Id = c.Int(nullable: false, identity: true),
            //                Per_Name = c.String(nullable: false, maxLength: 50, unicode: false),
            //                Per_Mobile = c.String(nullable: false, maxLength: 50, unicode: false),
            //                Per_Phone = c.String(maxLength: 50, unicode: false),
            //                Per_Fax = c.String(maxLength: 50, unicode: false),
            //                Per_Email = c.String(nullable: false, maxLength: 50, unicode: false),
            //                Per_Website = c.String(maxLength: 50, unicode: false),
            //                Per_Type = c.String(nullable: false, maxLength: 50, unicode: false),
            //            })
            //        .PrimaryKey(t => t.Per_Id);

            //    CreateTable(
            //        "dbo.Stock",
            //        c => new
            //            {
            //                Stock_Id = c.Int(nullable: false, identity: true),
            //                Stock_Name = c.String(nullable: false, maxLength: 50, unicode: false),
            //                Stock_Add = c.String(nullable: false, maxLength: 50, unicode: false),
            //                Admin_Name = c.String(nullable: false, maxLength: 50, unicode: false),
            //            })
            //        .PrimaryKey(t => t.Stock_Id);

            //    CreateTable(
            //        "dbo.Transfer_Product",
            //        c => new
            //            {
            //                Stock_Id = c.Int(nullable: false),
            //                Product_Id = c.Int(nullable: false),
            //                To_Stock = c.String(),
            //                From_Stock = c.String(),
            //                Quantity = c.Int(nullable: false),
            //                Expiry_Date = c.DateTime(nullable: false),
            //                Prodn_Date = c.DateTime(nullable: false),
            //                Supp_Name = c.String(),
            //                Transfer_Date = c.DateTime(nullable: false, storeType: "date"),
            //            })
            //        .PrimaryKey(t => new { t.Stock_Id, t.Product_Id })
            //        .ForeignKey("dbo.Stock", t => t.Stock_Id)
            //        .ForeignKey("dbo.Product", t => t.Product_Id)
            //        .Index(t => t.Stock_Id)
            //        .Index(t => t.Product_Id);

            //    CreateTable(
            //        "dbo.sysdiagrams",
            //        c => new
            //            {
            //                diagram_id = c.Int(nullable: false, identity: true),
            //                name = c.String(nullable: false, maxLength: 128),
            //                principal_id = c.Int(nullable: false),
            //                version = c.Int(),
            //                definition = c.Binary(),
            //            })
            //        .PrimaryKey(t => t.diagram_id);

            //    CreateTable(
            //        "dbo.Products_inStocks",
            //        c => new
            //            {
            //                Product_Id = c.Int(nullable: false),
            //                Stock_Id = c.Int(nullable: false),
            //            })
            //        .PrimaryKey(t => new { t.Product_Id, t.Stock_Id })
            //        .ForeignKey("dbo.Product", t => t.Product_Id, cascadeDelete: true)
            //        .ForeignKey("dbo.Stock", t => t.Stock_Id, cascadeDelete: true)
            //        .Index(t => t.Product_Id)
            //        .Index(t => t.Stock_Id);

            //    CreateTable(
            //        "dbo.Product_Unit",
            //        c => new
            //            {
            //                Unit_Id = c.Int(nullable: false),
            //                Product_Id = c.Int(nullable: false),
            //            })
            //        .PrimaryKey(t => new { t.Unit_Id, t.Product_Id })
            //        .ForeignKey("dbo.Measure_Unit", t => t.Unit_Id, cascadeDelete: true)
            //        .ForeignKey("dbo.Product", t => t.Product_Id, cascadeDelete: true)
            //        .Index(t => t.Unit_Id)
            //        .Index(t => t.Product_Id);

        }

        public override void Down()
        {
            DropColumn("Transfer_Product", "Quantity");
            DropColumn("Transfer_Product", "To_Stock");
            DropColumn("Transfer_Product", "From_Stock");
            DropColumn("Transfer_Product", "Expiry_Date");
            DropColumn("Transfer_Product", "Prodn_Date");
            DropColumn("Transfer_Product", "Supp_Name");



            //DropForeignKey("dbo.Product_Unit", "Product_Id", "dbo.Product");
            //DropForeignKey("dbo.Product_Unit", "Unit_Id", "dbo.Measure_Unit");
            //DropForeignKey("dbo.Transfer_Product", "Product_Id", "dbo.Product");
            //DropForeignKey("dbo.Products_inStocks", "Stock_Id", "dbo.Stock");
            //DropForeignKey("dbo.Products_inStocks", "Product_Id", "dbo.Product");
            //DropForeignKey("dbo.Transfer_Product", "Stock_Id", "dbo.Stock");
            //DropForeignKey("dbo.Permission_Product", "Product_Id", "dbo.Product");
            //DropForeignKey("dbo.Permission", "Per_Id", "dbo.Person");
            //DropForeignKey("dbo.Permission_Product", "Permission_Id", "dbo.Permission");
            //DropIndex("dbo.Product_Unit", new[] { "Product_Id" });
            //DropIndex("dbo.Product_Unit", new[] { "Unit_Id" });
            //DropIndex("dbo.Products_inStocks", new[] { "Stock_Id" });
            //DropIndex("dbo.Products_inStocks", new[] { "Product_Id" });
            //DropIndex("dbo.Transfer_Product", new[] { "Product_Id" });
            //DropIndex("dbo.Transfer_Product", new[] { "Stock_Id" });
            //DropIndex("dbo.Permission", new[] { "Per_Id" });
            //DropIndex("dbo.Permission_Product", new[] { "Product_Id" });
            //DropIndex("dbo.Permission_Product", new[] { "Permission_Id" });
            //DropTable("dbo.Product_Unit");
            //DropTable("dbo.Products_inStocks");
            //DropTable("dbo.sysdiagrams");
            //DropTable("dbo.Transfer_Product");
            //DropTable("dbo.Stock");
            //DropTable("dbo.Person");
            //DropTable("dbo.Permission");
            //DropTable("dbo.Permission_Product");
            //DropTable("dbo.Product");
            //DropTable("dbo.Measure_Unit");
        }
    }
}
