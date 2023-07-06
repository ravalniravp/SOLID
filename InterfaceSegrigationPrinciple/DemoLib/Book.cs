using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class Book : IBorrowableBook
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Page { get; set; }
        public int CheckoutDurationDays { get; set; }

        public DateTime BorroweDate { get; set; }
        public string Borrwer { get; set; }

        public void CheckIn()
        {
            Borrwer= string.Empty;
        }

        public void CheckOut(string borrower)
        {
            Borrwer = borrower;
            BorroweDate = DateTime.Now;
        }

        public DateTime GetDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
