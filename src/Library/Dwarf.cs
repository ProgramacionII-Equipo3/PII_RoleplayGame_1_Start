using System;

namespace Library
{
    /// <summary>
    /// This class represents a dwarf in the game.
    /// </summary>
    public class Dwarf
    {
        /// <summary>
        /// The name of the dwarf.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The maximum vitality of the dwarf.
        /// </summary>
        public uint MaxVit { get; }

        /// <summary>
        /// The current vitality of the dwarf.
        /// </summary>
        public uint CurrentVit { get; private set; }

        /// <summary>
        /// The innate strength of the dwarf.
        /// </summary>
        private ushort strength;

        /// <summary>
        /// The strength of the dwarf, counting innate strength and equipment.
        /// </summary>
        public ushort Strength { get => this.strength; }

        /// <summary>
        /// The innate defense of the dwarf.
        /// </summary>
        private ushort defense;

        /// <summary>
        /// The defense of the dwarf, counting innate defense and equipment.
        /// </summary>
        public ushort Defense { get => this.defense; }

        /// <summary>
        /// The dwarf's shield
        /// </summary>
        public Shield Shield { get; set; } = null;

        /// <summary>
        /// The dwarf's weapon (an axe)
        /// </summary>
        /// <value></value>
        public Axe Weapon { get; set; } = null;

        public Dwarf(string name, uint maxVit, ushort strength, ushort defense)
        {
            this.Name = name;
            this.MaxVit = this.CurrentVit = maxVit;
            this.strength = strength;
            this.defense = defense;
        }
    }
}