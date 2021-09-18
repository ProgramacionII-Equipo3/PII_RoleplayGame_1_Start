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
            Dwarf dwarf1 = new Dwarf ("dwarf1", 20, axe1, shield1);
            Assert.AreEqual(32, dwarf1.TotalAttack());
        }

        [Test]
        public void TotalDefenseTest()
        {
            Axe axe1 = new Axe (10,2);
            Shield shield1 = new Shield (2,10,40);
            Dwarf dwarf1 = new Dwarf ("dwarf1", 20, axe1, shield1);
            Assert.AreEqual(12, dwarf1.TotalDefense());
        }

        [Test]
        public void AttackAnotherTest()
        {
            Axe axe1 = new Axe (10,2);
            Shield shield1 = new Shield (2,10,40);
            Dwarf dwarf1 = new Dwarf ("dwarf1", 20, axe1, shield1);
            Dwarf dwarf2 = new Dwarf ("dwarf2", 30, axe1, shield1);
            dwarf2.LoseVit(dwarf1.TotalAttack());
            Assert.AreEqual(80, dwarf2.CurrentVit);
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