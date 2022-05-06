using System;

namespace Print
{
    class Program
    {
        static void Main(string[] args)
        {
            PDF pdf = new PDF();
            Excel excel = new Excel();
            Word word = new Word();

            MainPrintFile mpf = new MainPrintFile(excel);
        }
    }
}
