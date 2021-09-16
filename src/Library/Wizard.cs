using System;

namespace Library
{
    /// <summary>
    /// This class represents a wizard in the game.
    /// </summary>
    public class Wizard
    {
        /// <summary>
        /// The name of the wizard.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The maximum vitality of the wizard.
        /// </summary>
        public int MaxVit { get; }

        /// <summary>
        /// The raw stat of the current vitality.
        /// </summary>
        private int currentVit;

        /// <summary>
        /// The current vitality of the wizard.
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
        /// The magic orientation of the wizard.
        /// </summary>
        public string MagicOrientation { get; }

        /// <summary>
        /// The magic level of the wizard.
        /// </summary>
        public int MagicLevel { get; private set; }

        /// <summary>
        /// The strength of the wizard.
        /// </summary>
        public int NetStrength { get => (int)( (this.Wand.Attack + this.Book.Attack) * (1 + 0.2 * MagicLevel) ); }

        /// <summary>
        /// The defense of the wizard.
        /// </summary>
        public int NetDefense { get => this.Wand.Defense + this.Book.Defense; }

        /// <summary>
        /// The wizard's magic wand.
        /// </summary>
        public MagicWand Wand { get; set; } = null;

        /// <summary>
        /// The wizard's spell book.
        /// </summary>
        public SpellBook Book { get; set; } = null;

        public Wizard(string name, int maxVit, string magicOrientation, int magicLevel)
        {
            Utils.CheckString(name, "name");
            Utils.CheckPositive(maxVit, "maxVit");
            Utils.CheckString(magicOrientation, "magicOrientation");
            Utils.CheckPositive(magicLevel, "magicLevel");

            this.Name = name;
            this.MaxVit = this.currentVit = maxVit;
            this.MagicOrientation = magicOrientation;
            this.MagicLevel = magicLevel;
        }
        
        /// <summary>
        /// Modifies the wizard's vitality based on the received attack.
        /// </summary>
        /// <param name="netAttack">The net attack of the oponent.</param>
        public void ReceiveAttack(int netAttack)
        {
            CurrentVit -= netAttack;
        }

        /// <summary>
        /// Levels up the wizard.
        /// </summary>
        public void IncreaseMagicLevel()
        {
            MagicLevel++;
        }
    }
}