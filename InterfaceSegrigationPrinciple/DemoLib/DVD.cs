using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class DVD : IBorrowableDVD
    {
        public List<string> Actors { get; set; }
        public int RuntimeInMinutes { get; set; }
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public DateTime BorroweDate { get; set; }
        public string Borrwer { get; set; }
        public int CheckoutDurationDays { get; set; } = 14;

        public void CheckIn()
        {
            Borrwer = string.Empty;
        }

        public void CheckOut(string borrower)
        {
            Borrwer = borrower;
            BorroweDate = DateTime.Now;
        }

        public DateTime GetDueDate()
        {
            return BorroweDate.AddDays(CheckoutDurationDays);
        }
    }
}
