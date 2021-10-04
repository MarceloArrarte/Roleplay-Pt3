using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class SpellsbookTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSpellAddition()
        {
            SpellsBook libro = new SpellsBook();
            SpellOne hechizo = new SpellOne();
            libro.AddSpell(hechizo);

            Assert.IsTrue(libro.AttackValue > 0);
        }

        [Test]
        public void TestSpellRemoval()
        {
            SpellsBook libro = new SpellsBook();
            SpellOne hechizo = new SpellOne();
            libro.AddSpell(hechizo);
            libro.RemoveSpell(hechizo);

            Assert.IsTrue(libro.AttackValue == 0);
        }

        [Test]
        public void TestSpellbookAttack()
        {
            SpellsBook libro = new SpellsBook();
            SpellOne hechizo = new SpellOne();
            int cantidad = 5;
            for (int i = 0; i < cantidad; i++) {
                libro.AddSpell(hechizo);
            }

            Assert.AreEqual(libro.AttackValue, hechizo.AttackValue * cantidad);
        }

        [Test]
        public void TestSpellbookDefense()
        {
            SpellsBook libro = new SpellsBook();
            SpellOne hechizo = new SpellOne();
            int cantidad = 5;
            for (int i = 0; i < cantidad; i++) {
                libro.AddSpell(hechizo);
            }

            Assert.AreEqual(libro.DefenseValue, hechizo.DefenseValue * cantidad);
        }
    }
}