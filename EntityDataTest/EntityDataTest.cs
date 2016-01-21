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
            var testCharacter = new Character();
            var testTarget = new Character();
            testCharacter.Target = testTarget;
            var targetHpBeforeAttack = testTarget.CurrentHp;
            testCharacter.Action();
            Assert.That(testTarget.CurrentHp,Is.LessThan(targetHpBeforeAttack));
        }
    }
}