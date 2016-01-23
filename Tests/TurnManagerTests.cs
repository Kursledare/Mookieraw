using System.Collections.Generic;
using EntityData.Characters;
using EntityData.Monsters;
using NUnit.Framework;
using TurnManager;
using TurnManager.interfaces;
using static TurnManager.TurnManager;

namespace Tests
{
    [TestFixture]
    public class TurnManagerTest
    {
        private class DummyGameObject : IGameObject
        {
            public bool ActionCalled { get; private set; }
            public int Initiative { get; } = 1;
            public bool IsActive { get; } = true;
            public Vector2 Position { get; set; } = new Vector2();
            public IGameObject Target { get; set; }

            public void Action()
            {
                ActionCalled = true;
            }
        }

        [Test]
        public void ActionIsCalledOnGameObjectInRunTurn()
        {
            var go = new DummyGameObject();
            Register(go);
            Assert.That(go.ActionCalled, Is.False);
            RunTurn();
            Assert.That(go.ActionCalled, Is.True);
            Unregister(go);
            RunTurn();
        }


        [Test]
        public void CanRegisterGameObject()
        {
            var go = new DummyGameObject();
            Assert.That(GameObjects.Count, Is.EqualTo(0));
            Register(go);
            Assert.That(GameObjects.Count, Is.EqualTo(1));
            Assert.That(GameObjects.Contains(go), Is.EqualTo(true));
            Unregister(go);
            RunTurn();
        }
        /// <summary>
        /// Test that all Entitys can be register in TurnManager
        /// If you add new please add them here..
        /// </summary>
        [Test]
        public void CanRegisterRealStuffToTurnManager()
        {
            var listofObjectsToRegister = new List<object>
            {
                new BasicFighter("TestFighter"),
                new Goblin()
            };

            listofObjectsToRegister.ForEach(x =>
            {
                Assert.That(x is IGameObject, Is.True);
                var y = x as IGameObject;
                Assert.DoesNotThrow(() => { Register(y); });
            });
            Assert.That(GameObjects.Count, Is.EqualTo(listofObjectsToRegister.Count));
            listofObjectsToRegister.ForEach(x => { Unregister(x as IGameObject); });
        }
    }
}