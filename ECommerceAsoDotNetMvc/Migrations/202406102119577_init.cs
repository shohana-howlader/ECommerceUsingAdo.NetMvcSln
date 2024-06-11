namespace ECommerceAsoDotNetMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.admin_Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmpID = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(),
                        DateofBirth = c.DateTime(),
                        Gender = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Mobile = c.String(),
                        PhotoPath = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.admin_Login",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmpID = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        RoleType = c.Int(),
                        Notes = c.String(),
                        admin_Employee_ID = c.Int(),
                        Role_RoleID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.admin_Employee", t => t.admin_Employee_ID)
                .ForeignKey("dbo.Roles", t => t.Role_RoleID)
                .Index(t => t.admin_Employee_ID)
                .Index(t => t.Role_RoleID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Picture1 = c.String(),
                        Picture2 = c.String(),
                        isActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.genPromoRights",
                c => new
                    {
                        genPromoRightID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        ImageURL = c.String(),
                        AltText = c.String(),
                        OfferTag = c.String(),
                        Title = c.String(),
                        isDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.genPromoRightID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SupplierID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        SubCategoryID = c.Int(),
                        QuantityPerUnit = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OldPrice = c.Decimal(precision: 18, scale: 2),
                        UnitWeight = c.String(),
                        Size = c.String(),
                        Discount = c.Decimal(precision: 18, scale: 2),
                        UnitInStock = c.Int(),
                        UnitOnOrder = c.Int(),
                        ProductAvailable = c.Boolean(),
                        ImageURL = c.String(),
                        AltText = c.String(),
                        AddBadge = c.Boolean(),
                        OfferTitle = c.String(),
                        OfferBadgeClass = c.String(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        Picture1 = c.String(),
                        Picture2 = c.String(),
                        Picture3 = c.String(),
                        Picture4 = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryID)
                .ForeignKey("dbo.Suppliers", t => t.SupplierID, cascadeDelete: true)
                .Index(t => t.SupplierID)
                .Index(t => t.CategoryID)
                .Index(t => t.SubCategoryID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                        Quantity = c.Int(),
                        Discount = c.Decimal(precision: 18, scale: 2),
                        TotalAmount = c.Decimal(precision: 18, scale: 2),
                        OrderDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        PaymentID = c.Int(),
                        ShippingID = c.Int(),
                        Discount = c.Int(),
                        Taxes = c.Int(),
                        TotalAmount = c.Int(),
                        isCompleted = c.Boolean(),
                        OrderDate = c.DateTime(),
                        DIspatched = c.Boolean(),
                        DispatchedDate = c.DateTime(),
                        Shipped = c.Boolean(),
                        ShippingDate = c.DateTime(),
                        Deliver = c.Boolean(),
                        DeliveryDate = c.DateTime(),
                        Notes = c.String(),
                        CancelOrder = c.Boolean(),
                        ShippingDetail_ShippingDetailID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Payments", t => t.PaymentID)
                .ForeignKey("dbo.ShippingDetails", t => t.ShippingDetail_ShippingDetailID)
                .Index(t => t.CustomerID)
                .Index(t => t.PaymentID)
                .Index(t => t.ShippingDetail_ShippingDetailID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Age = c.Int(),
                        Gender = c.String(),
                        DateofBirth = c.DateTime(),
                        Email = c.String(),
                        Address1 = c.String(),
                        Picture = c.String(),
                        status = c.String(),
                        LastLogin = c.DateTime(),
                        Created = c.DateTime(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.RecentlyViews",
                c => new
                    {
                        RecentlyViewID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        ViewDate = c.DateTime(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.RecentlyViewID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(),
                        ProductID = c.Int(),
                        Name = c.String(),
                        Email = c.String(),
                        Review1 = c.String(),
                        Rate = c.Int(),
                        DateTime = c.DateTime(),
                        isDelete = c.Boolean(),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.CustomerID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Wishlists",
                c => new
                    {
                        WishlistID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        isActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.WishlistID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentID = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        CreditAmount = c.Decimal(precision: 18, scale: 2),
                        DebitAmount = c.Decimal(precision: 18, scale: 2),
                        Balance = c.Decimal(precision: 18, scale: 2),
                        PaymentDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.PaymentID);
            
            CreateTable(
                "dbo.ShippingDetails",
                c => new
                    {
                        ShippingDetailID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Mobile = c.String(),
                        Address = c.String(),
                        Province = c.String(),
                        City = c.String(),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.ShippingDetailID);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        SubCategoryID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Picture1 = c.String(),
                        Picture2 = c.String(),
                        isActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.SubCategoryID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        ContactName = c.String(),
                        ContactTitle = c.String(),
                        Address = c.String(),
                        Mobile = c.String(),
                        Phone = c.String(),
                        Fax = c.String(),
                        Email = c.String(),
                        City = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.SupplierID);
            
            CreateTable(
                "dbo.genMainSliders",
                c => new
                    {
                        genMainSliderID = c.Int(nullable: false, identity: true),
                        ImageURL = c.String(),
                        AltText = c.String(),
                        OfferTag = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        BtnText = c.String(),
                        isDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.genMainSliderID);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        principal_id = c.Int(nullable: false),
                        diagram_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SupplierID", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "SubCategoryID", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Orders", "ShippingDetail_ShippingDetailID", "dbo.ShippingDetails");
            DropForeignKey("dbo.Orders", "PaymentID", "dbo.Payments");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Wishlists", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Wishlists", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Reviews", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Reviews", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.RecentlyViews", "ProductID", "dbo.Products");
            DropForeignKey("dbo.RecentlyViews", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.genPromoRights", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.admin_Login", "Role_RoleID", "dbo.Roles");
            DropForeignKey("dbo.admin_Login", "admin_Employee_ID", "dbo.admin_Employee");
            DropIndex("dbo.SubCategories", new[] { "CategoryID" });
            DropIndex("dbo.Wishlists", new[] { "ProductID" });
            DropIndex("dbo.Wishlists", new[] { "CustomerID" });
            DropIndex("dbo.Reviews", new[] { "ProductID" });
            DropIndex("dbo.Reviews", new[] { "CustomerID" });
            DropIndex("dbo.RecentlyViews", new[] { "ProductID" });
            DropIndex("dbo.RecentlyViews", new[] { "CustomerID" });
            DropIndex("dbo.Orders", new[] { "ShippingDetail_ShippingDetailID" });
            DropIndex("dbo.Orders", new[] { "PaymentID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Products", new[] { "SubCategoryID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.Products", new[] { "SupplierID" });
            DropIndex("dbo.genPromoRights", new[] { "CategoryID" });
            DropIndex("dbo.admin_Login", new[] { "Role_RoleID" });
            DropIndex("dbo.admin_Login", new[] { "admin_Employee_ID" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.genMainSliders");
            DropTable("dbo.Suppliers");
            DropTable("dbo.SubCategories");
            DropTable("dbo.ShippingDetails");
            DropTable("dbo.Payments");
            DropTable("dbo.Wishlists");
            DropTable("dbo.Reviews");
            DropTable("dbo.RecentlyViews");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Products");
            DropTable("dbo.genPromoRights");
            DropTable("dbo.Categories");
            DropTable("dbo.Roles");
            DropTable("dbo.admin_Login");
            DropTable("dbo.admin_Employee");
        }
    }
}
