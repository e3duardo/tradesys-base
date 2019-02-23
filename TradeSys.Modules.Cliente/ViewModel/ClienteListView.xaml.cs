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

namespace TradeSys.Modules.Cliente.ViewModel
{
    /// <summary>
    /// Interação lógica para ClienteListView.xam
    /// </summary>
    [ViewExport(RegionName = RegionNames.ListRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ClienteListView : UserControl
    {
        public ClienteListView()
        {
            InitializeComponent();
        }

        [Import]
        public ClienteListViewModel Model
        {
            get
            {
                return DataContext as ClienteListViewModel;
            }
            set
            {
                DataContext = value;
            }
        }
    }
}
