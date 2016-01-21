using System;
using Dices;
using IGameObject.Interfaces;

namespace IGameObject
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
        private Dice.D20 _d20;
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

        #region Entity Properties
        public int CurrentHp { get; set; }
        public int Ac { get; set; }
        public int FortSave { get; set; }
        public int ReflexSave { get; set; }
        public int WillSave { get; set; }
        #endregion

        #region Methods
        public bool IsActive()
        {
            throw new NotImplementedException();
        }
        public void Attack(IEntity entity)
        {
            //int d20Cast = Dice.D20();
            var random = new Random();
            int d20Cast = random.Next(1, 21);

            if (d20Cast + AttackBonus >= entity.Ac)
            {
                var damage = CalculateDamage();
                entity.CurrentHp = entity.CurrentHp - damage;
            }
        }
        public int CalculateDamage()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Constructors
        public Character()
        {
            _d20 = new Dice.D20();
        } 
        #endregion
    }
}
