using System;
using System.Linq;

namespace Week4Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new[]
            {
                new Person {Name = "Bo", Age = 20, WorkplaceId = 1},
                new Person {Name = "Li", Age = 30, WorkplaceId = 1},
                new Person {Name = "An", Age = 40, WorkplaceId = 2},
                new Person {Name = "Em", Age = 50, WorkplaceId = 1},
                new Person {Name = "Jo", Age = 60, WorkplaceId = 1},
                new Person {Name = "Ia", Age = 25, WorkplaceId = 2},
                new Person {Name = "Lo", Age = 35, WorkplaceId = 2},
            };

            var workplaces = new[]
            {
                new Workplace {CompanyName = "ICA", WorkplaceId = 1},
                new Workplace {CompanyName = "Coop", WorkplaceId = 2},
            };

            var over30 = employees
                .Where(e => e.Age > 30)
                .OrderBy(e => e.Name)
                .ThenBy(e => e.Age)
                .Select(e => e.Name);

            Console.WriteLine("Employees over 30: ");
            foreach (var employee in over30)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("---");

            var under30 = employees
                .Count(e => e.Age < 30);

            Console.WriteLine("Number of employees under 30: ");
            Console.WriteLine(under30);


            Console.WriteLine("---");

            var averageAge = employees
                .Average(e => e.Age);

            Console.WriteLine("Average age of employees: ");
            Console.WriteLine(averageAge);

            Console.WriteLine("---");


            Console.WriteLine("Enter a name: ");
            string input = Console.ReadLine();

            var isNameInList = employees
                .Where(e => e.Name == input)
                .FirstOrDefault();
            Console.WriteLine(isNameInList);

            Console.WriteLine("---");

            WhoWorksWhere(employees, workplaces);

            Console.WriteLine("---");

            NumberOfEmployeesAtWorkplace(employees, workplaces);
        }

        private static void WhoWorksWhere(Person[] employees, Workplace[] workplaces)
        {
            var join = workplaces
                .Join(employees, w => w.WorkplaceId, e => e.WorkplaceId, (w, e) => new
                {
                    WorkPlace = w.CompanyName,
                    EmployeeName = e.Name
                }) ;
            foreach (var item in join)
            {
                Console.WriteLine($"{item.EmployeeName} works at {item.WorkPlace}.");
            }
        }

        private static void NumberOfEmployeesAtWorkplace(Person[] employees, Workplace[] workplaces)
        {
            var groupJoin = workplaces
                .GroupJoin(employees, w => w.WorkplaceId, e => e.WorkplaceId, (w, place) => new
                {
                    WorkPlace = w.CompanyName,
                    WorkPlaceCount = place.Count()
                });
            foreach (var item in groupJoin)
            {
                Console.WriteLine($"There are {item.WorkPlaceCount} people working at {item.WorkPlace}");
            }
        }
    }
}
