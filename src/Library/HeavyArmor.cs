using System;

namespace Library
{
    /// <summary>
    /// This class represents a piece of armor
    /// </summary>
    public class HeavyArmor
    {
        /// <summary>
        /// The attack value of the armor
        /// </summary>
        public ushort Attack { get; }

        /// <summary>
        /// The defense value of the armor
        /// </summary>
        public ushort Defense { get; }

        /// <summary>
        /// The endurance of the armor
        /// </summary>
        public ushort ArmorLife { get; }

        /// <summary>
        /// Whether the armor is broken or not
        /// </summary>
        public bool IsBroken { get => ArmorLife == 0; }

        public HeavyArmor(ushort attack, ushort defense, ushort armorLife)
        {
            this.Attack = attack;
            this.Defense = defense;
            this.ArmorLife = armorLife;
        }
    }
}