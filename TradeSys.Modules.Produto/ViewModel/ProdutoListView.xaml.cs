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

namespace TradeSys.Modules.Produto.ViewModel
{
    [ViewExport(RegionName = RegionNames.InsertRegion)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class ProdutoListView : UserControl
    {

        public ProdutoListView()
        {
            InitializeComponent();
        }

        [Import]
        public ProdutoListViewModel Model
        {
            get
            {
                return DataContext as ProdutoListViewModel;
            }
            set
            {
                DataContext = value;
            }
        }
    }
}
