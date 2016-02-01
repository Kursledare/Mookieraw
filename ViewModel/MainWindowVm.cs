using System;
using System.Linq;
using EntityData.Characters;
using EntityData.Interfaces;
using GameEngine;
using ViewModel.Annotations;
using ViewModel.Commands;

namespace ViewModel
{
    public class MainWindowVm : BaseVm
    {
        private GameManager _gameEngineGameManager;
        private string _gameLog;
        private IEntity _firstCombatant;
        private IEntity _secondCombatant;

        public DoBattleCommand DoBattleButtonCommand { get; set; }
        public bool DoBattleButtonEnabled { get; set; } = true;
        public string FirstCombatantHp
        {
            get { return FirstCombatant.CurrentHp.ToString(); }
            set { }
        }
        public string SecondCombatantHp
        {
            get { return SecondCombatant.CurrentHp.ToString(); }
            set { }
        }
        public string FirstCombatantAc
        {
            get { return FirstCombatant.Ac.ToString(); }
            set { }
        }
        public string SecondCombatantAc
        {
            get { return SecondCombatant.Ac.ToString(); }
            set { }
        }
        public IEntity FirstCombatant
        {
            get { return _firstCombatant; }
            set
            {
                _firstCombatant = value;
                RaisePropertyChanged("FirstCombatant");
            }
        }

        public IEntity SecondCombatant
        {
            get { return _secondCombatant; }
            set
            {
                _secondCombatant = value;
                RaisePropertyChanged("SecondCombatant");
            }
        }

        public string GameLog
        {
            get { return _gameLog; }
            set
            {
                _gameLog = value;
                RaisePropertyChanged("GameLog");
                RaisePropertyChanged(nameof(FirstCombatantHp));
                RaisePropertyChanged(nameof(SecondCombatantHp));
                RaisePropertyChanged(nameof(FirstCombatantAc));
                RaisePropertyChanged(nameof(SecondCombatantAc));
                
            }
        }

        public GameManager GameEngine
        {
            get { return _gameEngineGameManager; }
            set
            {
                _gameEngineGameManager = value;
                RaisePropertyChanged("GameEngine");
            }
        }

        public MainWindowVm()
        {
            DoBattleButtonCommand = new DoBattleCommand(this);
            Game.OnGameLoggedEntry += UpdateGameLog;

            GameEngine = new GameManager();
            var bs = new BasicFighter("Urban den förskräcklige");
            var bs2 = new BasicFighter("Jurgen den Oförskräklige");

            bs.Target = bs2;
            bs2.Target = bs;

            bs.AddCommand(CommandHandler.enums.Commands.MeleeAttack);
            bs2.AddCommand(CommandHandler.enums.Commands.MeleeAttack);

            GameEngine.Register(bs);
            GameEngine.Register(bs2);

            FirstCombatant = GameEngine.GameObjects.First() as IEntity;
            SecondCombatant = GameEngine.GameObjects.ElementAt(1) as IEntity;
            RaisePropertyChanged(nameof(FirstCombatantHp));
            RaisePropertyChanged(nameof(SecondCombatantHp));
            RaisePropertyChanged(nameof(FirstCombatantAc));
            RaisePropertyChanged(nameof(SecondCombatantAc));
        }

        public void UpdateGameLog(string message)
        {
            if (FirstCombatant.CurrentHp <= 0 || SecondCombatant.CurrentHp <= 0) DoBattleButtonEnabled = false;
            RaisePropertyChanged(nameof(DoBattleButtonEnabled));
            GameLog += message + Environment.NewLine;
        }
    }
}
