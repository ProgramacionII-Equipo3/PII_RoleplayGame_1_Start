using NUnit.Framework;
using Library;

namespace Library.Test
{

    [TestFixture]
    public class ExampleTest
    {

        [Test]
        public void Test1()
        {
            Dwarf dwarf = new Dwarf("Patricio", 500, 30, 20);
            dwarf.Weapon = new Axe(50, 0);
            dwarf.Shield = new Shield(0, 100, 50);

            Wizard wizard = new Wizard("Fernando", 300, "Fire", 40);
            wizard.Wand = new MagicWand(100, 20);
            wizard.Book = new SpellBook(500, 0);

            Assert.AreEqual(wizard.NetDefense, 20);
            Assert.AreEqual(dwarf.NetDefense, 120);
            Assert.AreEqual(wizard.NetAttack, 5400);
            Assert.AreEqual(dwarf.NetAttack, 80);

            wizard.ReceiveAttack(dwarf.NetAttack);
            Assert.AreEqual(wizard.CurrentVit, 240);

            dwarf.ReceiveAttack(wizard.NetAttack);
            Assert.AreEqual(dwarf.CurrentVit, 0);
        }

    }


}