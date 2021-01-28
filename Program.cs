using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27WorkEvening
{
    class Program
    {
        static void Main(string[] args)
        {
            //create pay calculator from scratch, take user inputs.

            Console.WriteLine("Please enter your rate, in dollars/hour: ");
            int rate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Now enter your hours worked this week: ");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            int totalPay = rate * hoursWorked;
            Console.WriteLine("Your pay this week is: " + "$" + totalPay + " ....   " +
                "Great Job! .....  Press enter to continue....");
            Console.ReadLine();

            //create a loop that take in a variable to start, 
            //and another to end, numbers that will print to the screen

            Console.WriteLine("Choose a number to start this loop: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Try adding five to your chosen number, press enter, and the loop will print ");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i < y; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            //create a method to print the minutes in a lifetime

            double MethodToCalculateMinutesInLifetime (double enteredAge/*years*/)
            {
                double result;
                result = (enteredAge * 365 * 24 * 60 * 60);
                return result;
            }
            {
                Console.WriteLine("Tyoe your age as a two-digit number: ");
                double yourAge = Convert.ToDouble(Console.ReadLine());
                double yourLifeInMinutes = MethodToCalculateMinutesInLifetime(yourAge);
                Console.WriteLine("You have lived " + yourLifeInMinutes + " minutes in your life.  Can you believe it?");
                Console.ReadLine();

            }

            
        }
        
    }
}
