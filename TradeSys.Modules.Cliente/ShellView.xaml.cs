using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TradeSys.Infrastructure;
using System.ComponentModel.Composition;

namespace TradeSys.Modules.Cliente
{
    /// <summary>
    /// Interação lógica para ShellView.xam
    /// </summary>
    [ViewExport(RegionName = RegionNames.MainRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ShellView : UserControl
    {
        public ShellView()
        {
            InitializeComponent();
        }

        [Import]
        public ShellViewModel Model
        {
            get
            {
                return DataContext as ShellViewModel;
            }
            set
            {
                DataContext = value;
            }
        }
    }
}
