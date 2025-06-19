using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1_19._06._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> lettersCounts = new Dictionary<string, int>();
            string name;
            while ((name = Console.ReadLine()) != "stop")
            {
                if (lettersCounts.ContainsKey(name))
                {
                    lettersCounts[name]++;
                }
                else 
                {
                    lettersCounts.Add(name, 1);
                }
            }
            foreach (var entry in lettersCounts) 
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value} ");
            }
        }
    }
}
