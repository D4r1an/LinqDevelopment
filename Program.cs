using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Data Source */
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var querySintax = (from item in list where item < 7 select item).ToList();

            var methodSintax = list.Where(l => l > 7);

            var employees = new List<Employee>()
            {
                new Employee { Id= 1, Email="Tom@gmail.com", Name = "Tom"},
                new Employee { Id= 2, Email="john@gmail.com", Name = "John"},
                new Employee { Id= 3, Email="mark@gmail.com", Name = "Mark"},
                new Employee { Id= 4, Email="kim@gmail.com", Name = "Kim"},
                new Employee { Id= 4, Email="anna@gmail.com", Name = "Anna"}
            };

            var datasource = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Tom", Email = "Tom@gmail.com", Programming = new List<string> {"C#", "PHP", "JavaScript", "Java"}},
                new Employee { Id = 2, Name = "Kim", Email = "Kim@gmail.com", Programming = new List<string> {"C#", "SQL", "JavaScript", "Java"}},
                new Employee { Id = 3, Name = "Harry", Email = "Harry@gmail.com", Programming = new List<string> {"C#", "Pearl", "JavaScript", "Java"}},
                new Employee { Id = 4, Name = "Tom", Email = "Tom@gmail.com", Programming = new List<string> {"C#", "PHP", "Linq", "Java"}},
            };


            var basicQuery = (from emp in employees
                             select emp.Id).ToList();

            var basicMethod = employees.Select(emp => emp.Name).ToList();

            var selectQuery = (from emp in employees
                               select new Student
                               {
                                   Id = emp.Id,
                                   StudentEmail = emp.Email,
                                   FullName = emp.Name

                               }).ToList();

            var querySyntaxSelectMany = (from emp in datasource
                                        from skill in emp.Programming
                                        select skill).ToList();


            var selectMethod = employees.Select(emp => new Student { Id = emp.Id }).ToList();

            var anonymousMethod = employees.Select(e => new { CustomName = e.Name }).ToList();

            var selectIndexAnonymous = employees.Select((emp, index) => new { Index = index, Name = emp.Name }).ToList();

            var methodSyntax = datasource.SelectMany(emp => emp.Programming).ToList();

        }
    }
}
