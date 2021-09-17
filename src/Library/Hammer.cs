using System;

namespace Library
{
    /// <summary>
    /// This class represents a hammer.
    /// </summary>
    public class Hammer
    {
        private int _attack { get; }

        /// <summary>
        /// The attack value of the hammer.
        /// </summary>
        public int Attack { get => IsBroken ? 0 : _attack; }

        private int _defense { get; }

        /// <summary>
        /// The defense value of the hammer.
        /// </summary>
        public int Defense { get => IsBroken ? 0 : _defense; }

        /// <summary>
        /// The life of the hammer.
        /// </summary>
        public int HammerLife { get; private set; }

        /// <summary>
        /// Whether the hammer is broken or not.
        /// </summary>
        public bool IsBroken { get => HammerLife == 0; }

        public Hammer(int attack, int defense, int hammerLife)
        {
            Utils.CheckPositive(attack, "attack");
            Utils.CheckPositive(defense, "defense");
            Utils.CheckPositive(hammerLife, "hammerLife");
            this._attack = attack;
            this._defense = defense;
            this.HammerLife = hammerLife;
        }

        public void ReceiveAttack()
        {
            if (!IsBroken) HammerLife--;
        }
    }
}