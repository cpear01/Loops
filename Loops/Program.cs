using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loops: used for iteratation, goes thru each instance
            //Powerpoint example:
            string[] days = { "Monday", "Tuesday", "Wednesday", };
            foreach(string item in days)  //item is a temporary variable, could be string day in days instead  foreach is Keyword
            {
                Console.WriteLine(item);
            }

            //#1 Class example:
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            foreach(string month in months)
            {
                Console.WriteLine(month); //prints out all the months: Jan Feb Mar Apr May Jun Jul Aug Sep Oct Nov Dec (beginning to end)
            }

            string[] bestMonth = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            foreach (string month in months)
            {
                Console.WriteLine(bestMonth);
                if(month =="Dec")
                {
                    Console.WriteLine("That's the best month.");
                }
                else
                {
                    Console.WriteLine("That month is ok I guess");
                }


             //#2
             string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
             foreach(string band in musicians)
             {
                 Console.WriteLine(band);
             }

             //temp name needs to be the same data type as the array is (can't do a int in a string array)

             //#3 In class: Create a program that asks the user for their fav foods (3) and stores that value in an array
             //Loop through the array and print all of the foods

             Console.WriteLine("Please tell me your favorite foods");
             string[] favFood= { "pizza", "burgers", "pasta" };
             foreach(string item in favFood)
                {
                    Console.WriteLine(item);
                }

          
            


            //#4 In class: Create an array of lucky numbers using a foreach loop & print the following: 
            // Your Lucky numbers is: 4
            // Your Lucky numbers is 19
            // Your Lucky numbers is: 7




            }






        }
    }
}
