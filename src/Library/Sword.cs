using System;

namespace Library
{
    /// <summary>
    /// This class represents a sword
    /// </summary>
    public class Sword
    {
        /// <summary>
        /// The attack value of the sword
        /// </summary>
        public int Attack { get; }

        /// <summary>
        /// The defense value of the sword
        /// </summary>
        public int Defense { get; }

        public Sword(int attack, int defense)
        {
            this.Attack = attack;
            this.Defense = defense;
        }
    }
}