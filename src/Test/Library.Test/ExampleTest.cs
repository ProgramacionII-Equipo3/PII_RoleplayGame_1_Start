using NUnit.Framework;
using Library;

namespace Library.Test
{

    [TestFixture]
    public class ExampleTest
    {

        [Test]
        public void TestNetValues()
        {
            Dwarf dwarf = new Dwarf("Patricio", 500, 30, 20);
            dwarf.Weapon = new Axe(50, 0);
            dwarf.Shield = new Shield(0, 100, 50);

            Wizard wizard = new Wizard("Fernando", 300, "Fire", 40);
            wizard.Wand = new MagicWand(100, 20);
            wizard.Book = new SpellBook(500, 0);

            Assert.AreEqual(wizard.NetDefense, 20);
            Assert.AreEqual(dwarf.NetDefense, 120);
            Assert.AreEqual(wizard.NetAttack, 1800);
            Assert.AreEqual(dwarf.NetAttack, 80);
        }

        [Test]
        public void TestAttackCase()
        {
            Dwarf dwarf = new Dwarf("Patricio", 500, 30, 20);
            dwarf.Weapon = new Axe(50, 0);
            dwarf.Shield = new Shield(0, 100, 50);

            Wizard wizard = new Wizard("Fernando", 300, "Fire", 40);
            wizard.Wand = new MagicWand(100, 20);
            wizard.Book = new SpellBook(500, 0);

            wizard.ReceiveAttack(dwarf.NetAttack);
            dwarf.ReceiveAttack(wizard.NetAttack);

            Assert.AreEqual(wizard.CurrentVit, 240);
            Assert.AreEqual(dwarf.CurrentVit, 0);
        }

        [Test]
        public void TestArmorEndurance()
        {
            Dwarf dwarf = new Dwarf("Patricio", 500, 10, 20);
            dwarf.Weapon = new Axe(50, 0);
            dwarf.Shield = new Shield(0, 100, 50);

            Giant giant = new Giant("Roberto", 10000);
            giant.Vest = new HeavyArmor(0, 10, 20);

            for(int i = 1; i <= 20; i++)
            {
                Assert.False(giant.Vest.IsBroken);
                giant.ReceiveAttack(dwarf.NetAttack);
                Assert.AreEqual(10000 - 50 * i, giant.CurrentVit);
            }

            Assert.True(giant.Vest.IsBroken);
            giant.ReceiveAttack(dwarf.NetAttack);
            
            Assert.AreEqual(10000 - 50 * 20 - 60, giant.CurrentVit);
        }

        [Test]
        public void TestHealing()
        {
            Dwarf dwarf = new Dwarf("Patricio", 500, 10, 20);
            dwarf.Weapon = new Axe(50, 0);
            dwarf.Shield = new Shield(0, 100, 50);

            Giant giant = new Giant("Roberto", 10000);
            giant.Vest = new HeavyArmor(0, 10, 20);

            for(int i = 1; i <= 20; i++)
            {
                Assert.False(giant.Vest.IsBroken);
                giant.ReceiveAttack(dwarf.NetAttack);
            }
            Assert.AreEqual(9000, giant.CurrentVit);
            giant.Heal(50);
            Assert.AreEqual(9050, giant.CurrentVit);
            giant.Heal(150);
            Assert.AreEqual(9200, giant.CurrentVit);
            giant.Heal(900);
            Assert.AreEqual(10000, giant.CurrentVit);
        }

    }


}