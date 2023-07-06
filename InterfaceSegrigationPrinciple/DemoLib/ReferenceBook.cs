using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class ReferenceBook : IBook
    {
        public string Author { get; set; }
        public int Page { get; set; }
        public string LibraryId { get; set; }
        public string Title { get; set; }
    }
}
