using System;
using System.Collections;
namespace Assignmet1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            double Number1, Number2;
            char Operation;
            Console.Write("enetr frist number ");
            Number1 = double.Parse(Console.ReadLine());
            Console.Write("enter the operation ");
            Operation = char.Parse(Console.ReadLine());
            Console.Write("enetr second  number ");
            Number2 = double.Parse(Console.ReadLine());
            switch (Operation)
            {
                case '+':
                    Console.WriteLine($"{Number1} + {Number2} = {Number1 + Number2}");
                    break;
                case '-':
                    Console.WriteLine($"{Number1} - {Number2} = {Number1 - Number2}");

                    break;
                case '*':
                    Console.WriteLine($"{Number1} * {Number2} = {Number1 * Number2}");
                    break;
                case '/':
                    if (Number2 == 0)
                        Console.WriteLine("erro");
                    else
                        Console.WriteLine($"{Number1} / {Number2} = {Number1 / Number2}");
                    break;
                case '%':
                    Console.WriteLine($"{Number1} % {Number2} = {Number1 % Number2}");
                    break;
                default:
                    Console.WriteLine("wrong choosing ");
                    break;

            }
            Console.ReadKey();


        }
    }
}