using System;
using System.Collections.Generic;
using System.Text;

namespace Print
{
    class MainPrintFile
    {
        public MainPrintFile(Iprintable file)
        {
            
            Console.WriteLine($"{file.GetType()} cap edildi");
        }
    }
}
