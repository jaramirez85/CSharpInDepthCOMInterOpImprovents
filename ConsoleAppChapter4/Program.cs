
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              A lot of code is required just to create and save a document, including 20 occurrences 
            of ref missing. It’s hard to see the useful part of the code within the forest of arguments 
            you don’t care about.
             */

            object missing = Type.Missing;

            Application app = new Application { Visible = true };
            Document doc = app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            Paragraph para = doc.Paragraphs.Add(ref missing);
            para.Range.Text = "Awkward old code";

            object fileName = @"C:\Users\javie\source\repos\ConsoleAppChapter4\MyFiles\demo1.docx";
            doc.SaveAs2(ref fileName, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing);

            doc.Close(ref missing, ref missing, ref missing);
            app.Application.Quit(ref missing, ref missing, ref missing);

            Console.ReadKey();

        }
    }
}
