using System;

namespace Library
{
    /// <summary>
    /// This class represents a giant in the game.
    /// </summary>
    public class Elf
    {
        /// <summary>
        /// The name of the giant.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The maximum vitality of the giant.
        /// </summary>
        public int MaxVit { get; }

        /// <summary>
        /// The magic level of the wizard.
        /// </summary>
        public int MagicLevel { get; private set; }

        /// <summary>
        /// The raw stat of the current vitality.
        /// </summary>
        private int currentVit;

        /// <summary>
        /// The current vitality of the giant.
        /// </summary>
        public int CurrentVit {
            get => currentVit;
            private set
            {
                if (value >= MaxVit) value = MaxVit;
                else if(value < 0) value = 0;
                currentVit = value;
            }
        }

        /// <summary>
        /// The strength of the giant.
        /// </summary>
        public int NetStrength { get => (int)( (this.Sword.Attack + this.Helmet.Attack) * (1 + 0.2 * MagicLevel) ); }

        /// <summary>
        /// The defense of the giant.
        /// </summary>
        public int NetDefense { get => this.Sword.Defense + this.Helmet.Defense; }

        /// <summary>
        /// The giant's magic wand.
        /// </summary>
        public Sword Sword { get; set; } = null;

        /// <summary>
        /// The giant's spell book.
        /// </summary>
        public Helmet Helmet { get; set; } = null;

        public Elf(string name, int maxVit)
        {
            Utils.CheckString(name, "name");
            Utils.CheckPositive(maxVit, "maxVit");

            this.Name = name;
            this.MaxVit = this.currentVit = maxVit;
        }
        
        /// <summary>
        /// Modifies the giant's vitality based on the received attack.
        /// </summary>
        /// <param name="netAttack">The net attack of the oponent.</param>
        public void ReceiveAttack(int netAttack)
        {
            CurrentVit -= netAttack;
        }
    }
}