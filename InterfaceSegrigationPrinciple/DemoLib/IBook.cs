using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public interface IBook : IBorrowableAudioBook
    {
        string Author { get; set; }
        int Page { get; set; }
    }
}
