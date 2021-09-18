namespace Library
{   
    //Seguimos el patrón expert para la creación de las clases,
    //de esta manera cada clase es encargada de conocer
    //la información relacionada a ella.
    public class Dwarf
    {
        public Axe Axe;
        public Shield Shield;

        public string Name { get; private set; }
        public uint MaxVit { get; private set; }
        public uint CurrentVit { get; private set; }
        public ushort Strength { get; private set; }

        public Dwarf(string name, ushort strength, Axe axe, Shield shield)
        {
            this.Name = name;
            this.Strength = strength;
            this.Axe = axe;
            this.Shield = shield;
            this.MaxVit = 100;
            this.CurrentVit = 100;
        }
        //Para obtener el valor total de ataque de un personaje.
        public ushort TotalAttack()
        { 
            return (ushort)(this.Axe.Attack + this.Shield.Attack + this.Strength); 
        }
        //Para obtener el valor total de defensa de un personaje.
        public ushort TotalDefense()
        {
            return (ushort)(this.Shield.Defense + this.Axe.Defense); 
        }
        //Para obtener el daño en caso de ser atacado.
        public void LoseVit(ushort damage)
        {
            if (damage >= this.Shield.Endurance)
            {
                damage = (ushort)(damage-this.Axe.Defense);
            }
            else
            {
                damage = (ushort)(damage-(this.Axe.Defense + this.Shield.Defense));
            }
            
            if (damage >= 0)
            {
                CurrentVit = (ushort)(CurrentVit - damage);
            }
            else if (damage > CurrentVit)
            {
                CurrentVit = 0;
            }
        }
        //Para curar a un personaje.
        public void RestoreVit(ushort restore)
        {
            if ((CurrentVit + restore) <= MaxVit)
            {
                CurrentVit = (ushort)(CurrentVit + restore);
            }
            else
            {
                CurrentVit = MaxVit;
            }
        }
    }
}