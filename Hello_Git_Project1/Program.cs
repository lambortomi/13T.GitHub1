using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Git_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     Feladat 00");
            Console.WriteLine("Hello World");
            Console.WriteLine("Első github repoo");
            //Feladat 1
            Console.WriteLine("     Feladat 1");

            //int tombmeret = Convert.ToInt32(Console.ReadLine());
            int tombmeret = 10;

            int[] tomb10 = new int[10];
            for (int i = 1; i < tomb10.Length+1; i++)
            {
                Console.WriteLine("Kérek 10 számot");
                Console.WriteLine("Kérem írja be az "+ i +". számot");
                tomb10[i-1] = Convert.ToInt32(Console.ReadLine());

            }

            int max = tomb10[0];
            for (int i = 1; i < tombmeret; i++)
            {
                if (tomb10[i] > max) max = tomb10[i];
            }
            Console.WriteLine("A legnagyobb szám a tömbben:" + max);

        
            

            Console.ReadKey();

        }
    }
}
