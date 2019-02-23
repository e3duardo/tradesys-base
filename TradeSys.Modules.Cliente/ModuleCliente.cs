//===================================================================================
// Trade Management System
// Sistema de gerenciamento de comércio para lojas de pequeno á médio porte.
//===================================================================================
// Copyright (c) Eduardo Bastos dos Santos.  Todos direitos reservados.
// 
// CRIAÇÃO:         26/06/2011
// MODIFICAÇÔES: 
//===================================================================================
// Modulo para gerenciamento de clientes
//
// No sistema atual (não modular), compreende as seguintes classes:
//  -Cliente
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

namespace TradeSys.Modules.Cliente
{
    [ModuleExport(typeof(ModuleCliente), DependsOnModuleNames = new string[] { "ModuleBase" })]
    public class ModuleCliente : IModule
    {
        private readonly IModuleTracker moduleTracker;


        [ImportingConstructor]
        public ModuleCliente(IModuleTracker moduleTracker)
        {
            if (moduleTracker == null)
            {
                throw new ArgumentNullException("moduleTracker");
            }

            this.moduleTracker = moduleTracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleNames.ModuleCliente);
        }

        public void Initialize()
        {
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleNames.ModuleCliente);
        }

        public string HeaderInfo
        {
            get { return "Cliente"; }
        }

    }
}
