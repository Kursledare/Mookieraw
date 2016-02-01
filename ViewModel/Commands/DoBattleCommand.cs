namespace ViewModel.Commands
{
    public class DoBattleCommand : BaseCommand
    {
        public override void Execute(object parameter)
        {
            Main.GameEngine.RunTurn();
           
        }

        public override bool CanExecute(object parameter)
        {
            return Main.FirstCombatant.IsActive  && Main.SecondCombatant.IsActive;
        }

        public DoBattleCommand(MainWindowVm main) : base(main)
        {
        }
    }
}
