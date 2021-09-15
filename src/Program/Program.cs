using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dwarf Goliat = new Dwarf("Goliat",20);
            Console.WriteLine(Goliat.Name);
            Console.WriteLine(Axe.attack);
            Console.WriteLine(Dwarf.shield.endurance);
        }
    }
}
