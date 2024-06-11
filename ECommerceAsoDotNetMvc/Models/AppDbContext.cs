using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerceAsoDotNetMvc.Models.AppDb
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDbContext") 
        {
            
        }

        public DbSet<admin_Employee> admin_Employee { get; set; }
        public DbSet<admin_Login> admin_Login { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<genMainSlider> genMainSliders { get; set; }
        public DbSet<genPromoRight> genPromoRights { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RecentlyView> RecentlyViews { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShippingDetail> ShippingDetails { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
    }
}