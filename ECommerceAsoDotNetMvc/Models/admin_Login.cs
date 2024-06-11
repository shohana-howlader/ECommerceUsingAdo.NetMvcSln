using System;
using System.Collections.Generic;
    
namespace ECommerceAsoDotNetMvc.Models
{
    public class admin_Login
    {
        public int ID { get; set; }
        public int EmpID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleType { get; set; }
        public string Notes { get; set; }
    
        public virtual admin_Employee admin_Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}