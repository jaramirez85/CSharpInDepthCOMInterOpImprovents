
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

            IEnumerable<string> strings = new List<string> { "a", "b", "c" };
            IEnumerable<object> objects = strings;

            //Error
            /*IList<string> strings = new List<string> { "a", "b", "c" };
            IList<object> objects = strings;

            objects.Add(new object());
            string element = strings[3];*/


           /* Action<object> objectAction = obj => Console.WriteLine(obj);
            Action<string> stringAction = objectAction;
            stringAction("Print me");*/



           /* MyAction<object> objectMyAction = obj => Console.WriteLine(obj);
            MyAction<string> stringMyAction = objectMyAction;
            stringMyAction("Print me");


            MyFunc<string> stringMyFunc = () => "123";
            MyFunc<object> objectMyFunc = stringMyFunc;
            object resp = objectMyFunc();
            Console.WriteLine(resp);*/

            Console.ReadKey();

        }

}

    public delegate void MyAction<in T>(T obj);
    public delegate R MyFunc<out R>();

    //Invalid
    /*public class SimpleEnumerable<T> : IEnumerable<T>
    {
    }*/

}