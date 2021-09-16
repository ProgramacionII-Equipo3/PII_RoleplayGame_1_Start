using System;
using Character;

namespace ArmorVest
{
    public class HeavyArmor
    {
        private string Name;
        public uint ArmorDamage;
        public uint ArmorDefense;
        public uint ArmorLife;
        public bool IsArmorBroken;

        public HeavyArmor(string name)
        {
            this.Name = name;
            this.ArmorDamage = 0;
            this.ArmorDefense = 150;
            this.ArmorLife = 100;
            this.IsArmorBroken = false;
        }

        public void EquipArmor()
        {
            
        }

    }
}