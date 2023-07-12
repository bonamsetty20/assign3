using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string to integer
            string intString = "123";
            int convertedInt;

            // Using TryParse to convert a string to an integer
            if (int.TryParse(intString, out convertedInt))
            {
                Console.WriteLine("Successfully converted string to integer: " + convertedInt);
            }
            else
            {
                Console.WriteLine("Failed to convert string to integer.");
            }

            string doubleString = "3.14";
            double convertedDouble;

            // Using Convert to convert a string to a double
            try
            {
                convertedDouble = Convert.ToDouble(doubleString);
                Console.WriteLine("Successfully converted string to double: " + convertedDouble);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format for conversion to double.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow occurred during conversion to double.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred during conversion to double.");
            }
            string decimalString = "12.34";
            decimal convertedDecimal;

            // Using Parse to convert a string to a decimal
            try
            {
                convertedDecimal = decimal.Parse(decimalString);
                Console.WriteLine("Successfully parsed string to decimal: " + convertedDecimal);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format for parsing to decimal.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow occurred during parsing to decimal.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred during parsing to decimal.");
            }
            // Convert a string to an integer using TryParse
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                int result = number * 5;
                Console.WriteLine($"The result is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            // Convert a string to a DateTime object using Convert
            Console.WriteLine("Enter a date (MM/dd/yyyy): ");
            string dateInput = Console.ReadLine();
            try
            {
                DateTime date = Convert.ToDateTime(dateInput);
                DateTime newDate = date.AddMonths(-1);
                Console.WriteLine($"One month ago was: {newDate.ToShortDateString()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid date in the format MM/dd/yyyy.");
            }
            // Convert a string to a TimeSpan object using Parse
            Console.WriteLine("Enter a time (hh:mm:ss): ");
            string timeInput = Console.ReadLine();
            try
            {
                TimeSpan time = TimeSpan.Parse(timeInput);
                TimeSpan newTime = time.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Two hours later will be: {newTime.ToString()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid time in the format hh:mm:ss.");
            }
        }
    }


}
   
