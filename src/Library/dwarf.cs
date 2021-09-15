using System;
using System.Collections;

namespace Library
{
    public class Dwarf
    {
        private string name;
        private uint maxVit;
        private uint currentVit;
        private ushort strength;
        public static Axe axe;
        public static Shield shield;

        public string Name { get; set; }
        public uint MaxVit { get; set; }
        public uint CurrentVit { get; set; }
        public ushort Strength { get; set; }

        public Dwarf(string name, ushort strength)
        {
            this.Name = name;
            this.Strength = strength;
            this.MaxVit = 100;
            this.CurrentVit = 100;
        }


    }
}