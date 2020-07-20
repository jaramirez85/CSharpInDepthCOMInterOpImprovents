
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
            Application app = new Application { Visible = false };


            object missing = WdLanguageID.wdEnglishUS; //Type.Missing;
            SynonymInfo info = app.get_SynonymInfo("method", missing);
            Console.WriteLine("*** 'method' has {0} meanings", info.MeaningCount);

            foreach(var a in info.MeaningList as Array)
            {
                Console.WriteLine(a);
            }




            info = app.SynonymInfo["index", missing];
            Console.WriteLine("*** 'index' has {0} meanings", info.MeaningCount);

            foreach (var a in info.MeaningList as Array)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();

        }

}

}