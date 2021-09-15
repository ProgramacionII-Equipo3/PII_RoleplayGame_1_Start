using System;

namespace Library
{
    public class Elf
    {
        public string Name;
        private byte MagicLevel;
        public uint CurrentVit {get; private set;}
        public uint MaxVit {get; private set;}

        public Elf (string name, byte magicLevel)
        {
            this.Name=name;
            this.MagicLevel=magicLevel;
            this.CurrentVit=100;
            this.MaxVit=100;
        }

    }

  




















}