using System;
using Character;

namespace HammerItem
{
    public class Hammer
    {
        private string Name;
        public uint HammerDamage;
        public uint HammerLife;
        private bool IsBroken;

    
        public Hammer()
        {
            this.Name = "Hammer";
            this.HammerDamage = 40;
            this.HammerLife = 100;
            this.IsBroken = false;
        }

        public void EquipHammer(Giant giant)
        {
            giant.Hammer = true;
        }
    }
}