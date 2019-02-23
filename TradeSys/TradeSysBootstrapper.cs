//===================================================================================
// Trade Management System
// Sistema de gerenciamento de comércio para lojas de pequeno á médio porte.
//===================================================================================
// Copyright (c) Eduardo Bastos dos Santos.  Todos direitos reservados.
// 
// CRIAÇÃO:         24/06/2011
// MODIFICAÇÔES: 
//===================================================================================
// <Resumo aqui>
//===================================================================================

using System;
using System.ComponentModel.Composition.Hosting;
using System.Windows;
using Microsoft.Practices.Prism.MefExtensions;
using TradeSys.Infrastructure;
using TradeSys.Modules.Financeiro;
using TradeSys.Modules.Cliente;
using TradeSys.Modules.Funcionario;
using TradeSys.Modules.Produto;
using TradeSys.Modules.VendaGeneric;
using Microsoft.Practices.Prism.Modularity;
using TradeSys.Modules.Base;

namespace TradeSys
{
    [CLSCompliant(false)]
    public partial class TradeSysBootstrapper : MefBootstrapper
    {
        protected override void ConfigureAggregateCatalog()
        {
            //todo: add modules here
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(TradeSysBootstrapper).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(TradeSysCommands).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleBase).Assembly));

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleCliente).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleFinanceiro).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleFuncionario).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleProduto).Assembly));

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleVendaGeneric).Assembly));

            //DirectoryCatalog catalog = new DirectoryCatalog("DirectoryModules");
            //this.AggregateCatalog.Catalogs.Add(catalog);

            
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
        {
            var factory = base.ConfigureDefaultRegionBehaviors();

            factory.AddIfMissing("AutoPopulateExportedViewsBehavior",typeof(AutoPopulateExportedViewsBehavior));

            return factory;
        }

        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
        }

    }
}
