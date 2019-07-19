using System;

namespace Lab_6_Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Squares and Cubes\n");
            bool input1 = true;
            while (input1)
            {   
                Console.WriteLine("Please enter a number.");

                int num3 = ParseInput();

                Console.WriteLine($"\tNumber \tSquare \tCube");
                Console.WriteLine("\t====================");

                for (int i = 1; i <= num3; i++)
                {
                    Console.WriteLine($"\t{i} \t{ToSquare(i)} \t{ToCube(i)}");
                }
                Console.WriteLine("\nWould you like to continue? y/n");
                string userinput = Console.ReadLine();

                if (userinput == "y")
                {
                    
                }
                else
                {
                    Console.WriteLine("\nGood bye");
                    input1 = false;
                }



            }


        }
        public static void UserInput2(int squaringCubing)
        {
        }
        public static int ParseInput()
        {
            return int.Parse(Console.ReadLine());
        }
        public static int ToSquare(int num)
        {
            return num * num;

        }
        public static int ToCube(int num)
        {
            return num * num * num;
        }
    }
}
