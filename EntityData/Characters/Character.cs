using System;
using System.Collections.Generic;
using System.Linq;
using CommandHandler.enums;
using Dices;
using EntityData.Interfaces;
using GameEngine;
using GameEngine.interfaces;

namespace EntityData.Characters
{
    public class Character : IPlayerCharacter
    {
        #region Constructors

        public Character()
        {
            _d20 = new Dice(20);
            Equipment = new Equipment();
            IsActive = true;
        }

        #endregion

        #region Fields

        private readonly Dice _d20;

        #endregion

        #region Basic Properties

        public string Name { get; set; }

        public int Level { get; set; }

        public Class Class { get; set; }

        public Race Race { get; set; }

        public Equipment Equipment { get; set; }

        public Inventory Inventory { get; set; }

        public int TotalHp { get; set; }

        public int CharAttackBonus { get; set; }

        public int InitiativeBonus { get; set; }

        public int Initiative
        {
            get { return _d20.Roll() + InitiativeBonus; }
        }

        public Attributes Attributes { get; set; }
        public int AttackBonus { get; set; }
        public int DamageBonus { get; set; }

        #endregion

        #region IGameObject properties

        public bool IsActive { get; }
        public Vector2 Position { get; set; }
        public ScreenObject ScreenObject { get; set; }
        public IGameObject Target { get; set; }

        #endregion

        #region ICommandable properties

        private readonly Queue<Commands> _currentCommands = new Queue<Commands>();

        public bool AddCommand(Commands commands)
        {
            if (_currentCommands.Count >= NumberOfCommandsPerTurn) return false;
            _currentCommands.Enqueue(commands);
            return true;
        }

        public Commands GetNextCommand()
        {
            if (_currentCommands.Count < 1) return Commands.None;
            return _currentCommands.Dequeue();
        }

        public Commands AvailableCommands
        {
            get
            {
                //TODO return Available commands based on class ?
                return Commands.Attack;
            }
        }

        public bool PlayerControlled { get; }
        public int NumberOfCommandsPerTurn { get; } = 1;

        #endregion

        #region Entity Properties

        public int CurrentHp { get; set; }

        public int Ac
        {
            get { return 10 + Attributes.DexModifier + Equipment.GetEquipmentArmorValue(); }
            set { }
        }

        public int FortSave { get; set; }
        public int ReflexSave { get; set; }
        public int WillSave { get; set; }

        public void AlterHealth(int amount)
        {
            CurrentHp += amount;
        }

    
        #endregion

        #region Methods

        public void Action()
        {
            var numberOfActionsPerformed = 0;
            foreach (var command in _currentCommands)
            {
                numberOfActionsPerformed++;
                switch (command)
                {
                    case Commands.Attack:
                        var targetEntity = Target as IEntity;
                        if (targetEntity != null) Attack(targetEntity);
                        break;
                    case Commands.Move:
                        throw new NotImplementedException();
                        break;
                    case Commands.Defend:
                        throw new NotImplementedException();
                        break;
                    default:
                        break;
                }
            }
        }

        public void Attack(IEntity entity)
        {
            if (_d20.Roll()+AttackBonus >= entity.Ac)
            {
                var damage = CalculateDamage();
                entity.AlterHealth(-damage);
            }
        }

        public int CalculateDamage()
        {
            var weaponDamage = Equipment.Weapons.First().DamageRoll();

            var damageBonus = 0;

            if (Equipment.Shield != null)
                damageBonus = Attributes.GetModifier(AttributeTypes.Str);
            else
                damageBonus = (int) (Attributes.GetModifier(AttributeTypes.Str)*1.5);

            return weaponDamage + damageBonus;
        }

        #endregion
    }
}