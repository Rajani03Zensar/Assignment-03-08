using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArray = new string[4]{ "Zebra", "Ant", "Owl", "Lion" };
            Array.Sort(MyArray);
            //for loop
            Console.WriteLine("For Loop");
            for(var i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
            Console.WriteLine("--------------");
            //foreach loop
            Console.WriteLine("Foreach Loop");
            foreach(var r in MyArray)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("-------------");
            //dowhile loop
            Console.WriteLine("Dowhile loop");
            var arr = 0;
            do
            {
                Console.WriteLine(MyArray[arr]);
                arr++;
            } while (arr<MyArray.Length);
            Console.WriteLine("------------");
            //while loop
            Console.WriteLine("while loop");
            var arr1 = 0;
            while (arr1 < MyArray.Length)
            {
                Console.WriteLine(MyArray[arr1]);
                arr1++;
            }

            string[] animal = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] places = { "Africa", "New Zealand", "Jamaica", "India" };

            Array.Sort(animal);
            Array.Sort(places);
            Console.WriteLine("---------------------");
            foreach(var ani in animal)
            {
                Console.WriteLine(ani);
            }
            Console.WriteLine("-------------------------");
            foreach(var place in places)
            {
                Console.WriteLine(place);
            }
            Console.Read();
        }
    }
}
