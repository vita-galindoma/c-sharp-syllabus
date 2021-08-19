using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                choice = GetMenu();

                if (choice == 1)
                {
                    Console.WriteLine("\nYou chose 1");
                    CalculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nYou chose 2");
                    CalculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\nYou chose 3");
                    CalculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\nThanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int GetMenu()
        {

            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            int.TryParse(keyboard.KeyChar.ToString(), out userChoice);

            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("\nPlease enter a valid range: 1, 2, 3, or 4: ");
                keyboard = Console.ReadKey();
                userChoice = keyboard.KeyChar;
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");
            var keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out var radius);
            Console.WriteLine("The circle's area is "
                              + Geometry.AreaOfCircle((double)radius));
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter length? ");
            var keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out decimal length);


            Console.WriteLine("Enter width? ");
            keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out decimal width);

            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {

            Console.WriteLine("Enter length of the triangle's base? ");
            var keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out decimal ground);

            Console.WriteLine("Enter triangle's height? ");
            keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out decimal height);

            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
