using System.Collections.Generic;
using EntityData.Characters;
using EntityData.Monsters;
using GameEngine;
using GameEngine.interfaces;

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
            public ScreenObject ScreenObject { get; set; }
            public IGameObject Target { get; set; }

            public void Action()
            {
                ActionCalled = true;
            }
        }

        [Test]
        public void ActionIsCalledOnGameObjectInRunTurn()
        {
            var gm = new GameManager();
            var go = new DummyGameObject();
            gm.Register(go);
            Assert.That(go.ActionCalled, Is.False);
            gm.RunTurn();
            Assert.That(go.ActionCalled, Is.True);
            gm.Unregister(go);
            gm.RunTurn();
        }


        [Test]
        public void CanRegisterGameObject()
        {
            var gm = new GameManager();
            var go = new DummyGameObject();
            Assert.That(gm.GameObjects.Count, Is.EqualTo(0));
            gm.Register(go);
            Assert.That(gm.GameObjects.Count, Is.EqualTo(1));
            Assert.That(gm.GameObjects.Contains(go), Is.EqualTo(true));
            gm.Unregister(go);
            gm.RunTurn();
        }
        /// <summary>
        /// Test that all Entitys can be register in TurnManager
        /// If you add new please add them here..
        /// </summary>
        [Test]
        public void CanRegisterRealStuffToTurnManager()
        {
            var gm = new GameManager();
            var listofObjectsToRegister = new List<object>
            {
                new BasicFighter("TestFighter"),
                new Goblin()
            };

            listofObjectsToRegister.ForEach(x =>
            {
                Assert.That(x is IGameObject, Is.True);
                var y = x as IGameObject;
                Assert.DoesNotThrow(() => { gm.Register(y); });
            });
            Assert.That(gm.GameObjects.Count, Is.EqualTo(listofObjectsToRegister.Count));
            listofObjectsToRegister.ForEach(x => { gm.Unregister(x as IGameObject); });
        }
    }
}