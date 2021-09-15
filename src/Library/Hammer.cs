using System;

namespace Library
{
    /// <summary>
    /// This class represents a hammer
    /// </summary>
    public class Hammer
    {
        /// <summary>
        /// The attack value of the hammer
        /// </summary>
        public ushort Attack { get; }

        /// <summary>
        /// The defense value of the hammer
        /// </summary>
        public ushort Defense { get; }

        /// <summary>
        /// The life of the hammer
        /// </summary>
        public ushort HammerLife { get; }

        /// <summary>
        /// Whether the hammer is broken or not
        /// </summary>
        public bool IsBroken { get => HammerLife == 0; }

        public Hammer(ushort attack, ushort defense, ushort hammerLife)
        {
            this.Attack = attack;
            this.Defense = defense;
            this.HammerLife = hammerLife;
        }
    }
}