namespace ViewModel.Commands
{
    public class DoBattleCommand : BaseCommand
    {
        public override void Execute(object parameter)
        {
            Main.GameEngine.RunTurn();
           
        }

        public DoBattleCommand(MainWindowVm main) : base(main)
        {
        }
    }
}
