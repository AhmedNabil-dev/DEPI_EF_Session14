using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_EF_Session14.Domain .E_commerce
{
    internal class Product
    {
        public  int ID { get; set; }    
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
