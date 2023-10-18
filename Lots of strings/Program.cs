 using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lots_of_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Be familiar with and be able to use:
            string myString = "This is a string";

            //----------------------------------------length----------------------------------------
            Console.WriteLine(myString.Length);

            //---------------------------------------position---------------------------------------
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString[myString.Length - 1]); //common mistake - not including the -1 and pointing+
            //to a location in the array that does not exist (last index is length -1 as indexing starts at 0
            for(int i = 0; i<myString.Length; i++)
            {
                Console.WriteLine(myString[i]); //loops through all the chars in string
            }

            //---------------------------------------substring---------------------------------------
            //a substring is a part of a string
            Console.WriteLine(myString.Substring(4,5)); //starts at index 4 and continues for 5 characters from 4
            //cannot refer to an index outside of array or will cause a syntax error


            //-------------------------------------concatenation-------------------------------------
            //linking together strings
            Console.WriteLine("value of string = " + myString);
            Console.WriteLine("myString is '" + myString + "'!");
            Console.WriteLine($"this is a string '{myString}' look at it!");
            Console.WriteLine($"{myString} {myString}"); //this will still have a space in the output
            Console.WriteLine("Using parameters to join {0}", myString);
            string first = "First string";
            string second = "Second string";
            Console.WriteLine("using + to join " + first + " " + second);
            Console.WriteLine($"using string formatter to join {first} {second}");
            Console.WriteLine("Using parameters to join {0} {1}", first, second);


            //-------------------------------character → character code-------------------------------
            char aChar = 'A';
            Console.WriteLine(Convert.ToInt32(aChar));
            aChar = '1';
            Console.WriteLine(Convert.ToInt32(aChar));

            //-------------------------------character code → character-------------------------------

            Console.WriteLine(Convert.ToChar(65));
            for (int i =65; i<91; i++) //can also just use convert if you dont know the ASCII value

            {
                Console.Write(Convert.ToChar(i));
            }

            Console.WriteLine();

            //------------------------------string conversion operations------------------------------
            //expected string conversion operations:

            //***string to integer***
            int numInput;
            Console.Write("Enter a number: ");
            numInput = Convert.ToInt32(Console.ReadLine()); //takes input and stores it as a number

            //***string to float***
            double floatInput;
            Console.Write("Please enter a float number: ");
            floatInput = Convert.ToDouble(Console.ReadLine());

            //***integer to string***
            Console.WriteLine(numInput + " is the number"); //this works as it is taken as a string
            Console.WriteLine(numInput.ToString() + " is the number"); //this converts to string
            Console.WriteLine(numInput.ToString().Length); //gives length of number string (doesnt work for int)
            Console.WriteLine(Convert.ToString(numInput));

            //***float to string***
            Console.WriteLine(floatInput.ToString());
            Console.WriteLine(Convert.ToString(floatInput));

            //***date / time to string***
            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToString());

            //***string to date / time***
            string DOB = "03/01/2007";
            DateTime DOBAsDate = Convert.ToDateTime(DOB);
            Console.WriteLine(DOBAsDate.DayOfWeek);

            Console.ReadLine();
        }
    }
}
