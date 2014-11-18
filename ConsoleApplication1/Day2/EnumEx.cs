using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Day2
{
   
    class TestProg 
    {
        public enum Days { Monday = 3, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        static void Main() {
            Days day = Days.Monday;
            Console.WriteLine((int)day);

            string[] values = Enum.GetNames(typeof(Days));
            foreach (string s in values)
                Console.WriteLine(s);

            Console.WriteLine(Enum.GetName(typeof(Days), Days.Wednesday));

            Console.ReadKey();
        }
    }
}
