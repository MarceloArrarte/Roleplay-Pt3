using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class CharacterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestKnightBaseStats() {
            string nombre = "Caballero genérico";
            Knight caballero = new Knight(nombre);
            Assert.IsTrue(caballero.Name == nombre &&
                caballero.AttackValue == new Sword().AttackValue &&
                caballero.DefenseValue == new Shield().DefenseValue + new Armor().DefenseValue);
        }

        [Test]
        public void TestArcherBaseStats() {
            string nombre = "Legolas";
            Archer legolas = new Archer(nombre);
            Assert.IsTrue(legolas.Name == nombre &&
                legolas.AttackValue == new Bow().AttackValue &&
                legolas.DefenseValue == new Helmet().DefenseValue);
        }
        
        [Test]
        public void TestDwarfBaseStats() {
            string nombre = "Gimli";
            Dwarf gimli = new Dwarf(nombre);
            Assert.IsTrue(gimli.Name == nombre &&
                gimli.AttackValue == new Axe().AttackValue &&
                gimli.DefenseValue == new Helmet().DefenseValue);
        }

        [Test]
        public void TestHarmlessAttack() {
            Knight caballero = new Knight("Caballero genérico");
            Wizard gandalf = new Wizard("Gandalf");
            int expectedLifeLeft = gandalf.Health;

            gandalf.ReceiveAttack(caballero.AttackValue);
            Assert.AreEqual(expectedLifeLeft, gandalf.Health);
        }

        [Test]
        public void TestNonLethalAttack() {
            Knight caballero = new Knight("Caballero genérico");
            Archer arquero = new Archer("Legolas");
            int expectedLifeLeft = arquero.Health - (caballero.AttackValue - arquero.DefenseValue);

            arquero.ReceiveAttack(caballero.AttackValue);
            Assert.AreEqual(expectedLifeLeft, arquero.Health);
        }
        
        [Test]
        public void TestOverkillAttack() {
            Knight caballero = new Knight("Caballero genérico");
            Wizard gandalf = new Wizard("Gandalf");
            int expectedLifeLeft = 0;

            caballero.ReceiveAttack(gandalf.AttackValue);
            caballero.ReceiveAttack(gandalf.AttackValue);
            Assert.AreEqual(expectedLifeLeft, caballero.Health);
        }

        [Test]
        public void TestCure() {
            Knight caballero1 = new Knight("Caba1");
            Knight caballero2 = new Knight("Caba2");
            int expectedLifeLeft = Character.K_MaxHealth;

            caballero2.ReceiveAttack(caballero1.AttackValue);
            caballero2.Cure();
            Assert.AreEqual(expectedLifeLeft, caballero2.Health);
        }
    }
}