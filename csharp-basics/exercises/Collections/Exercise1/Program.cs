using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            string[] origin = {"Germany", "Germany", "Japan", "Germany", "Germany", "Germany", "USA"};
            
            var list = array.ToList();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine();

            var hashSet = array.ToHashSet();

            foreach (var i in hashSet)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            var dictionary = new Dictionary<string, string>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!dictionary.ContainsKey(array[i]))
                {
                    dictionary.Add(array[i], origin[i]);
                }
            }

            foreach (var i in dictionary)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
