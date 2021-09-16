using System;

namespace Library
{
    /// <summary>
    /// This class represents a dwarf in the game.
    /// </summary>
    public class Dwarf
    {
        /// <summary>
        /// The name of the dwarf.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The maximum vitality of the dwarf.
        /// </summary>
        public int MaxVit { get; }

        /// <summary>
        /// The raw stat of the current vitality.
        /// </summary>
        private int currentVit;

        /// <summary>
        /// The current vitality of the dwarf.
        /// </summary>
        public int CurrentVit {
            get => currentVit;
            private set
            {
                if (value >= MaxVit) value = MaxVit;
                else if(value < 0) value = 0;
                currentVit = value;
            }
        }

        /// <summary>
        /// The innate strength of the dwarf.
        /// </summary>
        public int GrossStrength { get; private set; }

        /// <summary>
        /// The strength of the dwarf, counting innate strength and equipment.
        /// </summary>
        public int NetStrength { get => this.GrossStrength + this.Shield.Attack + this.Weapon.Attack; }

        /// <summary>
        /// The innate defense of the dwarf.
        /// </summary>
        public int GrossDefense { get; private set; }

        /// <summary>
        /// The defense of the dwarf, counting innate defense and equipment.
        /// </summary>
        public int NetDefense { get => this.GrossDefense + this.Shield.Defense + this.Weapon.Defense; }

        /// <summary>
        /// The dwarf's shield.
        /// </summary>
        public Shield Shield { get; set; } = null;

        /// <summary>
        /// The dwarf's weapon (an axe).
        /// </summary>
        public Axe Weapon { get; set; } = null;

        public Dwarf(string name, int maxVit, int strength, int defense)
        {
            Utils.CheckString(name, "name");
            Utils.CheckPositive(maxVit, "maxVit");
            Utils.CheckPositive(strength, "strength");
            Utils.CheckPositive(defense, "defense");

            this.Name = name;
            this.MaxVit = this.currentVit = maxVit;
            this.GrossStrength = strength;
            this.GrossDefense = defense;
        }

        /// <summary>
        /// Modifies the dwarf's vitality and equipment's durability based on the received attack.
        /// </summary>
        /// <param name="netAttack">The net attack of the oponent.</param>
        public void ReceiveAttack(int netAttack)
        {
            CurrentVit -= Utils.CalcDamage(netAttack, NetDefense);
            if(Shield is Shield shield)
                shield.ReceiveAttack();
        }
    }
}