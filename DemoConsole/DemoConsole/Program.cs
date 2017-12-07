using DemoConsole.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EF Core Demo:\n");

            using (var context = new ActorDBContext())
            {
                //Delete old data
                context.Actors.Load();
                context.Actors.Local.Clear();
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Actors', RESEED, 0);");
                context.SaveChanges();

                //Load initial data
                context.Actors.AddRange(
                    new Actor() { Name = "Bruce Lee", Age = 35, AcademyWinner = false },
                    new Actor() { Name = "Sharon Stone", Age = 21, AcademyWinner = false },
                    new Actor() { Name = "Jack Nicolson", Age = 71, AcademyWinner = true },
                    new Actor() { Name = "John Doe", Age = 27, AcademyWinner = true },
                    new Actor() { Name = "Arnold Shwarzineger", Age = 65, AcademyWinner = false },
                    new Actor() { Name = "James Baldwin", Age = 60, AcademyWinner = true },
                    new Actor() { Name = "Jenifer Lopez", Age = 25, AcademyWinner = false }
                    );

                //Save the data
                int count = context.SaveChanges();

                //Fetch the data
                Console.WriteLine($"{count} additional records added.\n");

                ConsoleColor bg = Console.BackgroundColor;
                ConsoleColor fg = Console.ForegroundColor;

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(String.Format("| {0,-2} | {1,-20} | {2,10} |", "ID", "Name", "Award Winner"));
                Console.WriteLine("--------------------------------------------");

                Console.BackgroundColor = bg;
                Console.ForegroundColor = fg;

                context.Actors.Load();
                var actors = context.Actors.Local.OrderBy((o) => o.Id).ToList();
                actors.ForEach((a) => Console.WriteLine($"| {a.Id, -2} | {a.Name, -20} | {a.AcademyWinner, 12} |"));

                Console.WriteLine("--------------------------------------------");

            }

            Console.ReadKey();
        }
    }
}
