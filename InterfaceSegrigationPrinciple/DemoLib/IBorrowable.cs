using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public interface IBorrowable
    {
        DateTime BorroweDate { get; set; }
        string Borrwer { get; set; }
        int CheckoutDurationDays { get; set; }
        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
