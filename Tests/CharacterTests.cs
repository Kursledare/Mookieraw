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
            var testCharacter = new Character();
            bool addAttackCommandResult;
            for (var i = 0; i < testCharacter.NumberOfActionPointsPerTurn; i++)
            {
                addAttackCommandResult = testCharacter.AddCommand(Commands.MeleeAttack);
                Assert.That(addAttackCommandResult, Is.True);
            }
            addAttackCommandResult = testCharacter.AddCommand(Commands.MeleeAttack);
            Assert.That(addAttackCommandResult, Is.False);
        }
    }
}