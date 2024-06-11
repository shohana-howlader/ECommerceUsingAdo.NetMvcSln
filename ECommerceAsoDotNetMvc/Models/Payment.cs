using System;
using System.Collections.Generic;
    
namespace ECommerceAsoDotNetMvc.Models
{
    public class Payment
    {
        public Payment()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int PaymentID { get; set; }
        public int Type { get; set; }
        public Nullable<decimal> CreditAmount { get; set; }
        public Nullable<decimal> DebitAmount { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<System.DateTime> PaymentDateTime { get; set; }  
        public virtual ICollection<Order> Orders { get; set; }
    }
}
