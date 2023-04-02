using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "Анжелика", "Виктория", "Гагарин",
                "Ave Maria", "Катарина" , "Юбилейная"};

            string[] flowers1 = { "Анжелика", "Виктория", "Гагарин", "Катарина" };
            string[] flowers2 = { "Виктория", "Ave Maria", "Гагарин", "Катарина" };
            string[] flowers3 = { "Анжелика", "Виктория", "Катарина" };
            Console.WriteLine("Есть у всех цветоводов");
            Print_mnozh(flowers1.Intersect(flowers2).Intersect(flowers3));
            Console.WriteLine("Нет ни у одного цветовода");
            Print_mnozh(flowers.Except(flowers1).Except(flowers2).Except(flowers3));
            Console.WriteLine("Есть у нескольких цветоводов");
            Print_mnozh(flowers1.Union(flowers2).Union(flowers3).
                Except(flowers1.Intersect(flowers2).Intersect(flowers3)));
            Console.ReadKey();

        }
        private static void Print_mnozh(IEnumerable<string> res)
        {
            foreach (string s in res)
                Console.WriteLine(s);
        }
    }
}
