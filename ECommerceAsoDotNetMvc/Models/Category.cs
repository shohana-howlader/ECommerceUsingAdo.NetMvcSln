using System;
using System.Collections.Generic;
    
namespace ECommerceAsoDotNetMvc.Models
{
    public class Category
    {
        public Category()
        {
            this.genPromoRights = new HashSet<genPromoRight>();
            this.Products = new HashSet<Product>();
            this.SubCategories = new HashSet<SubCategory>();
        }
    
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        public virtual ICollection<genPromoRight> genPromoRights { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
