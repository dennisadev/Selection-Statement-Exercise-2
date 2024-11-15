using System;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is fun!");
                    break;
                case "science":
                    Console.WriteLine("Science is fun!");
                    break;
                case "history":
                    Console.WriteLine("History is fun!");
                    break;
                case "english":
                    Console.WriteLine("English is fun!");
                    break;
                case "gym":
                    Console.WriteLine("Gym is fun!");
                    break;
                default:
                    Console.WriteLine("I don't know about that");
                    break;
             }
        }
    }
}