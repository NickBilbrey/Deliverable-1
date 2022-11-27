using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string confirm;
        do
        {
            Console.WriteLine("How many people are we making PB&J sandwhiches for?");
            int x = int.Parse(Console.ReadLine());
            int b = 2 * x;
            int p = 2 * x; /*dictates the amount of ingredients needed*/
            int j = 4 * x;

            int l = b / 28;
            int n = p / 32; /*dictates supplies needed*/
            int g = j / 48;
            int l1 = (int)(l + 0.5);
            int n2 = (int)(n + 0.5);
            int g2 = (int)(g + 0.5);
            if (x > 0)
            {
                Console.WriteLine($"you will need {b} slices of bread {p} tablespoons of peanut butter {j} teaspoons of jelly which is {l1} loaves of bread {n2} jars of peanut butter {g2} jars of jelly"); /*lists number of ingerdientes for the sandwhiches*/
            }
            else
            {
                Console.WriteLine("no sandwhiches for you!");
            }
            Console.WriteLine("would you like to restart? enter y or yes to continue, enter any other key to exit");
            confirm = Console.ReadLine();
        }
        while (confirm == "yes"||confirm == "y");

        Console.WriteLine("GoodBye");
      }
    }

