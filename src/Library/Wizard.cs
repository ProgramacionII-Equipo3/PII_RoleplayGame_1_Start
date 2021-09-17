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
        private int _currentVit;

        /// <summary>
        /// The current vitality of the wizard.
        /// </summary>
        public int CurrentVit {
            get => _currentVit;
            private set
            {
                if (value >= MaxVit) value = MaxVit;
                else if(value < 0) value = 0;
                _currentVit = value;
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
        /// The attack of the wizard.
        /// </summary>
        public int NetAttack { get => (int)( (this.Wand.Attack + this.Book.Attack) * (1 + 0.2 * MagicLevel) ); }

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
            this.MaxVit = this._currentVit = maxVit;
            this.MagicOrientation = magicOrientation;
            this.MagicLevel = magicLevel;
        }
        
        /// <summary>
        /// Reduces the wizard's vitality based on the received attack.
        /// </summary>
        /// <param name="netAttack">The net attack of the oponent.</param>
        public void ReceiveAttack(int netAttack)
        {
            CurrentVit -= Utils.CalcDamage(netAttack, NetDefense);
        }

        /// <summary>
        /// Levels up the wizard.
        /// </summary>
        public void IncreaseMagicLevel()
        {
            MagicLevel++;
        }

        /// <summary>
        /// Heals the wizard.
        /// </summary>
        /// <param name="healedVit">The amount of healing.</param>
        public void Heal(int healedVit)
        {
            if(healedVit <= 0) return;
            CurrentVit += healedVit;
        }
    }
}