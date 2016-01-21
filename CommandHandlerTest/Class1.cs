using CommandHandler.enums;
using CommandHandler.interfaces;
using NUnit.Framework;

namespace CommandHandlerTest
{
    [TestFixture]
    public class CommandHandlerTest
    {
        public class DummyCharacter:ICommandable
        {
            private Commands _availableCommands;
            public DummyCharacter()
            {
                _availableCommands = Commands.Move;
                Name = "TestCharacter";
            }

            public string Name { get; set; }
            public Commands CurrentCommands { get; set; }
            public Commands GetAvailableCommands()
            {
                throw new System.NotImplementedException();
            }
        }
        [Test]
        public void UserCommandableCommandHandler()
        {
            var testChar = new DummyCharacter();
            testChar.GetAvailableCommands();
        }
    }
}