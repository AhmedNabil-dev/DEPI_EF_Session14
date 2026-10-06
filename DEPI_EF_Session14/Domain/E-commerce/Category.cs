using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_EF_Session14.Domain.E_commerce
{
    internal class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
