using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

           int[] myfirstArray = new int[5] { 1, 2, 3, 4, 5};

            /*for(int i = 0; i<myfirstArray.Length;i++)
             {
                 Console.WriteLine(myfirstArray[i]);
             }

             for (int i = myfirstArray.Length-1; i >=0; i--)
             {
                 Console.WriteLine(myfirstArray[i]);
             }*/

            //Overwriting array values

            /*myfirstArray[0] = myfirstArray[0] * 100;
            myfirstArray[4] = myfirstArray[4] * 100;

            for (int i = 0; i < myfirstArray.Length; i++)
            {
                Console.WriteLine(myfirstArray[i]);
            }
            */
            
            for (int i = 0; i < myfirstArray.Length; i++)
            {
                myfirstArray[i] = myfirstArray[i] * 100;
                Console.WriteLine(myfirstArray[i]);
            }
            

            Console.ReadLine();

        }
    }
}
