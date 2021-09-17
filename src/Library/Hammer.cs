using System;

namespace Library
{
    /// <summary>
    /// This class represents a hammer.
    /// </summary>
    public class Hammer
    {
        /// <summary>
        /// The attack value of the hammer.
        /// </summary>
        public int Attack { get; }

        /// <summary>
        /// The defense value of the hammer.
        /// </summary>
        public int Defense { get; }

        /// <summary>
        /// The raw stat of the life of the hammer.
        /// </summary>
        private int hammerLife;

        /// <summary>
        /// The life of the hammer.
        /// </summary>
        public int HammerLife { get => IsBroken ? 0 : hammerLife; }

        /// <summary>
        /// Whether the hammer is broken or not.
        /// </summary>
        public bool IsBroken { get => HammerLife == 0; }

        public Hammer(int attack, int defense, int hammerLife)
        {
            Utils.CheckPositive(attack, "attack");
            Utils.CheckPositive(defense, "defense");
            Utils.CheckPositive(hammerLife, "hammerLife");
            this.Attack = attack;
            this.Defense = defense;
            this.hammerLife = hammerLife;
        }

        public void ReceiveAttack()
        {
            if (!IsBroken) hammerLife--;
        }
    }
}