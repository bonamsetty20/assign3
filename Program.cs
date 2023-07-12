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
        }
    }


}
   
