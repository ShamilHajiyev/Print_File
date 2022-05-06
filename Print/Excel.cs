using System;
using System.Collections.Generic;
using System.Text;

namespace Print
{
    class Excel:Iprintable
    {
        public string Name;

        public Excel()
        {
            Name = "Excel";
        }

        public string Print()
        {
            return Name;
        }
    }
}
