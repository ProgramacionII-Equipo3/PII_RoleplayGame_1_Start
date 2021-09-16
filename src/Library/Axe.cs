using System;

namespace Library
{
    /// <summary>
    /// This class represents an axe
    /// </summary>
    public class Axe
    {
        /// <summary>
        /// The attack value of the axe
        /// </summary>
        public int Attack { get; }

        /// <summary>
        /// The defense value of the axe
        /// </summary>
        public int Defense { get; }

        public Axe(int attack, int defense)
        {
            Utils.CheckPositive(attack, "attack");
            Utils.CheckPositive(defense, "defense");
            this.Attack = attack;
            this.Defense = defense;
        }
    }
}