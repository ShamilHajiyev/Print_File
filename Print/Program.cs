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

            MainPrintFile mpf = new MainPrintFile(pdf);
            MainPrintFile mpf2 = new MainPrintFile(excel);
            MainPrintFile mpf3 = new MainPrintFile(word);
        }
    }
}
