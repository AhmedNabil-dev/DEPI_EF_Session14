using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_EF_Session14.Domain.Libaray_System
{
    internal class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }   

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public ICollection<Loan> BorrowedBooks { get; set; }
    }
}
