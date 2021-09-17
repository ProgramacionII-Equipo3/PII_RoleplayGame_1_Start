using System;
using Library;
namespace Library
{
    public class Elf
    {
        public string Name{get; set;}
        public ushort MagicLevel {get; private set;}
        public uint MaxVit {get; private set;}
        public uint CurrentVit 
        {
            get
            {
                return CurrentVit;
            }
            private set
            {
                if (value<=0)
                {
                    CurrentVit=value;
                }
                else if (value>=MaxVit)
                {
                    CurrentVit=MaxVit;
                }
            }
        }

        public Helmet Helmet{get; set ;}
        public Sword Sword {get; set ;}


        public Elf (string name, byte magicLevel)
        {
            this.Name=name;
            this.MagicLevel=magicLevel;
            this.CurrentVit=100;
            this.MaxVit=100;
        }
        
        public ushort FullAttack()
        {
            return (ushort)((this.Sword.Attack+this.Helmet.Attack)*(1+this.MagicLevel*0.05));   
        }
        public void LoseVit(ushort damage)
        {
            damage = (ushort)(damage-(this.Helmet.Defense+this.Sword.Defense));
            CurrentVit= (ushort)(CurrentVit - damage);
        }
    }
}