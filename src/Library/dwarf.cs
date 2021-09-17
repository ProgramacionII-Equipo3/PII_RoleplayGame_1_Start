using System;

namespace Library
{
    public class Dwarf
    {

        public Axe axe;
        public Shield shield;

        public string Name { get; private set; }
        public uint MaxVit { get; private set; }
        public uint CurrentVit { get; private set; }
        public ushort Strength { get; private set; }

        public Dwarf(string name, ushort strength, Axe axe, Shield shield)
        {
            this.Name = name;
            this.Strength = strength;
            this.Axe = axe;
            this.Shield = shield;
            this.MaxVit = 100;
            this.CurrentVit = 100;
        }

        public ushort TotalAttack()
        { 
            return this.Axe.Attack + this.Shield.Attack + this.Strength; 
        }

        public ushort TotalDefense()
        {
            return this.Shield.Defense + this.Axe.Defense; 
        }

        public void LoseVit(ushort damage)
        {
            damage = (ushort)(damage-(this.Axe.Defense+this.Shield.Defense));
            CurrentVit= (ushort)(CurrentVit - damage);
        }

        public void RestoreVit()
        {
            this.CurrentVit = this.MaxVit;
        }
    }
}