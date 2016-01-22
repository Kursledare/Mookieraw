using CommandHandler.enums;
using EntityData.Characters;
using EntityData.Monsters;
using NUnit.Framework;

namespace EntityDataTest
{
    [TestFixture]
    public class CharacterTest
    {
        [Test]
        public void AddCommandWorkingProperly()
        {
            var testCharacter = new Character();
            bool addAttackCommandResult;
            for (var i = 0; i < testCharacter.NumberOfCommandsPerTurn; i++)
            {
                addAttackCommandResult = testCharacter.AddCommand(Commands.Attack);
                Assert.That(addAttackCommandResult, Is.True);
            }
            addAttackCommandResult = testCharacter.AddCommand(Commands.Attack);
            Assert.That(addAttackCommandResult, Is.False);
        }

        [Test]
        public void BasicFighterCanAttack()
        {
            //Brittle test, can fail if unlucky with dices
            var testFighter = new BasicFighter("TestFighter");
            var testGoblin = new Goblin();
            var HpBefore = testGoblin.CurrentHp;
            testFighter.Attack(testGoblin);
            testFighter.Attack(testGoblin);
            testFighter.Attack(testGoblin);
            testFighter.Attack(testGoblin);
            testFighter.Attack(testGoblin);
            testFighter.Attack(testGoblin);
            testFighter.Attack(testGoblin);
            testFighter.Attack(testGoblin);
            Assert.That(testGoblin.CurrentHp,Is.LessThan(HpBefore));
        }

        [Test]
        public void CanCreateBasicFighter()
        {
            Assert.DoesNotThrow(() => { var testFighter = new BasicFighter("TestFighter"); });
        }

        [Test]
        public void CanCreateGoblin()
        {
            Assert.DoesNotThrow(() => { var testGoblin = new Goblin(); });
        }
    }
}