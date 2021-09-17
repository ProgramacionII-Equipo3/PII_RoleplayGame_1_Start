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
        private int _currentVit;

        /// <summary>
        /// The current vitality of the dwarf.
        /// </summary>
        public int CurrentVit {
            get => _currentVit;
            private set
            {
                if (value >= MaxVit) value = MaxVit;
                else if(value < 0) value = 0;
                _currentVit = value;
            }
        }

        /// <summary>
        /// The innate attack of the dwarf.
        /// </summary>
        public int GrossAttack { get; private set; }

        /// <summary>
        /// The attack of the dwarf, counting innate attack and equipment.
        /// </summary>
        public int NetAttack { get => this.GrossAttack + (this.Shield?.Attack ?? 0) + (this.Weapon?.Attack ?? 0); }

        /// <summary>
        /// The innate defense of the dwarf.
        /// </summary>
        public int GrossDefense { get; private set; }

        /// <summary>
        /// The defense of the dwarf, counting innate defense and equipment.
        /// </summary>
        public int NetDefense { get => this.GrossDefense + (this.Shield?.Defense ?? 0) + (this.Weapon?.Defense ?? 0); }

        /// <summary>
        /// The dwarf's shield.
        /// </summary>
        public Shield Shield { get; set; } = null;

        /// <summary>
        /// The dwarf's weapon (an axe).
        /// </summary>
        public Axe Weapon { get; set; } = null;

        public Dwarf(string name, int maxVit, int attack, int defense)
        {
            Utils.CheckString(name, "name");
            Utils.CheckPositive(maxVit, "maxVit");
            Utils.CheckPositive(attack, "attack");
            Utils.CheckPositive(defense, "defense");

            this.Name = name;
            this.MaxVit = this._currentVit = maxVit;
            this.GrossAttack = attack;
            this.GrossDefense = defense;
        }

        /// <summary>
        /// Reduces the dwarf's vitality and equipment's durability based on the received attack.
        /// </summary>
        /// <param name="netAttack">The net attack of the oponent.</param>
        public void ReceiveAttack(int netAttack)
        {
            if(netAttack <= 0) return;
            CurrentVit -= Utils.CalcDamage(netAttack, NetDefense);
            if(Shield is Shield shield)
                shield.ReceiveAttack();
        }

        /// <summary>
        /// Heals the dwarf.
        /// </summary>
        /// <param name="healedVit">The amount of healing.</param>
        public void Heal(int healedVit)
        {
            if(healedVit <= 0) return;
            CurrentVit += healedVit;
        }
    }
}