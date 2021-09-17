using NUnit.Framework;
using Library;

namespace Test.Library
{


    public class ExampleTest
    {

        [Test]
        public void dummyTest()
        {
            Assert.True(true);
        }
        [Test]
        public void IsHammerandArmourEquipped() // Caso en el que asigna un martillo y una armadura a un gigante
        {
            Hammer hammer = new Hammer("Martillo", 20, 0);
            HeavyArmour armour = new HeavyArmour("Armadura", 0, 150);
            Giant giant = new Giant("Gigante", hammer, armour);
            hammer.UseHammer(giant);
            armour.UseArmour(giant);
            Assert.AreEqual(40, giant.Damage);
            
        } 

    }


}