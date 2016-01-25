using System.Collections.Generic;
using System.Linq;
using CommandHandler.interfaces;
using GameEngine.interfaces;

namespace GameEngine
{
    public class GameManager
    {
        public readonly List<IGameObject> GameObjects = new List<IGameObject>();
        private readonly List<IGameObject> _gameObjectsToRemove = new List<IGameObject>();

        public IGameObject CurrentCharacter { get; set; }

        public List<IGameObject> AvailibleTargets => (from gameObject in GameObjects.OfType<ICommandable>()
                                                      where gameObject.PlayerControlled == false
                                                      select gameObject as IGameObject).ToList();

        public List<IGameObject> Party
            =>
                (from gameObject in GameObjects.OfType<ICommandable>()
                 where gameObject.PlayerControlled
                 select gameObject as IGameObject).ToList();

        public void Register(IGameObject gameObject)
        {
            GameObjects.Add(gameObject);
        }

        public void Unregister(IGameObject gameObject)
        {
            if (GameObjects.Contains(gameObject)) _gameObjectsToRemove.Add(gameObject);
        }

        public void RunTurn()
        {
            foreach (var gameObject in _gameObjectsToRemove)
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