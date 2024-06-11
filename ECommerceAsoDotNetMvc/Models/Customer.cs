using System;
using System.Collections.Generic;
    
namespace ECommerceAsoDotNetMvc.Models
{
    public class Customer
    {
        public Customer()
        {
            this.Orders = new HashSet<Order>();
            this.RecentlyViews = new HashSet<RecentlyView>();
            this.Reviews = new HashSet<Review>();
            this.Wishlists = new HashSet<Wishlist>();
        }
    
        public int CustomerID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> Age { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateofBirth { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Picture { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<RecentlyView> RecentlyViews { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
