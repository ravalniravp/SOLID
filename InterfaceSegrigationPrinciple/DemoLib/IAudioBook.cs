using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public interface IAudioBook : IBorrowableAudioBook
    {
        int RuntimeInMinutes { get; set; }
    }
}
