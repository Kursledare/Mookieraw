using EntityData.Characters;
using EntityData.Monsters;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    internal class GoblinTests
    {
        [Test]
        public void CanCreateGoblin()
        {
            Assert.DoesNotThrow(() => { var testGoblin = new Goblin(); });
        }
        /// <summary>
        /// Tests that initial values are correct.
        /// </summary>
        [Test]
        public void GoblinProperlyInitialized()
        {
            var testGoblin = new Goblin();
            Assert.That(testGoblin.IsActive, Is.True);
        }
        [Test]
        public void GoblinHpBelowZeroResultsInUnActive()
        {
            var testBasicFighter = new BasicFighter("TestFighter");
            var testGoblin = new Goblin();
            Assert.That(testGoblin.IsActive, Is.True);
            while (testGoblin.CurrentHp > 0)
            {
                testBasicFighter.Attack(testGoblin);
            }
            Assert.That(testGoblin.IsActive, Is.False);
        }

    }
}