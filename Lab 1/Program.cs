// Week 13 Lab 1
// File Name: week13lab1.cs
// Author: Lucas Smith
// Date:  November 22, 2021
//
// Problem Statement: Create a test programs that uses optional parameters, named parameter and variable number of parameters.
// 
// 
// Overall Plan:
// 1) Create another class (randomly named)
// 2) Create some stuff inside using optional parameters
// 3) Run the code with different tests
using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrangeJuice tester = new OrangeJuice();

            Console.WriteLine(tester.returnOrange(7, "Lemonade", "Aaron"));
            Console.WriteLine(tester.returnOrange(6, "Coffee"));
            Console.WriteLine(tester.returnOrange(5));
        }
    }

    class OrangeJuice
    {
        public string returnOrange(int intOne, string stringOne = "Orange Juice", string stringTwo = "Lucas")
        {
            return (stringTwo + " drank " + stringOne + " " + intOne + " times");
        }
    }
}
