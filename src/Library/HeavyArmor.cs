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
        public int Attack { get; }

        /// <summary>
        /// The defense value of the armor
        /// </summary>
        public int Defense { get; }

        /// <summary>
        /// The endurance of the armor
        /// </summary>
        public int ArmorLife { get; }

        /// <summary>
        /// Whether the armor is broken or not
        /// </summary>
        public bool IsBroken { get => ArmorLife == 0; }

        public HeavyArmor(int attack, int defense, int armorLife)
        {
            Utils.CheckNull(attack, "attack");
            Utils.CheckNull(defense, "defense");
            Utils.CheckNull(armorLife, "armorLife");
            this.Attack = attack;
            this.Defense = defense;
            this.ArmorLife = armorLife;
        }
    }
}