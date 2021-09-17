using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Hammer Martillo = new Hammer("Martillo de thor", 20, 0);
            HeavyArmour Armadura = new HeavyArmour("Armadura Pesada", 0, 150);
            Giant Gigante = new Giant("Gigante", Martillo, Armadura);
            Giant GiganteEnemigo = new Giant("GiganteEnemigo", Martillo, Armadura);
            //Martillo.UseHammer(Gigante);
            //Armadura.UseArmour(GiganteEnemigo);
            //Gigante.Attack(GiganteEnemigo);
            
        }
    }
}
