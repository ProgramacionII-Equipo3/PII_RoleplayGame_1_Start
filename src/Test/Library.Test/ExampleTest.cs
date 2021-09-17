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
        public void Test()
        {
            Elf elf1= new Elf("Elfo 1",10);
            elf1.Sword = new Sword(20,10);
            elf1.Helmet= new Helmet (5, 20);
            Assert.AreEqual(elf1.FullAttack(), 37);
            Assert.AreEqual(elf1.Name, "Elfo 1");
        }

        [Test]

        public void DwarfandElf()
        {
            Elf elf1= new Elf("Elfo 1",10);
            elf1.Sword = new Sword(20,10);
            elf1.Helmet= new Helmet (5, 20);
            Axe axe1= new Axe(10,2);
            Shield shield1= new Shield(2,10,40);
            Dwarf dwarf1= new Dwarf("Enano 1",5, axe1 , shield1);
            Assert.AreEqual(dwarf1.TotalAttack(),17);
            elf1.LoseVit(dwarf1.TotalAttack());
            Assert.AreEqual(13,elf1.CurrentVit);
            elf1.LoseVit(dwarf1.TotalAttack());
            Assert.AreEqual(elf1.CurrentVit,83);
        } 
        
    }

}