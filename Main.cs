//DYLAN GRANDJEAN
//Program designed to demonstrate knowledge of arrays and their functionality
//April 14th, 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Assignment11
{
    class Main
    {
        static void Main(string[] args)
        {
            //Array instantiation
            string[] names = { "Ann", "Ray", "Joe", "Mary", "Lori" };

            //Method calls
            DisplayNames(names);
            CountNames(names);
            NumberArray();
            NamesArray();
        }

        //DisplayNames method displays the indexes from the array names
        private static void DisplayNames(string[] array)
        {
            //Declares an empty string
            string names = string.Empty;

            //Assignes array names to the string variable
            foreach (string item in array)
                names += item + "\n";

            //Display the string into a message box
            MessageBox.Show(names, "Display Name");
        }

        //CountNames method counts the number of indexes in the array names
        private static void CountNames(string[] array)
        {
            //Declare counter
            int count = 0;

            //Count the amount of indexes in array names and increments accordingly
            foreach (string item in array)
                count++;

            //Display amount of indexes into a message box
            MessageBox.Show("There are " + count + " names", "Names");
        }

        //NumberArray method fills and display a double array of user input
        private static void NumberArray()
        {
            //Variable instantiation
            string result = string.Empty;
            double[] numbers = new double[3];
            double inputValue;
            double total = 0;
            int i = 0;

            //Display instructions
            Console.WriteLine("Create numbers array - enter 3 numbers - Display array and total");

            //Prompts user for values to put into numbers array
            do
            {
                //Prompt user and get input
                Console.Write("Enter number, -99 to exit: ");
                inputValue = double.Parse(Console.ReadLine());
                //If input isn't -99, put it int the array
                if (inputValue != -99)
                {
                    numbers[i] = inputValue;
                    total += numbers[i];
                    result += numbers[i] + "\n";
                    i++;
                }
            } while (inputValue != -99 && i < 3);

            //Display values and their total into a message box
            MessageBox.Show(result + "Total is: " + total);
        }

        //NamesArray method calls in a class and fills and displas a string array of user input
        private static void NamesArray()
        {
            //Call class NameArray
            NameArray nameArray = new NameArray();

            //Display instructions
            Console.Write("********************\nEnter 3 names to send to class - display names from class\n");
            //Get user input
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter name: ");
                nameArray.Names = Console.ReadLine();
            }

            //Display user inputs into a message box
            nameArray.Display();
        }
    }
}
