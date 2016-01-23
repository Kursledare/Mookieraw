using System;
using NUnit.Framework;
using TurnManager;
using TurnManager.interfaces;

namespace Tests
{
    [TestFixture]
    public class TurnManagerTest
    {
        private class DummyGameObject:IGameObject
        {
            public Boolean ActionCalled { get; private set; }
            public int Initiative { get; } = 1;
            public bool IsActive { get; } = true;
            public Vector2 Position { get; set; }=new Vector2();
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
            Assert.That(TurnManager.TurnManager.GameObjects.Count,Is.EqualTo(0));
            TurnManager.TurnManager.Register(go);
            Assert.That(TurnManager.TurnManager.GameObjects.Count,Is.EqualTo(1));
            Assert.That(TurnManager.TurnManager.GameObjects.Contains(go),Is.EqualTo(true));
            TurnManager.TurnManager.Unregister(go);
            TurnManager.TurnManager.RunTurn();
        }

        [Test]
        public void ActionIsCalledOnGameObjectInRunTurn()
        {
            var go = new DummyGameObject();
            TurnManager.TurnManager.Register(go);
            Assert.That(go.ActionCalled,Is.False);
            TurnManager.TurnManager.RunTurn();
            Assert.That(go.ActionCalled,Is.True);
            TurnManager.TurnManager.Unregister(go);
            TurnManager.TurnManager.RunTurn();

        }
    }
}