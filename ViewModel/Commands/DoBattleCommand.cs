using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
