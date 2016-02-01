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
            return Main.FirstCombatant.CurrentHp > 0 && Main.SecondCombatant.CurrentHp > 0;
        }

        public DoBattleCommand(MainWindowVm main) : base(main)
        {
        }
    }
}
