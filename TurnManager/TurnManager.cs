using System.Collections.Generic;
using System.Linq;
using TurnManager.interfaces;

namespace TurnManager
{
    public static class TurnManager
    {
        public static readonly List<IGameObject> GameObjects = new List<IGameObject>();
        private static readonly List<IGameObject> GameObjectsToRemove = new List<IGameObject>();

        public static void Register(IGameObject gameObject)
        {
            GameObjects.Add(gameObject);
        }

        public static void Unregister(IGameObject gameObject)
        {
            if (GameObjects.Contains(gameObject)) GameObjectsToRemove.Add(gameObject);
        }

        public static void RunTurn()
        {
            foreach (var gameObject in GameObjectsToRemove)
            {
                GameObjects.Remove(gameObject);
            }
            foreach (var gameObject in GameObjects.OrderByDescending(a => a.Initiative))
            {
                if (gameObject.IsActive) gameObject.Action();
            }
        }
    }
}