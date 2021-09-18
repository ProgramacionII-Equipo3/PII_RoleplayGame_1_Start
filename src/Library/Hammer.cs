using System;

namespace Library
{
    /// <summary>
    /// Clase para el elemento Hammer del gigante
    /// </summary>
    public class Hammer
    {
        /// <summary>
        /// Nombre del objeto Hammer
        /// </summary>
        private string Name { get; set; } 

        /// <summary>
        /// Valor de ataque de Hammer
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// Valor de defensa de Hammer
        /// </summary>
        private int Defense { get; set; }

        /// <summary>
        /// Vida útil de Hammer
        /// </summary>
        /// <value>100</value>//  
        public int HammerLife { get; set; }

        /// <summary>
        /// Representa si el objeto Hammer es usable
        /// </summary>
        public bool IsBroken { get; set; }

        /// <summary>
        /// Constructor del objeto Hammer
        /// </summary>
        /// <param nombre="name"></param>
        /// <param ValordelDaño="attack"></param>
        /// <param ValordelaDefensa="defense"></param>
        public Hammer(string name, int attack, int defense)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defense = defense;
            this.HammerLife = 100;
            this.IsBroken = false;
        }

        /// <summary>
        /// Método para comprobar si el objeto Hammer es usable
        /// </summary>
        /// <returns></returns>
        public bool IsHammerBroken()
        {
            if(this.HammerLife == 0)
            {
                this.IsBroken = true;
                
            }
            return this.IsBroken;

        }

        /// <summary>
        /// Método para equipar el objeto Hammer a un personaje
        /// </summary>
        /// <param name="giant"></param>
        public void UseHammer(Giant giant)
        {   
            if(this.IsBroken == false)
            {
                giant.Damage += this.Attack;
            }
            
        }
        /// <summary>
        /// Método para checkear si el objeto Hammer es usable, y en caso de que no lo desequipa
        /// </summary>
        /// <param name="giant"></param>
        public void CheckHammerLife(Giant giant)
        {
            if(this.IsHammerBroken() == true)
            {
                giant.Damage -= this.Attack;
                giant.CurrentVit -= this.Defense;
                giant.MaxVit -= this.Defense;
            }
        }         
    }
}