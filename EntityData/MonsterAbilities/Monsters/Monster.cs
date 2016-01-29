﻿using System;
using CommandHandler.enums;
using EntityData.Interfaces;
using GameEngine;
using GameEngine.interfaces;

namespace EntityData.Monsters
{
    public abstract class Monster : IMonster
    {
        protected Monster()
        {
            Equipment = new Equipment();
            IsActive = true;
        }
        public int Initiative { get; }
        public bool IsActive { get; private set; }
        public Vector2 Position { get; set; }
        public ScreenObject ScreenObject { get; set; }
        public IGameObject Target { get; set; }
        public void Action()
        {
            //throw new NotImplementedException();
        }

        public Commands CurrentCommands { get; set; }
        public Commands AvailableCommands { get; }
        public int NumberOfCommandsPerTurn { get; }
        public bool PlayerControlled { get; }
        public bool AddCommand(Commands commands)
        {
            throw new NotImplementedException();
        }

        public Commands GetNextCommand()
        {
            throw new NotImplementedException();
        }

        public string Name { get; set; }
        public Size Size { get; set; }
        public BaseSpeed Basespeed { get; set; }
        public int TotalHp { get; set; }
        public int CurrentHp { get; set; }
        public int Ac { get; set; }
        public int FortSave { get; set; }
        public int ReflexSave { get; set; }
        public int WillSave { get; set; }
        public void AlterHealth(int amount)
        {
            CurrentHp += amount;
            IsActive = CurrentHp > 0;
        }

        public int InitiativeBonus { get; set; }
        public Attributes Attributes { get; set; }
        public int AttackBonus { get; set; }
        public int DamageBonus { get; set; }
        public Equipment Equipment { get; set; }
    }
}