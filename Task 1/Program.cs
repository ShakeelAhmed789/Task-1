using System;

namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            int age;
            int favNumber;
            int magicNumber;

            Console.WriteLine("****** Personal Profile Generator ******\n");

            Console.Write("Enter your full name: ");
            fullName = Console.ReadLine();

            Console.Write("\nEnter you age: ");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("\nInvalid Input." +
                              "\nPlease, enter your age again: ");
            }


            Console.Write("\nEnter you favorite number: ");
            while (!int.TryParse(Console.ReadLine(), out favNumber))
            { 
                Console.Write("\nInvalid Input." +
                              "\nPlease enter your favorite number again: ");
            }

            magicNumber = age * favNumber;

            Console.WriteLine("\n\n****** User's details ******");
            Console.WriteLine($"\nFull Name: {fullName}" +
                                $"\nAge: {age}" +
                                $"\nFavorite number: {favNumber}" +
                                $"\nMagic Number: {magicNumber}"
                             );
        }
    }
}

/* ******** Difference between int.Parse() and int.TryParse() ********

int.Parse() converts a string to an integer but crashes if the input is invalid.
int.TryParse() safely checks and converts the input without crashing.

Example:

int.Parse("123");      // Returns 123
int.Parse("abc");      // Crashes

int.TryParse("123", out int n); // true
int.TryParse("abc", out n);     // false

Use TryParse() for user input because it is safer.

 */
