using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonaccy
            Console.WriteLine("Task 1:");
            int firstNumber = 0;
            int secondNumber = 1;
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(firstNumber);
                }
                else if (i == 1)
                {
                    Console.WriteLine(secondNumber);
                }
                else
                {
                    int thirdnumber = firstNumber + secondNumber;
                    Console.WriteLine(thirdnumber);
                    firstNumber = secondNumber;
                    secondNumber = thirdnumber;
                }
            }

            //Task 2
            Console.WriteLine("Task 2:");

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            //Task 3
            Console.WriteLine("Task 3:");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    int result = i * j;
                    Console.WriteLine("{0} * {1} = {2} ", i, j, result);
                }
            }

            //Task 4
            Console.WriteLine("Task 4:");

            string password = "qwerty";
            Console.WriteLine("Enter the password:");
            string input = Console.ReadLine();
            int index = 0;
            do
            {
                char a = password[index];
                char b = input[index];
                index++;

                if (password.Length != input.Length || b != a)
                {
                    Console.WriteLine("Wrong password!");
                    break;
                }
                else if (index == password.Length - 1)
                {
                    Console.WriteLine("Password is correct");
                }
            }
            while (index <= password.Length - 1);

            Console.ReadLine();
        }
    }
}
