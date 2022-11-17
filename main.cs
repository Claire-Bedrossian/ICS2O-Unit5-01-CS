// Created by: Claire Bedrossian
// Created on: Nov 2022
//
// This program is a game to guess a random number the computer has generated.

using System;

class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        // This function accepts user input
        float guess;
        // Returns an `int` value greater in the range 10 <= value < 50
        float num = random.Next(1, 6);

        Console.WriteLine("Pick a number from one to six on the slider below. You must try and guess the random number the computer has chosen...");
        Console.WriteLine("");

        Console.Write("Enter your guess: ");
        guess = Convert.ToSingle(Console.ReadLine());

        if (guess == num)
        {
            Console.WriteLine("That is the right answer.");
        }

        if (guess != num)
        {
            Console.WriteLine("That is the wrong answer.");
        }
        Console.WriteLine("");
        Console.WriteLine("\nDone.");
    }
}