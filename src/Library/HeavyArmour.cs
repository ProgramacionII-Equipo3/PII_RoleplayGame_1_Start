using System;

namespace Library
{
    /// <summary>
    /// Clase para el objeto armadura del gigante
    /// </summary>
    public class HeavyArmour
    {
        /// <summary>
        /// Nombre del objeto HeavyArmour
        /// </summary>
        private string Name { get; set; } 

        /// <summary>
        /// Valor de ataque de HeavyArmour
        /// </summary>
        private int Attack { get; set; }

        /// <summary>
        /// Valor de defensa HeavyArmour
        /// </summary>
        private int Defense { get; set; }

        /// <summary>
        /// Vida útil del objeto HeavyArmour
        /// </summary>
        /// <value>100</value>//  
        public int ArmourLife { get; set; }

        /// <summary>
        /// Representa si el objeto HeavyArmour es usable
        /// </summary>
        public bool IsBroken { get; set; }

        /// <summary>
        /// Constructor de la clase HeavyArmour
        /// </summary>
        /// <param name="name"></param>
        /// <param ValordeAtaque="attack"></param>
        /// <param ValordeDefensa="defense"></param>
        public HeavyArmour(string name, int attack, int defense)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defense = defense;
            this.ArmourLife = 100;
            this.IsBroken = false;
        }

        /// <summary>
        /// Método para comprobar si la armadura es usable
        /// </summary>
        /// <returns>this.IsBroken</returns>
        public bool IsArmourBroken()
        {
            if(this.ArmourLife == 0)
            {
                this.IsBroken = true;
                
            }
            return this.IsBroken;

        }

        /// <summary>
        /// Método para equipar la armadura en el personaje
        /// </summary>
        /// <param name="giant"></param>
        public void UseArmour(Giant giant)
        {   
            if(this.IsBroken == false)
            {
                giant.Damage += this.Attack;
                giant.CurrentVit += this.Defense;
                giant.MaxVit += this.Defense;
            }
            
        }
        
        /// <summary>
        /// Método para checkear si el objeto HeavyArmour es usable, y en caso de que no lo desequipa
        /// </summary>
        /// <param name="giant"></param>
        public void CheckArmourLife(Giant giant)
        {
            if(this.IsArmourBroken() == true)
            {
                giant.Damage -= this.Attack;
                giant.CurrentVit -= this.Defense;
                giant.MaxVit -= this.Defense;
            }
        }         
    }
}