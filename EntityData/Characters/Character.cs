using System;
using System.Collections.Generic;
using System.Linq;
using CommandHandler.enums;
using EntityData.Interfaces;
using GameEngine;
using GameEngine.interfaces;

namespace EntityData.Characters
{
    public class Character : IPlayerCharacter
    {
       
        #region Fields
        private string _name;
        private int _level;
        private Class _class;
        private Race _race;
        private Equipment _equipment;
        private Inventory _inventory;
        private int _totalHp;
        private int _charAttackBonus;
        private Dices.D20 _d20;
        #endregion

        #region Basic Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public Class Class
        {
            get { return _class; }
            set { _class = value; }
        }
        public Race Race
        {
            get { return _race; }
            set { _race = value; }
        }
        public Equipment Equipment
        {
            get { return _equipment; }
            set { _equipment = value; }
        }
        public Inventory Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }
        public int TotalHp
        {
            get { return _totalHp; }
            set { _totalHp = value; }
        }
        public int CharAttackBonus
        {
            get { return _charAttackBonus; }
            set { _charAttackBonus = value; }
        }
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
        public bool IsActive { get; private set; }
        public Vector2 Position { get; set; }
        public ScreenObject ScreenObject { get; set; }
        public IGameObject Target { get; set; }
        #endregion

        #region ICommandable properties

        private Queue<Commands> _currentCommands=new Queue<Commands>();

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
        public  Int32 NumberOfCommandsPerTurn { get; }= 1;
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
        #endregion

        #region Methods
        public void Action()
        {
            var numberOfActionsPerformed = 0;
            foreach (Commands command in _currentCommands)
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
            if (_d20.Roll(AttackBonus) >= entity.Ac)
            {
                var damage = CalculateDamage();
                entity.CurrentHp = entity.CurrentHp - damage;
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

        #region Constructors
        public Character()
        {
            _d20 = new Dices.D20();
            Equipment=new Equipment();
            IsActive = true;
        }
        #endregion


    }
}
