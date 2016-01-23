using System;
using EntityData.Characters;
using EntityData.Monsters;
using NUnit.Framework;

namespace Tests
{
    [TestFixture()]
    internal class BasicFighterTests
    {
        [Test]
        public void CanCreateBasicFighter()
        {
            Assert.DoesNotThrow(() => { var testFighter = new BasicFighter("TestFighter"); });
        }
        [Test]
        public void BasicFighterHpBelowZeroResultsInUnActive()
        {

            var testBasicFighter = new BasicFighter("TestFighter");
            var testTarget = new BasicFighter("TestTarget");
            Assert.That(testTarget.IsActive, Is.True);
            while (testTarget.CurrentHp > 0)
            {
                testBasicFighter.Attack(testTarget);
            }
            Assert.That(testTarget.IsActive, Is.False);
        }
        [Test]
        public void BasicFighterCanAttack()
        {
            //Brittle test, can fail if unlucky with dices
            var testFighter = new BasicFighter("TestFighter");
            var testGoblin = new Goblin();
            var hpBefore = testGoblin.CurrentHp;
            Console.WriteLine($"Initial Hp: {hpBefore}");
            for (var i = 0; i < 8; i++)
            {
                testFighter.Attack(testGoblin);
                Console.WriteLine($"Post Attack {i} Hp: {testGoblin.CurrentHp}");
            }
            Assert.That(testGoblin.CurrentHp, Is.LessThan(hpBefore));
        }
    }
}