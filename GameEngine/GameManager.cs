﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using CommandHandler.interfaces;
using GameEngine.interfaces;

namespace GameEngine
{
    /// <summary>
    /// GameManager is the class that handles a game, it handles all the gameobjects and runs the current turn
    /// based of the gameobjects Initative
    /// </summary>
    public class GameManager
    {
        public static GameManager ActiveGameManager;
        private int _currentCharacterIndex;
        /// <summary>
        /// Action that is invoked in Unregister(IGameObject), before IGameObject is removed from GameManager
        /// </summary>
        public Action<IGameObject> UnregisterEvent;
        /// <summary>
        /// This is the list of all gameobjects in the "Scene", visible or not.
        /// Use the method Register To add new objects.
        /// </summary>
        public readonly List<IGameObject> GameObjects = new List<IGameObject>();
        private readonly List<IGameObject> _gameObjectsToRemove = new List<IGameObject>();

        /// <summary>
        /// CurrentCharacter is the currently selected character, use this property to select actions, add a target to this object.
        /// </summary>
        public IGameObject CurrentCharacter
        {
            get
            {
                if (_currentCharacterIndex < 0 || _currentCharacterIndex >= Party.Count) return null;
                return Party[_currentCharacterIndex];
            }
            set { _currentCharacterIndex = Party.IndexOf(value); }
        }

        /// <summary>
        /// AvalibleTargets is a List of GameObjects from "GameObjects" that implement ICommandable and is NOT PlayerControlled
        /// TODO Could be based of the distance from the CurrentCharacter
        /// </summary>
        public List<IGameObject> AvailibleTargets
        {
            get
            {
                return
                    GameObjects.Where(go => CurrentCharacter!=null &&Vector2.Distance(go.Position, CurrentCharacter.Position) < 5)
                        .Where(go => go is ICommandable)
                        .Where(go => (go as ICommandable).PlayerControlled == false)
                        .ToList();
            }
        }

        /// <summary>
        /// Party is a list of the playerControlled characters
        /// </summary>
        public List<IGameObject> Party
            =>
                (from gameObject in GameObjects.OfType<ICommandable>()
                 where gameObject.PlayerControlled
                 select gameObject as IGameObject).ToList();
        /// <summary>
        /// Add a object to the scene, gameObject is a IGameObject
        /// </summary>
        /// <param name="gameObject"></param>
        public void Register(IGameObject gameObject)
        {
            GameObjects.Add(gameObject);
            SelectedCarachterOpaciySet();
        }

        private void SelectedCarachterOpaciySet()
        {
            foreach (var gameObject in Party)
            {
                gameObject.ScreenObject.Image.Opacity = 1d;
                if(gameObject==CurrentCharacter) gameObject.ScreenObject.Image.Opacity = .7d;
            }
        }

        /// <summary>
        /// When somebody dies, or when a gameobject doesnt need to be called anyMore, Use Unregister, and it will be removes before the next "Turn"
        /// </summary>
        /// <param name="gameObject"></param>
        public void Unregister(IGameObject gameObject)
        {
            UnregisterEvent?.Invoke(gameObject);
            if (GameObjects.Contains(gameObject)) _gameObjectsToRemove.Add(gameObject);
        }
        /// <summary>
        /// When all decisions and actions are selected "RunTurn" should be called, and it will iterate through all the gameObjects and run their "Actions".
        /// Action is run on each GameObject in "GameObject" ordered by Descending Initative.
        /// </summary>
        public void RunTurn()
        {
            foreach (var gameObject in _gameObjectsToRemove)
            {
                GameObjects.Remove(gameObject);
            }
            foreach (var gameObject in GameObjects.OrderByDescending(a => a.Initiative))
            {
                if (gameObject.IsActive) gameObject.Action();
                else Unregister(gameObject);
            }
        }
        /// <summary>
        /// Sets CurrentCharacter To the next character in Party.
        /// </summary>
        public void SelectNextCharacter()
        {
            var max = Party.Count - 1;
            _currentCharacterIndex = _currentCharacterIndex + 1 > max ? 0 : _currentCharacterIndex + 1;
            SelectedCarachterOpaciySet();
        }
        public GameManager()
        {
            ActiveGameManager = this;
        }
    }
}