using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel.Commands
{
    public abstract class BaseCommand : ICommand
    {
        public MainWindowVm Main { get; set; }

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
        

        public event EventHandler CanExecuteChanged;

        public BaseCommand(MainWindowVm main)
        {
            Main = main;
        }
    }
}
