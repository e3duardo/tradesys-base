//===================================================================================
// Trade Management System
// Sistema de gerenciamento de comércio para lojas de pequeno á médio porte.
//===================================================================================
// Copyright (c) Eduardo Bastos dos Santos.  Todos direitos reservados.
// 
// CRIAÇÃO:         14/07/2011
// MODIFICAÇÔES: 
//===================================================================================
// <Resumo aqui>
//
//
//
//
//
//
//
//
//
//===================================================================================
using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using TradeSys.ModulesTracking;

namespace TradeSys.Modules.VendaGeneric
{
    [ModuleExport(typeof(ModuleVendaGeneric), DependsOnModuleNames = new string[] { "ModuleBase", "ModuleCliente", "ModuleFinanceiro", "ModuleFuncionario", "ModuleProduto" })]
    public class ModuleVendaGeneric : IModule
    {
        private readonly IModuleTracker moduleTracker;


        [ImportingConstructor]
        public ModuleVendaGeneric(IModuleTracker moduleTracker)
        {
            if (moduleTracker == null)
            {
                throw new ArgumentNullException("moduleTracker");
            }

            this.moduleTracker = moduleTracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleNames.ModuleVendaGeneric);
        }

        public void Initialize()
        {
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleNames.ModuleVendaGeneric);
        }

        public string HeaderInfo
        {
            get { return "VendaGeneric"; }
        }
    }
}
