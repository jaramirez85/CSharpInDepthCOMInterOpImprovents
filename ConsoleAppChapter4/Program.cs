
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
             * Declaration of behavior of an indexer is to some extent similar to a property. 
             * similar to the properties, you use get and set accessors for defining an indexer. 
             * However, properties return or set a specific data member, 
             * whereas indexers returns or sets a particular value from the object instance
             */

            var demo = new DemoIndexers();
            demo["1"] = "one";
            demo["2"] = "two";

            Console.WriteLine(demo["1"]);
            Console.WriteLine(demo["2"]);
            //Console.WriteLine(new DemoIndexers() ["123"]);

            Console.ReadKey();

        }

}

    public class DemoIndexers
    {
        private Dictionary<string, string> _values = new Dictionary<string, string>();

        public string this[string key]
        {
            get => _values[key];
            set => _values[key] = value;
        }
    }
}