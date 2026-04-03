using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__strart
{
    public class Human
    {
        public string? Name { get; set; } = string.Empty; // nullable type
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Info()
        {
            Console.WriteLine("Hello from Human");
        }
    }
}
