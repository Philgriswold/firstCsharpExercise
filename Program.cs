using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Adam";
            int cohort = 34;
            // reassigning variables
            name = "Jisie";
            cohort = 35;
            // String concatenation
            string greeting = "Hello " + name + ". Welcome to cohort " + cohort;
            // String interpolation
            string greeting2 = $"Hello {name}. Welcome to Cohort {cohort}";

            // declare Boolean variable
            bool isTheBest = cohort == 35;

            // condition
            if (isTheBest)
            {
                Console.WriteLine("Ah, the best around");
            }
            else if (name == "Jisie")
            {
                Console.WriteLine("She's Cool");
            }
            else
            {
                Console.WriteLine("You may... want to rethink your decisions");
            }

            // Loops
            int[] cohorts = new int[] { 34, 35, 36, 37 };

            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }

            foreach (int c in cohorts)
            {
                Console.WriteLine($"Cohort {c}");
            }

            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);
            }

            // Console.WriteLine(greeting2);
        }
    }
}