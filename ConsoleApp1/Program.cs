﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Введите A");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите B");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию '+' '-' '*' '/'");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
            }
            Console.ReadLine();
        }
    }
}
