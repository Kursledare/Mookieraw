﻿using CommandHandler.enums;
using EntityData.Characters;

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