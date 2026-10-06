using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_EF_Session14.Domain.Libaray_System
{
    internal class Borrower
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public DateTime MemberShipDate { get; set; }

        public ICollection<Loan> BorrowedBooks { get; set; }

    }
}
