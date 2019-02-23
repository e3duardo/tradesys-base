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

namespace TradeSys.Modules.Produto
{
    [ModuleExport(typeof(ModuleProduto), DependsOnModuleNames = new string[] { "ModuleBase" })]
    public class ModuleProduto : IModule
    {
        private readonly IModuleTracker moduleTracker;


        [ImportingConstructor]
        public ModuleProduto(IModuleTracker moduleTracker)
        {
            if (moduleTracker == null)
            {
                throw new ArgumentNullException("moduleTracker");
            }

            this.moduleTracker = moduleTracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleNames.ModuleProduto);
        }

        public void Initialize()
        {
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleNames.ModuleProduto);
        }

        public string HeaderInfo
        {
            get { return "Produto"; }
        }
    }
}
