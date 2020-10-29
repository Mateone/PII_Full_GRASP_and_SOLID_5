using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintText(ITextToPrint textToPrint)
        {
            File.WriteAllText("Recipe.txt", textToPrint.GetTextToPrint());
        }
    }
}