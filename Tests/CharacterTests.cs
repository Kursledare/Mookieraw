using CommandHandler.enums;
using EntityData.Characters;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CharacterTest
    {
        [Test]
        public void AddCommandWorkingProperly()
        {
            var testCharacter = new BasicFighter("Hej");
            bool addAttackCommandResult;
            for (var i = 0; i < testCharacter.NumberOfCommandsPerTurn; i++)
            {
                addAttackCommandResult = testCharacter.AddCommand(Commands.Attack);
                Assert.That(addAttackCommandResult, Is.True);
            }
            addAttackCommandResult = testCharacter.AddCommand(Commands.Attack);
            Assert.That(addAttackCommandResult, Is.False);
        }
    }
}