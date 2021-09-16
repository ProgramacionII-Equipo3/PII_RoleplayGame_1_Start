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
        public int Attack { get; }

        /// <summary>
        /// The defense value of the shield
        /// </summary>
        public int Defense { get; }

        /// <summary>
        /// The endurance of the shield
        /// </summary>
        public int Endurance { get; }

        /// <summary>
        /// Whether the shield is broken or not
        /// </summary>
        public bool IsBroken { get => Endurance == 0; }

        public Shield(int attack, int defense, int endurance)
        {
            Utils.CheckPositive(attack, "attack");
            Utils.CheckPositive(defense, "defense");
            Utils.CheckPositive(endurance, "endurance");
            this.Attack = attack;
            this.Defense = defense;
            this.Endurance = endurance;
        }
    }
}