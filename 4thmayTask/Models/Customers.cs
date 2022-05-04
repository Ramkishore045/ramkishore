using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Customer.Models
{
    public class Customers
    {
        
            [Key]
            public int CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string EmailID { get; set; }
            public string MobileNo { get; set; }
        
    }
}
