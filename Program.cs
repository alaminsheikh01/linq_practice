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
            List<int> list = new List<int>() {1,2,3,4,5,6 };

            var querySyntax = from obj in list
                              where obj > 2
                              select obj;

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("...................");
            var methodSyntax = list.Where(obj => obj > 2);
            foreach(var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("..................");
            var maxedSyntax = (from obj in list select obj).Max();

            Console.WriteLine("Max Value: " + maxedSyntax);
            Console.ReadLine();
        }
    }
} 