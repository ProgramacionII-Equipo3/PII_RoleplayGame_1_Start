using System;
using Library;

namespace Library
{
    // Clase para el personaje Giant
    public class Giant
    {
        /// <summary>
        /// Nombre del gigante
        /// </summary>
        private string Name { get; }

        /// <summary>
        /// Daño del Gigante
        /// </summary>
        /// <value>40</value>
        public int Damage { get; set; }

        /// <summary>
        /// Vida actual del gigante
        /// </summary> 
        public int CurrentVit { get; set; }

        /// <summary>
        /// Vida máxima del gigante
        /// </summary>
        /// <value>100</value>
        public int MaxVit { get; set; }

        /// <summary>
        /// Objeto de la clase Hammer
        /// </summary>
       public Hammer Weapon;

       /// <summary>
       /// Objeto de la clase HeavyArmour
       /// </summary>
       public HeavyArmour Armour;

        public Giant(string name, Hammer weapon, HeavyArmour armour)
        {
            this.Name = name;
            this.MaxVit = 100;
            this.Damage = 20;
            this.CurrentVit = 150;
            this.Weapon = weapon;
            this.Armour = armour;
        }

        public void Attack(Giant enemy)
        {
            while(enemy.CurrentVit > 0)
            {
                this.Weapon.CheckHammerLife(this);
                enemy.CurrentVit -= this.Damage;
                if(enemy.CurrentVit < 0)
                {
                    enemy.CurrentVit = 0;
                }
                this.Weapon.HammerLife -= 10;
            }           
        }

        /*
        /// <summary>
        /// Método para que otro personaje ataque al gigante
        /// </summary>
        /// <param name="foe"></param>
        public void ReceiveAttack(Giant foe)
        {
            this.CurrentVit -= foe.Damage;
            if(this.CurrentVit < 0)
            {
                this.CurrentVit = 0;
            }
            this.Armour.ArmourLife -= 10;
        }
        */
    }
}