using System;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Practices.Prism.MefExtensions;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Windows.Controls.Ribbon;
using TradeSys.Infrastructure;

namespace TradeSys
{

    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    [Export]
    public partial class Shell : RibbonWindow
    {

        public Shell()
        {
            InitializeComponent();

            // Insert code required on object creation below this point.
        }

        [Import]
        ShellViewModel ViewModel
        {
            set
            {
                this.DataContext = value;
            }
        }

        System.Collections.ObjectModel.Collection<RibbonGroup> rbcollection;

        private void Window_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            //IModuleCatalog imc = Application.;
            //Console.WriteLine(imc.Modules);
            ConfigurationModuleCatalog cmc = new ConfigurationModuleCatalog();
            Console.WriteLine(cmc.Modules);
            /*


            foreach (var tmp in mt.GetModuleLoadeds())
            {
                RibbonGroup rb2 = new RibbonGroup();
                rb2.Header = tmp;
                rbcollection.Add(rb2);
            }

            HomeTab.ItemsSource = rbcollection;
            */
            
        }

            
          
    }
}
