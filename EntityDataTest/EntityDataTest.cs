using CommandHandler.enums;
using EntityData;
using Items;
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
            for (var i = 0; i < testCharacter.NumberOfCommandsPerTurn;i++)
            {
                addAttackCommandResult=testCharacter.AddCommand(Commands.Attack);
                Assert.That(addAttackCommandResult,Is.True);
            }
            addAttackCommandResult = testCharacter.AddCommand(Commands.Attack);
            Assert.That(addAttackCommandResult, Is.False);
        }
        [Test]
        public void CharacterCanAttack()
        {
            var testCharacter = new Character()
            {
                CurrentHp = 100,
                Ac = 100
            };
            testCharacter.Equipment.Weapons.Add(new GreatSword());
            var testTarget = new Character()
            {
                CurrentHp = 100,
                Ac = 0
                
            };

            testCharacter.Target = testTarget;

            var targetHpBeforeAttack = testTarget.CurrentHp;

            var addAttackCommandResult = testCharacter.AddCommand(Commands.Attack);
            Assert.That(addAttackCommandResult,Is.True);


            testCharacter.Action();
            Assert.That(testTarget.CurrentHp, Is.LessThan(targetHpBeforeAttack));
        }
    }
}