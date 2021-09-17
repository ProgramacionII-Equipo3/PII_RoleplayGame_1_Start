using System;

namespace Library
{
    public class Dwarf
    {

        public Axe Axe;
        public Shield Shield;

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
            return (ushort)(this.Axe.Attack + this.Shield.Attack + this.Strength); 
        }

        public ushort TotalDefense()
        {
            return (ushort)(this.Shield.Defense + this.Axe.Defense); 
        }

        public void LoseVit(ushort damage)
        {
            if (damage >= this.Shield.Endurance)
            {
                damage=(ushort)(damage-this.Axe.Defense);
            }
            else
            {
                damage = (ushort)(damage-(this.Axe.Defense + this.Shield.Defense));
            }
            
            if (damage >= 0)
            {
                CurrentVit = (ushort)(CurrentVit - damage);
            }
            else if (damage > CurrentVit)
            {
                CurrentVit = 0;
            }
        }

        public void RestoreVit(ushort restore)
        {
            if ((CurrentVit + restore) <= MaxVit)
            {
                CurrentVit = (ushort)(CurrentVit + restore);
            }
            else
            {
                CurrentVit = MaxVit;
            }
        }
    }
}