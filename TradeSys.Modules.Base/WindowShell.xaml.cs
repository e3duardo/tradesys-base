using System.Windows;
using System.ComponentModel.Composition;

namespace TradeSys.Modules.Base
{
    /// <summary>
    /// Interaction logic for WindowSHell.xaml
    /// </summary>
   [Export]
    public partial class WindowShell : Window
    {
        public WindowShell()
        {
            InitializeComponent();
        }


        [Import]
        WindowsShellViewModel ViewModel
        {
            set
            {
                this.DataContext = value;
            }
        }
    }
}
