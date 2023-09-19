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
            var dataSource = new List<int>() { 100, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            var querySyntax = (from num in dataSource
                               select num).ToList();

            var methodSyntax = dataSource.OrderBy(num => num).ToList();

            foreach(var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Hello");

        }

    }
} 