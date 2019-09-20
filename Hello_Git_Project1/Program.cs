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
            //1.Usertől kérjünk be 10 számot. Keressük meg, és írjuk ki a legnagyobbat!
            //2.Módosítsuk a programot, hogy a usertől a darabszámot is bekérjük, ne csak 10 elemre működjön!
            //3.Módosítsuk a programot, hogy a legnagyobb mellett a legkisebb elemet is megkeressük!

            Console.WriteLine("     Feladat 00");
            Console.WriteLine("Hello World");
            Console.WriteLine("Első github repoo");
            //FELADAT 1
            Console.WriteLine("     Feladat 1");
            //FELADAT 2
            Console.WriteLine(" A program modosult úgy, hogy a tömb méretét bekérjük");

            Console.WriteLine("Kérem méretezze a tömböt -- Feladat 2"); //Opcionális
            int tombmeret = Convert.ToInt32(Console.ReadLine()); //-->2. FELADAT
            //int tombmeret = 10; 

            int[] tomb10 = new int[tombmeret]; // A program modosult úgy, hogy a tömb méretét bekérjük
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
            Console.WriteLine("A legnagyobb szám a tömbben: " + max);

            //FELADAT 3
            int min = tomb10[0];
            for (int i = 1; i < tombmeret; i++)
            {
                if (tomb10[i] < min) min = tomb10[i];
            }
            Console.WriteLine("A legkisebb szám a tömbben:" + min);


         Console.ReadKey();

        }
    }
}
