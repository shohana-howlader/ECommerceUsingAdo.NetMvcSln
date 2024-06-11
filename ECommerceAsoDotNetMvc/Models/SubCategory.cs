using System;
using System.Collections.Generic;
    
namespace ECommerceAsoDotNetMvc.Models
{
    public class SubCategory
    {
        public SubCategory()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int SubCategoryID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
