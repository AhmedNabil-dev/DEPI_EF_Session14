using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_EF_Session14.Domain.Libaray_System
{
    internal class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime birthdate { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
