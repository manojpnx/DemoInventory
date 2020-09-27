using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoInventory.Domain.Entities
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int ReorderLevel { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }

    }
}
