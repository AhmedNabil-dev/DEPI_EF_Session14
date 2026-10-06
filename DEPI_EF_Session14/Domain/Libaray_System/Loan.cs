using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_EF_Session14.Domain.Libaray_System
{
    internal class Loan
    {
        public int Id { get; set; }
         
         public int BookId { get; set; }
         public int BorrowerId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Borrower Borrower { get; set; }
        public Book Book { get; set; }
    }
}
