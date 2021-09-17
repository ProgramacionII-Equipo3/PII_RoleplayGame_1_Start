using System;

namespace Library
{
    /// <summary>
    /// This class represents a piece of armor.
    /// </summary>
    public class HeavyArmor
    {
        private int _attack { get; }

        /// <summary>
        /// The attack value of the armor.
        /// </summary>
        public int Attack { get => IsBroken ? 0 : _attack; }

        private int _defense { get; }

        /// <summary>
        /// The defense value of the armor.
        /// </summary>
        public int Defense { get => IsBroken ? 0 : _defense; }

        /// <summary>
        /// The endurance of the armor.
        /// </summary>
        public int ArmorLife { get; private set; }

        /// <summary>
        /// Whether the armor is broken or not.
        /// </summary>
        public bool IsBroken { get => ArmorLife == 0; }

        public HeavyArmor(int attack, int defense, int armorLife)
        {
            Utils.CheckPositive(attack, "attack");
            Utils.CheckPositive(defense, "defense");
            Utils.CheckPositive(armorLife, "armorLife");
            this._attack = attack;
            this._defense = defense;
            this.ArmorLife = armorLife;
        }

        public void ReceiveAttack()
        {
            if (!IsBroken) ArmorLife--;
        }
    }
}