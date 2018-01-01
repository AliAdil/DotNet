using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    class List
    {
        static void Main(string[] args)
        {
          var names = new List<string>{"<name>","Ali","Adil"};

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ali");
            names.Sort();
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[1]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to my list.");
            Console.WriteLine($"The list has {names.Count()} people in it ");

            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");
            var notFound = names.IndexOf("Not Found");
                Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
    }
}
