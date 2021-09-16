using System;

namespace Library
{
    /// <summary>
    /// This class represents a shield.
    /// </summary>
    public class Shield
    {
        /// <summary>
        /// The attack value of the shield.
        /// </summary>
        public int Attack { get; }

        /// <summary>
        /// The defense value of the shield.
        /// </summary>
        public int Defense { get; private set; }

        /// <summary>
        /// The raw stat of endurance of the shield.
        /// </summary>
        private int endurance;

        /// <summary>
        /// The endurance of the shield.
        /// </summary>
        public int Endurance { get => IsBroken ? 0 : endurance; }

        /// <summary>
        /// Whether the shield is broken or not.
        /// </summary>
        public bool IsBroken { get => Endurance == 0; }

        public Shield(int attack, int defense, int endurance)
        {
            Utils.CheckPositive(attack, "attack");
            Utils.CheckPositive(defense, "defense");
            Utils.CheckPositive(endurance, "endurance");
            this.Attack = attack;
            this.Defense = defense;
            this.endurance = endurance;
        }

        public void ReceiveAttack()
        {
            if (!IsBroken) endurance--;
        }
    }
}