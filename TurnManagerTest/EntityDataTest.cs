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
            //TODO
            Assert.That(0, Is.EqualTo(1));
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