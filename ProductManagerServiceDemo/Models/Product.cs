using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductManagerServiceDemo.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }
    }
}