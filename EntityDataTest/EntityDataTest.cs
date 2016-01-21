using EntityData;
using NUnit.Framework;

namespace EntityDataTest
{
    [TestFixture]
    public class CharacterTest
    {
        [Test]
        public void CharacterCanAttack()
        {
            var testCharacter = new Character()
            {
                CurrentHp = 100,
                Ac = 100
            };
            var testTarget = new Character()
            {
                CurrentHp = 100,
                Ac = 0

            };
            testCharacter.Target = testTarget;
            var targetHpBeforeAttack = testTarget.CurrentHp;
            testCharacter.Action();
            Assert.That(testTarget.CurrentHp, Is.LessThan(targetHpBeforeAttack));
        }
    }
}