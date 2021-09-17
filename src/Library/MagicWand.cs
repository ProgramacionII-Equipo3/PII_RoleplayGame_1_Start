using System;

namespace Library
{
    /// <summary>
    /// This class represents a magic wand.
    /// </summary>
    public class MagicWand
    {
        /// <summary>
        /// The attack value of the magic wand.
        /// </summary>
        public int Attack { get; }

        /// <summary>
        /// The defense value of the magic wand.
        /// </summary>
        public int Defense { get; }

        public MagicWand(int attack, int defense)
        {
            Utils.CheckPositive(attack, "attack");
            Utils.CheckPositive(defense, "defense");
            this.Attack = attack;
            this.Defense = defense;
        }
    }
}