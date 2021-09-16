using System;

namespace Library
{
    /// <summary>
    /// This class represents a helmet
    /// </summary>
    public class Helmet
    {
        /// <summary>
        /// The attack value of the helmet
        /// </summary>
        public int Attack { get; }

        /// <summary>
        /// The defense value of the helmet
        /// </summary>
        public int Defense { get; }

        public Helmet(int attack, int defense)
        {
            this.Attack = attack;
            this.Defense = defense;
        }
    }
}