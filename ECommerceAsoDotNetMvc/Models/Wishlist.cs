
namespace ECommerceAsoDotNetMvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Wishlist
    {
        public int WishlistID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public Nullable<bool> isActive { get; set; }  
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
