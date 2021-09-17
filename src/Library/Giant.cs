using System;

namespace Library
{
    /// <summary>
    /// This class represents a giant in the game.
    /// </summary>
    public class Giant
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
        /// The raw stat of the current vitality.
        /// </summary>
        private int _currentVit;

        /// <summary>
        /// The current vitality of the giant.
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
        /// The attack of the giant.
        /// </summary>
        public int NetAttack { get => (this.Weapon?.Attack ?? 0) + (this.Vest?.Attack ?? 0); }

        /// <summary>
        /// The defense of the giant.
        /// </summary>
        public int NetDefense { get => (this.Weapon?.Defense ?? 0) + (this.Vest?.Defense ?? 0); }

        /// <summary>
        /// The giant's hammer.
        /// </summary>
        public Hammer Weapon { get; set; } = null;

        /// <summary>
        /// The giant's vest.
        /// </summary>
        public HeavyArmor Vest { get; set; } = null;

        public Giant(string name, int maxVit)
        {
            Utils.CheckString(name, "name");
            Utils.CheckPositive(maxVit, "maxVit");

            this.Name = name;
            this.MaxVit = this._currentVit = maxVit;
        }
        
        /// <summary>
        /// Reduces the giant's vitality based on the received attack.
        /// </summary>
        /// <param name="netAttack">The net attack of the oponent.</param>
        public void ReceiveAttack(int netAttack)
        {
            CurrentVit -= Utils.CalcDamage(netAttack, NetDefense);
            if(Weapon is Hammer hammer) hammer.ReceiveAttack();
            if(Vest is HeavyArmor armor) armor.ReceiveAttack();
        }

        /// <summary>
        /// Heals the giant.
        /// </summary>
        /// <param name="healedVit">The amount of healing.</param>
        public void Heal(int healedVit)
        {
            if(healedVit <= 0) return;
            CurrentVit += healedVit;
        }
    }
}