using System.Windows;

namespace Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CombatLog.AppendText("Let the Battle Begin!\n=== o === o ===");
        }
    }
}
