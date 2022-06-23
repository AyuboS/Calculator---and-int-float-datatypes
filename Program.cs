using System;

namespace _01_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press '+' to add or '-' to subtract | Press '*' to multiply or '/' to divide ");
            char firstAnswer = char.Parse(Console.ReadLine());

            Console.WriteLine("Press 'i' for int or 'f' to float");
            char secondAnswer = char.Parse(Console.ReadLine());

           


            if (firstAnswer == '+')
            {
                if (secondAnswer == 'i')
                {
                    Console.WriteLine("Enter the first value: ");
                    int first = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second value: ");
                    int second = int.Parse(Console.ReadLine());

                    int result = first + second;
                    Console.WriteLine($"The result is {result}");
                }

                else
                {
                    Console.WriteLine("Enter the first value: ");
                    float first = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second value: ");
                    float second = float.Parse(Console.ReadLine());

                    float result = first + second;
                    Console.WriteLine($"The result is {result}");
                }


            }

            else if (firstAnswer == '-')
            {
                if (secondAnswer == 'f')
                {
                    Console.WriteLine("Enter the first value: ");
                    float first = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second value: ");
                    float second = float.Parse(Console.ReadLine());

                    float result = first - second;
                    Console.WriteLine($"The result is {result}");
                }

                else
                {
                    Console.WriteLine("Enter the first value: ");
                    int first = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second value: ");
                    int second = int.Parse(Console.ReadLine());

                    int result = first - second;
                    Console.WriteLine($"The result is {result}");
                }
            }

            else if (firstAnswer == '*')
            {
                if (secondAnswer == 'i')
                {
                    Console.WriteLine("Enter the first value: ");
                    int first = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second value: ");
                    int second = int.Parse(Console.ReadLine());

                    int result = first * second;
                    Console.WriteLine($"The result is {result}");
                }

                else
                {
                    Console.WriteLine("Enter the first value: ");
                    float first = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second value: ");
                    float second = float.Parse(Console.ReadLine());

                    float result = first * second;
                    Console.WriteLine($"The result is {result}");
                }


            }

            else if (firstAnswer == '/')
            {
                if (secondAnswer == 'f')
                {
                    Console.WriteLine("Enter the first value: ");
                    float first = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second value: ");
                    float second = float.Parse(Console.ReadLine());

                    float result = first / second;
                    Console.WriteLine($"The result is {result}");
                }

                else
                {
                    Console.WriteLine("Enter the first value: ");
                    int first = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second value: ");
                    int second = int.Parse(Console.ReadLine());

                    int result = first / second;
                    Console.WriteLine($"The result is {result}");
                }
            }

        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static float Add(float x, float y)
        {
            return x + y;
        }

        static float Subtract(float x, float y)
        {
            return x - y;
        }

        static int Multilpy(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }

        static float Multilpy(float x, float y)
        {
            return x * y;
        }

        static float Divide(float x, float y)
        {
            return x / y;
        }


    }
}
