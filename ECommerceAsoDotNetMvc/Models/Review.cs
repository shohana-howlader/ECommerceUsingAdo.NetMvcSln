
    using System;
    using System.Collections.Generic;
    
namespace ECommerceAsoDotNetMvc.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Review1 { get; set; }
        public Nullable<int> Rate { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<bool> isDelete { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
