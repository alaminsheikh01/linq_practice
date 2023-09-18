using linq_practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
              new Employee() { Id = 1, Name = "Tom", Email = "tom@gmail.com" },
              new Employee() { Id = 2, Name = "Tom1", Email = "tom1@gmail.com" },
              new Employee() { Id = 3, Name = "Tom2", Email = "tom2@gmail.com" },
              new Employee() { Id = 4, Name = "Tom3", Email = "tom3@gmail.com" }

            };

            var selectQuery = (from emp in employees
                               select new Employee()
                               {
                                   Id = emp.Id,
                                   Name = emp.Name,
                                   Email = emp.Email,
                               }).ToList();

            var selectMethod = employees.Select(emp => new Employee()
            {
                Id = emp.Id,
                Name = emp.Name,
                Email = emp.Email
            }).ToList();

            var query = employees.Select((emp, index) => new { index = index, Name = emp.Name }).ToList();

            foreach(var item in query)
            {
                Console.WriteLine("Name " + item.Name);
            }

        }

    }
} 