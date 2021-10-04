using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class TypeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWizardTypes() {
            Wizard gandalf = new Wizard("Gandalf");
            Assert.IsTrue(gandalf is MagicHero && gandalf is Hero && gandalf is Character);
        }

        [Test]
        public void TestArcherTypes() {
            Archer legolas = new Archer("Legolas");
            Assert.IsTrue(legolas is Hero && legolas is Character);
        }

        [Test]
        public void TestKnightTypes() {
            Knight caballero = new Knight("Caballero genérico");
            Assert.IsTrue(caballero is Hero && caballero is Character);
        }

        [Test]
        public void TestDwarfTypes() {
            Dwarf gimli = new Dwarf("Gimli");
            Assert.IsTrue(gimli is Hero && gimli is Character);
        }

        [Test]
        public void TestArmorTypes() {
            Armor armadura = new Armor();
            Assert.IsTrue(armadura is IItem && armadura is IDefenseItem);
        }

        [Test]
        public void TestAxeTypes() {
            Axe hacha = new Axe();
            Assert.IsTrue(hacha is IItem && hacha is IAttackItem);
        }

        [Test]
        public void TestBowTypes() {
            Bow arco = new Bow();
            Assert.IsTrue(arco is IItem && arco is IAttackItem);
        }

        [Test]
        public void TestHelmetTypes() {
            Helmet casco = new Helmet();
            Assert.IsTrue(casco is IItem && casco is IDefenseItem);
        }

        [Test]
        public void TestShieldTypes() {
            Shield escudo = new Shield();
            Assert.IsTrue(escudo is IItem && escudo is IDefenseItem);
        }

        [Test]
        public void TestSpellOneTypes() {
            SpellOne hechizo = new SpellOne();
            Assert.IsTrue(hechizo is ISpell);
        }

        [Test]
        public void TestSpellsBookTypes() {
            SpellsBook libro = new SpellsBook();
            Assert.IsTrue(libro is IMagicalItem && libro is IMagicalDefenseItem && libro is IMagicalAttackItem);
        }

        [Test]
        public void TestStaffTypes() {
            Staff baston = new Staff();
            Assert.IsTrue(baston is IItem && baston is IAttackItem && baston is IDefenseItem);
        }

        [Test]
        public void TestSwordTypes() {
            Sword espada = new Sword();
            Assert.IsTrue(espada is IItem && espada is IAttackItem);
        }
    }
}