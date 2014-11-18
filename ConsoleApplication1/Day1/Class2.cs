using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class2
    {
        static void Main()
        {
            int[] a = {10,20,30,40,50};

            foreach (int val in a) {
                Console.WriteLine("a[" + "?" + "] =  " + val);
            }

            int[] b = new int[6];
            b[5] = 55;

            foreach (int val in b)
            {
                Console.WriteLine("b[" + "?" + "] =  " + val);
            }

            Console.WriteLine("--------------");

            string str = "this is a test";
            Console.WriteLine(str.ToUpper());

            string[] strs = {"3.14", "4.56", "7.89"};
            double sum = 0;
            foreach (string ts in strs) {
                sum += Convert.ToDouble(ts);
            }
            Console.WriteLine(sum);

            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("num1 = " + num1);
            Console.ReadKey();
        }
    }
}
