using System;

namespace Library
{
    /// <summary>
    /// This class represents a shield.
    /// </summary>
    public class Shield
    {
        private int _attack { get; }

        /// <summary>
        /// The attack value of the shield.
        /// </summary>
        public int Attack { get => IsBroken ? 0 : _attack; }

        private int _defense { get; }

        /// <summary>
        /// The defense value of the shield.
        /// </summary>
        public int Defense { get => IsBroken ? 0 : _defense; }

        /// <summary>
        /// The endurance of the shield.
        /// </summary>
        public int Endurance { get; private set; }

        /// <summary>
        /// Whether the shield is broken or not.
        /// </summary>
        public bool IsBroken { get => Endurance == 0; }

        public Shield(int attack, int defense, int endurance)
        {
            Utils.CheckPositive(attack, "attack");
            Utils.CheckPositive(defense, "defense");
            Utils.CheckPositive(endurance, "endurance");
            this._attack = attack;
            this._defense = defense;
            this.Endurance = endurance;
        }

        public void ReceiveAttack()
        {
            if (!IsBroken) Endurance--;
        }
    }
}