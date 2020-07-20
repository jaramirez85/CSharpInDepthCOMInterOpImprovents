
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

            Application app = new Application { Visible = true };
            Document doc = app.Documents.Add();
            Paragraph para = doc.Paragraphs.Add();
            para.Range.Text = "Simple new code";

            doc.SaveAs2(FileName: "demo2.docx");

            doc.Close();
            app.Application.Quit();

            Console.ReadKey();

        }
    }
}
