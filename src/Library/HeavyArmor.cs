using System;

namespace Library
{
    /// <summary>
    /// This class represents a piece of armor.
    /// </summary>
    public class HeavyArmor
    {
        /// <summary>
        /// The attack value of the armor.
        /// </summary>
        public int Attack { get; }

        /// <summary>
        /// The defense value of the armor.
        /// </summary>
        public int Defense { get; }

        /// <summary>
        /// The raw stat of the endurance of the armor.
        /// </summary>
        private int armorLife;

        /// <summary>
        /// The endurance of the armor.
        /// </summary>
        public int ArmorLife { get => IsBroken ? 0 : armorLife; }

        /// <summary>
        /// Whether the armor is broken or not.
        /// </summary>
        public bool IsBroken { get => ArmorLife == 0; }

        public HeavyArmor(int attack, int defense, int armorLife)
        {
            Utils.CheckPositive(attack, "attack");
            Utils.CheckPositive(defense, "defense");
            Utils.CheckPositive(armorLife, "armorLife");
            this.Attack = attack;
            this.Defense = defense;
            this.armorLife = armorLife;
        }

        public void ReceiveAttack()
        {
            if (!IsBroken) armorLife--;
        }
    }
}