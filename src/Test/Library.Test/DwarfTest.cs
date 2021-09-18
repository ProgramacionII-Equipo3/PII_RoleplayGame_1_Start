using NUnit.Framework;
using Library;

namespace Library.Test
{


    public class DwarfTest
    {

        [Test]
        public void TotalAttackTest()
        {
            Axe axe1 = new Axe (10,2);
            Shield shield1 = new Shield (2,10,40);
            Hammer hammer1 = new Hammer("Martillo", 20, 0);
            HeavyArmour armour1 = new HeavyArmour("Armadura", 0, 150);
            Dwarf dwarf1 = new Dwarf ("dwarf1", 20, axe1, shield1);
            Giant giant1 = new Giant("Giant1", hammer1, armour1);
            hammer1.UseHammer(giant1);
            Assert.AreEqual(32, dwarf1.TotalAttack());
            Assert.AreEqual(40, giant1.TotalAttack());
        }

        [Test]
        public void TotalDefenseTest()
        {
            Axe axe1 = new Axe (10,2);
            Hammer hammer1 = new Hammer("Martillo", 20, 0);
            HeavyArmour armour1 = new HeavyArmour("Armadura", 0, 150);
            Shield shield1 = new Shield (2,10,40);
            Dwarf dwarf1 = new Dwarf ("dwarf1", 20, axe1, shield1);
            Giant giant1 = new Giant("Gigante", hammer1, armour1);
            Assert.AreEqual(12, dwarf1.TotalDefense());
            Assert.AreEqual(150, giant1.TotalDefense());
        }

        [Test]
        public void AttackAnotherTest()
        {
            Axe axe1 = new Axe (10,2);
            Shield shield1 = new Shield (2,10,40);
            Hammer hammer1 = new Hammer("Martillo", 20, 0);
            HeavyArmour armour1 = new HeavyArmour("Armadura", 0, 150);
            Dwarf dwarf1 = new Dwarf ("dwarf1", 20, axe1, shield1);
            Dwarf dwarf2 = new Dwarf ("dwarf2", 30, axe1, shield1);
            Giant giant1 = new Giant("Gigante", hammer1, armour1);
            Giant giant2 = new Giant("Gigante2", hammer1, armour1);
            dwarf2.LoseVit(dwarf1.TotalAttack());
            Assert.AreEqual(80, dwarf2.CurrentVit);
            giant1.Attack(giant2);
            Assert.AreEqual(0, giant2.CurrentVit);
        }

        [Test]
        public void RestoreVitTest()
        {
            Axe axe1 = new Axe (10,2);
            Shield shield1 = new Shield (2,10,40);
            Dwarf dwarf1 = new Dwarf ("dwarf1", 20, axe1, shield1);
            Dwarf dwarf2 = new Dwarf ("dwarf2", 30, axe1, shield1);
            dwarf2.LoseVit(dwarf1.TotalAttack());
            dwarf2.RestoreVit(10);
            Assert.AreEqual(90,dwarf2.CurrentVit);
        }

    }


}