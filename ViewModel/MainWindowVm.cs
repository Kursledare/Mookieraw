using System.Linq;
using EntityData.Interfaces;
using GameEngine;
using ViewModel.Annotations;

namespace ViewModel
{
    public class MainWindowVm : BaseVm
    {
        private GameManager _gameEngineGameManager;
        private string _gameLog;
        private IEntity _firstCombatant;
        private IEntity _secondCombatant;

        [NotNull]
        public IEntity FirstCombatant
        {
            get { return _firstCombatant; }
            set
            {
                _firstCombatant = value;
                RaisePropertyChanged("FirstCombatant");
            }
        }

        [NotNull]
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

        public IEntity SecondCombatant1
        {
            get
            {
                return _secondCombatant;
            }

            set
            {
                _secondCombatant = value;
            }
        }

        public MainWindowVm()
        {
            GameEngine = new GameManager();


            FirstCombatant = GameEngine.GameObjects.First() as IEntity;
            SecondCombatant = GameEngine.GameObjects.ElementAt(1) as IEntity;
        }

    }
}
