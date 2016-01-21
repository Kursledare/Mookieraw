using NUnit.Framework;
using TurnManager;
using TurnManager.interfaces;
using static TurnManager.TurnManager;

namespace TurnManagerTest
{
    [TestFixture]
    public class TurnManagerTest
    {
        private class DummyGameObject:IGameObject
        {
            public int Initiative { get; }
            public bool IsActive { get; }
            public Vector2 Position { get; }
            public void Action()
            {
                throw new System.NotImplementedException();
            }
        }
        [Test]
        public void CanRegisterGameObject()
        {
            var go = new DummyGameObject();
            Assert.That(GameObjects.Count,Is.EqualTo(0));
            Register(go);
            Assert.That(GameObjects.Count,Is.EqualTo(1));
            Assert.That(GameObjects.Contains(go),Is.EqualTo(true));
        }
    }
}