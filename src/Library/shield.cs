namespace Library
{
    public class Shield
    {
        public ushort attack;
        public ushort defense;
        public ushort endurance;

        public Shield(ushort attack, ushort defense, ushort endurance) 
        {
            this.attack = attack;
            this.defense = defense;
            this.endurance = endurance;
        }
    }
}