using System;

namespace Library
{
    /// <summary>
    /// This class represents a shield
    /// </summary>
    public class Shield
    {
        /// <summary>
        /// The attack value of the shield
        /// </summary>
        public ushort Attack { get; }

        /// <summary>
        /// The defense value of the shield
        /// </summary>
        public ushort Defense { get; }

        /// <summary>
        /// The endurance of the shield
        /// </summary>
        public ushort Endurance { get; }

        /// <summary>
        /// Whether the shield is broken or not
        /// </summary>
        public bool IsBroken { get => Endurance == 0; }

        public Shield(ushort attack, ushort defense, ushort endurance)
        {
            this.Attack = attack;
            this.Defense = defense;
            this.Endurance = endurance;
        }
    }
}