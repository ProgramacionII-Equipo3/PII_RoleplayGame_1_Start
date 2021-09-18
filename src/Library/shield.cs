namespace Library
{
    public class Shield
    {
        public ushort Attack;
        public ushort Defense;
        public ushort Endurance;

        public Shield(ushort attack, ushort defense, ushort endurance) 
        {
            this.Attack = attack;
            this.Defense = defense;
            this.Endurance = endurance;
        }
    }
}