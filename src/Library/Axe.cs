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
        public ushort Attack { get; }

        /// <summary>
        /// The defense value of the axe
        /// </summary>
        public ushort Defense { get; }

        public Axe(ushort attack, ushort defense)
        {
            this.Attack = attack;
            this.Defense = defense;
        }
    }
}