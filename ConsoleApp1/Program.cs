using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int yearOfBirth;
            int age;

            Console.WriteLine("Enter your year of birth: ");
            yearOfBirth = int.Parse(Console.ReadLine());

            age = CalculateAge(yearOfBirth, 2019);

            Console.WriteLine($"You are {age} years old");


            int ageNextYear = CalculateAgeNextYear(age);
            Console.WriteLine($"Next year you are {ageNextYear}");

            CalculateDifference(yearOfBirth);

            
            

            Console.ReadLine();
        }

        public static int CalculateAge(int yearOfBirth, int currentYear)
        {
            /*int result = currentYear - yearOfBirth;
            return result;*/

            return currentYear - yearOfBirth;

        }

        public static int CalculateAgeNextYear(int userAge)
        {
           return userAge +1;
            
        }

        public static void CalculateDifference(int yearOfBirth)
        {
            if(yearOfBirth < 1926)
            {
                Console.WriteLine($"You are{yearOfBirth - 1926} year(s) younger than queen");
            }

            else if(yearOfBirth > 1926)
            {
                Console.WriteLine($"You are{1926 - yearOfBirth} year(s) older than queen");
            }


            else
            {
                Console.WriteLine("Are you the queen");
            }
            
        }
        

    }
}
