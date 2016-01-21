using System;
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
            public Boolean ActionCalled { get; private set; }
            public int Initiative { get; } = 1;
            public bool IsActive { get; } = true;
            public Vector2 Position { get; }=new Vector2();
            public IGameObject Target { get; set; }

            public void Action()
            {
                ActionCalled = true;
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
            Unregister(go);
            RunTurn();
        }

        [Test]
        public void ActionIsCalledOnGameObjectInRunTurn()
        {
            var go = new DummyGameObject();
            Register(go);
            Assert.That(go.ActionCalled,Is.False);
            RunTurn();
            Assert.That(go.ActionCalled,Is.True);
            Unregister(go);
            RunTurn();

        }
    }
}