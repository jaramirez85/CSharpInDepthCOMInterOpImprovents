
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

            /*Application app = new Application { Visible = true };
            Document doc = app.Documents.Add();
            Paragraph para = doc.Paragraphs.Add();
            para.Range.Text = "Simple new code";

            doc.SaveAs2(FileName: "demo2.docx");

            doc.Close();
            app.Application.Quit();

            Console.ReadKey();*/


            //FooWithRefence(30); // Error, should be initialized before calling the method
            int refValue = 0;
            FooWithRefence(ref refValue);
            Console.WriteLine($"refValue: {refValue}");

            int outValue;
            FooWithOut(out outValue);
            Console.WriteLine($"outValue: {outValue}");

            Console.ReadKey();

        }
        
        static void FooWithRefence(ref int value)
        {
            value = 42;
        }

        static void FooWithOut(out int value)
        {
            value = 10;
        }
    }
}
