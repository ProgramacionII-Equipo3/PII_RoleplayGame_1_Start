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
        public ushort Attack { get; }

        /// <summary>
        /// The defense value of the sword
        /// </summary>
        public ushort Defense { get; }

        public Sword(ushort attack, ushort defense)
        {
            this.Attack = attack;
            this.Defense = defense;
        }
    }
}