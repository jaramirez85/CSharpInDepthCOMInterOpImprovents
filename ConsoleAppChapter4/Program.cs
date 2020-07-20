using Microsoft.Office.Interop.Excel;
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

            var app = new Application { Visible = true };
            app.Workbooks.Add();
            Worksheet sheet = app.ActiveSheet;
            Range start = sheet.Cells[1, 1];
            Range end = sheet.Cells[1, 20];
            sheet.Range[start, end].Value = Enumerable.Range(1, 20).ToArray();

            Console.ReadKey();

        }
    }
}
