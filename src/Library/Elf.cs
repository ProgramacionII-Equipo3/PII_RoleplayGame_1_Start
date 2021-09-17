using System;

namespace Library
{
    /// <summary>
    /// This class represents a elf in the game.
    /// </summary>
    public class Elf
    {
        /// <summary>
        /// The name of the elf.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The maximum vitality of the elf.
        /// </summary>
        public int MaxVit { get; }

        /// <summary>
        /// The magic level of the wizard.
        /// </summary>
        public int MagicLevel { get; private set; }

        /// <summary>
        /// The raw stat of the current vitality.
        /// </summary>
        private int _currentVit;

        /// <summary>
        /// The current vitality of the elf.
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
        /// The attack of the elf.
        /// </summary>
        public int NetAttack { get => (int)( ((this.Weapon?.Attack ?? 0) + (this.Helmet?.Attack ?? 0)) * (1 + 0.05 * MagicLevel) ); }

        /// <summary>
        /// The defense of the elf.
        /// </summary>
        public int NetDefense { get => (this.Weapon?.Defense ?? 0) + (this.Helmet?.Defense ?? 0); }

        /// <summary>
        /// The elf's sword.
        /// </summary>
        public Sword Weapon { get; set; } = null;

        /// <summary>
        /// The elf's helmet.
        /// </summary>
        public Helmet Helmet { get; set; } = null;

        public Elf(string name, int maxVit, int magicLevel)
        {
            Utils.CheckString(name, "name");
            Utils.CheckPositive(maxVit, "maxVit");

            this.Name = name;
            this.MaxVit = this._currentVit = maxVit;
            this.MagicLevel = magicLevel;
        }
        
        /// <summary>
        /// Reduces the elf's vitality based on the received attack.
        /// </summary>
        /// <param name="netAttack">The net attack of the oponent.</param>
        public void ReceiveAttack(int netAttack)
        {
            CurrentVit -= Utils.CalcDamage(netAttack, NetDefense);
        }

        /// <summary>
        /// Heals the elf.
        /// </summary>
        /// <param name="healedVit">The amount of healing.</param>
        public void Heal(int healedVit)
        {
            if(healedVit <= 0) return;
            CurrentVit += healedVit;
        }
    }
}