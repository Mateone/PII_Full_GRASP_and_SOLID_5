using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintText(ITextToPrint textToPrint)
        {
            Console.WriteLine(textToPrint.GetTextToPrint());
        }
    }
}