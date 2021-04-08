using System;

namespace Learning_c_
{
    class Program
    {
        // My journey with the basics of C# begins here!!
        static void Main(string[] args)
        {
            // variables are declared here first with an identifier of the variable type
            // then the name of the variable.
            // variables can be changed later (characterAge = 70). subsequent code will then
            // refer to characterAge as the integer 70
            string characterName = "John";
            int characterAge = 35;
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
         


            // basic variable types
            // string phrase = "Giraffe Academy";
            // char grade = 'A';
            // int age = 30;
            // double gpa = 3.2;
            // bool isMale = false;

            // strings in C#

            Console.WriteLine("Giraffe\"Academy");
            // \n is a new line
            // \" includes that parantheses into the string.
            string phrase = "Giraffe Academy";

            Console.WriteLine (phrase.ToUpper());
            Console.WriteLine (phrase.Contains("Academy"));
            // returns a boolean. will retrun True since phrase contains Academy
            Console.WriteLine (phrase[0]);
            // grabs value at index position 0 which is G
            Console.WriteLine (phrase.IndexOf("Academy"));
            // the starting index position of Academy, which is 8
            // if you ever get a -1, that means that the character or value is not present.
            Console.WriteLine (phrase.Substring(8));
            // grabs characters starting at 8 and then finishes the string
             Console.WriteLine (phrase.Substring(8, 3));
            //  grabs 3 valuse starting at 8
            Console.ReadLine();

        // numbers, different types

         Console.WriteLine(5 - 8);
        //  does the math for us +, /, *, (5 % 2) PEMDAS still applies. use parantheses to change order of operations.

        // methods

        Console.WriteLine(Math.Abs(-1));
        // Abs = absolute value 
        // Pow(3,2) = power of 3 to the 2nd power
        // Sqrt() = square root
        // Max =(4,90) = largest number would be 90
        

        // GETTING INPUT FROM A USER

        // Write does not move the functions along, Writeline does

        Console.Write("Enter your name:");
        string name = Console.ReadLine();
        string age = Console.ReadLine();
        Console.WriteLine("Hello" + name + " you are " + age);

        }
    }
}
