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
        public ushort Attack { get; }

        /// <summary>
        /// The defense value of the helmet
        /// </summary>
        public ushort Defense { get; }

        public Helmet(ushort attack, ushort defense)
        {
            this.Attack = attack;
            this.Defense = defense;
        }
    }
}