using System;
using HammerItem;

namespace Character
{
    // Clase para el personaje Giant
    public class Giant
    {
        private string Name;
        public uint Damage;
        private uint CurrentVit;
        public bool Hammer;
        public bool Armor;

        public Giant(string name)
        {
            this.Name = name;
            this.Damage = 40;
            this.CurrentVit = 150;
            this.Hammer = false;
            this.Armor = false;
        }

        // Método para atacar a otro personaje
        public void Attack(Giant character, Hammer hammer)
        {
            while (character.CurrentVit > 0)
            {
                if(this.Hammer == true)
                {
                    character.CurrentVit -= (this.Damage + hammer.HammerDamage);
                    hammer.HammerLife -= 1;
                    if(hammer.HammerLife == 0)
                    {
                        this.Hammer = false;
                    }
                }
                else
                {
                    character.CurrentVit -= this.Damage;
                }    
            }
            
        }
    }
}