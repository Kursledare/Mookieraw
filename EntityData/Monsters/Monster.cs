using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CommandHandler.enums;
using CommandHandler.interfaces;
using EntityData.Interfaces;
using EntityData.Races;
using GameEngine;
using GameEngine.interfaces;

namespace EntityData.Monsters
{
    public abstract class Monster : IMonster
    {
        private readonly Dices.Dice _d20 = new Dices.Dice(20);
        private readonly Queue<Commands> _currentCommands=new Queue<Commands>();

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
            switch (CurrentCommands)
            {
                case Commands.MeleeAttack:
                   
                    Attack(Target as IEntity);
                    break;
                    case Commands.Move:
                    Position = MovePosition;
                    break;
            }
        }

        private void Attack(IEntity entity)
        {
            Game.Log($"{Name} is attacking {entity.Name}.");
            if (!entity.IsActive)
            {
                Game.Log($"{entity.Name} is dead!");
                return;
            }
            if (_d20.Roll() + AttackBonus >= entity.Ac)
            {
                var damage = CalculateDamage();
                entity.AlterHealth(-damage);
            }
            else
            {
                Game.Log(Name + " missed!");
            }
        }
        public int CalculateDamage()
        {
            var weaponDamage = Equipment.Weapons.First().DamageRoll();

            if (Equipment.Shield == null)
                return (int)(weaponDamage + DamageBonus * 1.5);

            return weaponDamage + DamageBonus;
        }

        public Commands CurrentCommands
        {
            get
            {
                if (_currentCommands.Count > 0) return _currentCommands.Dequeue();
                return Commands.None;
            }
        }

        public Commands AvailableCommands { get; }
        public int NumberOfActionPointsPerTurn { get; }
        public bool PlayerControlled { get; set; }
        public bool AddCommand(Commands command)
        {
            _currentCommands.Enqueue(command);
            return true;
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
            Game.Log($"{Name} took {amount} Hp damage.");
        }

        public int InitiativeBonus { get; set; }
        public Attributes Attributes { get; set; }
        public int AttackBonus { get; set; }
        public int DamageBonus { get; set; }
        public Equipment Equipment { get; set; }

        public Vector2 MovePosition { get; set; }

       
    }
}