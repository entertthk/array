using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringArray
{
    class Program
    {
        static void Main(string[] args)
        {

            /*String[] myFirstStringArray;

            myFirstStringArray = new string[5] {"one", "two", "three", "four", "five"};

            
            for(int i= 0; i <myFirstStringArray.Length; i++)
            {
                Console.WriteLine(myFirstStringArray[i]);
            }

            for (int i = myFirstStringArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myFirstStringArray[i]);
            }*/

            String[] fruits = new string[5];

            for(int i = 0; i < 5;i++)
            {
                Console.WriteLine("Name some fruit:");
                fruits[i] = Console.ReadLine();
            }
            
            foreach(string fruit in fruit)
            {
                Console.WriteLine($"You have eneterd: {fruit}");
            }

            Console.ReadLine();

        }
    }
}
