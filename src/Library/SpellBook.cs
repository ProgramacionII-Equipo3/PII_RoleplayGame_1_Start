using System;

namespace Library
{
    /// <summary>
    /// This class represents an spell book.
    /// </summary>
    public class SpellBook
    {
        /// <summary>
        /// The attack value of the spell book.
        /// </summary>
        public int Attack { get; }

        /// <summary>
        /// The defense value of the spell book.
        /// </summary>
        public int Defense { get; }

        public SpellBook(int attack, int defense)
        {
            Utils.CheckPositive(attack, "attack");
            Utils.CheckPositive(defense, "defense");
            this.Attack = attack;
            this.Defense = defense;
        }
    }
}