using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_EF_Session14.Domain.E_commerce
{
    internal class OrderDetail
    { 
        public int ID { get; set; }
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
