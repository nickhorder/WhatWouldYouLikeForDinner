using System;

namespace WhatWouldYouLikeForDinner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like for dinner?");
            string input = Console.ReadLine();
            Console.WriteLine($"Ah! {input} is an excellent choice!");
        }
    }
}
