using System;

namespace Part_3a_Console_Input
{
    class Program
    {
        static void Main(string[] args)
        {

            //Greetings
            int year;
            string name;
            int age;
            Console.WriteLine("Greetings");
            Console.WriteLine("Hello User, please enter your name:");

            DateTime currentDate = DateTime.Now;
            year = (currentDate.Year);
            name = Console.ReadLine();
            Console.WriteLine($"Your name is name {name}");
            Console.WriteLine("Now please enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your are {age} years old. You were born in the year {year - age}.");
            Console.WriteLine();
            Console.WriteLine();

            //Adder
            Console.WriteLine("Adder");
            Console.WriteLine("Please enter 3 Integers into the program:");
            int number1;
            int number2;
            int number3;
            Console.WriteLine("Enter first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third Number");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 + number2 + number3);
            Console.WriteLine();
            Console.WriteLine();

            //Distance
            Console.WriteLine("Distance");
            Console.WriteLine("Please enter 3 distances in km");
            double distance1;
            double distance2;
            double distance3;
            double distance4;
            Console.WriteLine("Enter first distance");
            distance1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second distance");
            distance2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third distance");
            distance3 = Convert.ToDouble(Console.ReadLine());
            distance4 = (distance1 + distance2 + distance3);
            Math.Round(distance4, 2);
            Console.WriteLine($"The total distance is {distance4}");
            Console.WriteLine();
            Console.WriteLine();

            //Hypotenuse
            double lengthA;
            double lenghtB;
            double lenghtC;
            double valueAB;

            Console.WriteLine("Please enter the lenght of 2 lines A & B to get the lenght of Hypotenuse");
            Console.WriteLine("Enter lenght of A");
            lengthA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter lenght of B");
            lenghtB = Convert.ToDouble(Console.ReadLine());
            valueAB = (lengthA * lengthA) + (lenghtB * lenghtB);
            lenghtC = Math.Sqrt(valueAB);
            lenghtC = Math.Round(lenghtC, 2);
            Console.WriteLine($"The length of the hypotenuse C is {lenghtC}");
        }
    }
}
