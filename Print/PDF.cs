using System;
using System.Collections.Generic;
using System.Text;

namespace Print
{
    class PDF:Iprintable
    {
        public string Name;

        public PDF()
        {
            Name = "PDF";
        }

        public string Print()
        {
            return Name;
        }
    }
}
