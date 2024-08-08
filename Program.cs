
using System;
class Program
{
    // 1. C# Intro "Hello world"
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        // 2. Program that prints your name and the current date and time

        string name = "Tushar Shukla";
        DateTime currentDateTime = DateTime.Now;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Current Date and Time: " + currentDateTime);

        // 3. Program that declares an integer variable, assigns it a value, and prints it.

        int number;
        number = 18;
        Console.WriteLine("The value of the integer variable is:" + number);

        // 4. Program that outputs "Welcome to C# Programming!" and "This is an example of output in C#"

        Console.WriteLine("Welcome to C# Programming!");

        Console.WriteLine("This is an example of output in C#");

        // 5. : Add both single-line and multi-line comments to the following code:

        // Console.WriteLine("This will run.");
        /* Console.WriteLine("This will run.");
        Console.WriteLine("This will not run.");*/

        //: 6. Declare variables of different data types and print their values.

        int integerVar = 42;
        double doubleVar = 3.14159;
        char charVar = 'A';
        string stringVar = "Hello, World!";
        bool boolVar = true;

        // Print the values of the variables
        Console.WriteLine("Integer value: " + integerVar);
        Console.WriteLine("Double value: " + doubleVar);
        Console.WriteLine("Character value: " + charVar);
        Console.WriteLine("String value: " + stringVar);
        Console.WriteLine("Boolean value: " + boolVar);

        // 7. Program that demonstrates different data types and their initialization.

        int integerVar1 = 42;
        float floatVar = 3.14F;
        char charVar1 = 'A';

        Console.WriteLine("Integer value: " + integerVar1);
        Console.WriteLine("Float value: " + floatVar);
        Console.WriteLine("Character value: " + charVar1);

        // 8. 
        // Simplicit fuction - char -> int -> long -> float -> double
        int i = 100;
        float f = i;
        Console.WriteLine(f);

        //Explicit fuction - double -> float -> long -> int -> char
        float f1= 123.45F;
        int i1 = (int)f1;
        Console.WriteLine(i1);

        /* another way
        float f1 = 123.45F;
        int i1 = convert.Toint32(f1);
        Console.WriteLine(i1);*/

        // 9.Program that takes user input for their name and age and prints it.
        int age;
        Console.WriteLine("Enter your age");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("You look younger than {0} ", age);

        // 10 : Program to demonstrate the use of arithmetic operators
        int a = 10;
        int b = 5;
        int sum = a + b;          // Addition
        int difference = a - b;   // Subtraction;

        Console.WriteLine("Arithmetic Operators Demonstration:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("Sum (a + b): " + sum);
        Console.WriteLine("Difference (a - b): " + difference);

        // 11. Program to demonstrate the use of the Math class.
        double number1 = 25.0;
        double exponent = 3.0;
        double sqrtNumber = Math.Sqrt(number1); // Square root of number

        // Calculate power
        double power = Math.Pow(number1, exponent); // number raised to the power of exponent

        // Print the results
        Console.WriteLine("Math Class Demonstration:");
        Console.WriteLine("Square root of " + number1 + ": " + sqrtNumber);
        Console.WriteLine(number1 + " raised to the power of " + exponent + ": " + power);

        // 12 Program that demonstrates string concatenation and string methods.

        // Declare and initialize string variables
        string firstName = "Alice";
        string lastName = "Smith";

        // String concatenation
        string fullName = firstName + " " + lastName;

        // Use a string method (ToUpper)
        string upperCaseName = fullName.ToUpper(); // Convert the full name to uppercase

        // Print results
        Console.WriteLine("Full Name: " + fullName);
        Console.WriteLine("Full Name in Uppercase: " + upperCaseName);

        // 13 : Program that demonstrates the use of boolean variables
        // Declare and initialize boolean variables
        bool isTrue = true;
        bool isFalse = false;

        // Print the values of boolean variables
        Console.WriteLine("The value of isTrue: " + isTrue);
        Console.WriteLine("The value of isFalse: " + isFalse);

        // 14 : Program that uses if...else statements to check if a number is positive, negative, or zero

        // Declare and initialize a number
        int number2 = 7;

        if (number2 > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number2 < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        // 16 Write a C# program that prints numbers from 1 to 10 using a while loop.

        int l = 1;

        // While loop to print numbers from 1 to 10
        while (l <= 10)
        {
            Console.WriteLine(l);
            l++;
        }

        // 17 Program that prints the first 10 even numbers using a for loop.

        for (int j = 1; j <= 10; j++)
        {
            int evenNumber = j * 2;
            Console.WriteLine(evenNumber);
        }

        // 18 Program that demonstrates the use of break and continue statements in a loop.
        int k;
        for (k = 0; k <= 10; k++)
        {
            if (k == 5)
                continue;
            if (k == 8)
                break;
            Console.WriteLine("value is" + k);
        }
        /* 19 Program that declares an array of integers, assigns values,
        and prints them. Add functionality to find the sum of all elements in the array.*/


        // Declare and initialize an array of integers
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Print all elements in the array
        Console.WriteLine("Array elements:");
        foreach (int number4 in numbers)
        {
            Console.WriteLine(number4);
        }

        // Calculate the sum of all elements
        int sum1 = 0;
        foreach (int number4 in numbers)
        {
            sum1 += number4;
        }

        // Print the sum of all elements
        Console.WriteLine("Sum of all elements: " + sum);


        // 15 Program that uses a switch statement to print the day of the week based on a number input (1-7).

        // Declare and initialize the number for the day of the week
        int dayNumber = 3;

        // Determine the day of the week using a switch statement
        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
                break;


        }
    }
}





            

























