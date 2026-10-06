using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_EF_Session14.Domain.E_commerce
{
    internal class Order
    {
        public int ID { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}