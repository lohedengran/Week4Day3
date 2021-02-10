using System;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var robots = new[]
            {
                new Robot("R2-D2", 500),
                new Robot("Bender", 50),
                new Robot("Wall-E", 1000),
                new Robot("Data", 9000)
            };

            int nr = 1;
            var expensiveRobots = robots
                .Where(r => r.Price > 500)
                .Select(r => new
                {
                    RowNr = nr++,
                    Model = r.Model,
                    Created = DateTime.Now,
                })
                .ToArray();
            
            foreach (var robot in expensiveRobots)
            {
                Console.WriteLine(robot);
            }

            Console.WriteLine();

            var longestModelName = robots
                .OrderByDescending(r => r.Model.Length)
                .ThenByDescending(r => r.Price)
                .First();
            Console.WriteLine(longestModelName);

        }
    }
}
