using System;
using System.Collections.Generic;
    
namespace ECommerceAsoDotNetMvc.Models
{
    public class genPromoRight
    {
        public int genPromoRightID { get; set; }
        public int CategoryID { get; set; }
        public string ImageURL { get; set; }
        public string AltText { get; set; }
        public string OfferTag { get; set; }
        public string Title { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
