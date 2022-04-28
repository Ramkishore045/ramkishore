using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Product.Models
{
    public class Products
    {
        [Key]
        [Required]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }

    }
}
