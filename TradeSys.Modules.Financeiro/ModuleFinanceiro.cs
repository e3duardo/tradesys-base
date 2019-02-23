//===================================================================================
// Trade Management System
// Sistema de gerenciamento de comércio para lojas de pequeno á médio porte.
//===================================================================================
// Copyright (c) Eduardo Bastos dos Santos.  Todos direitos reservados.
// 
// CRIAÇÃO:         26/06/2011
// MODIFICAÇÔES: 
//===================================================================================
// Modulo para operações financeiras
//
// No sistema atual (não modular), compreende as seguintes classes:
//  -Caixa
//  -FormaPagamento
//  -Parcela
//  -Transacao
//  -TransacaoParcela
//
//
//===================================================================================

using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using TradeSys.ModulesTracking;

namespace TradeSys.Modules.Financeiro
{
    [ModuleExport(typeof(ModuleFinanceiro), DependsOnModuleNames = new string[] { "ModuleBase" })]
    public class ModuleFinanceiro : IModule
    {
        private readonly IModuleTracker moduleTracker;


        [ImportingConstructor]
        public ModuleFinanceiro(IModuleTracker moduleTracker)
        {
            if (moduleTracker == null)
            {
                throw new ArgumentNullException("moduleTracker");
            }

            this.moduleTracker = moduleTracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleNames.ModuleFinanceiro);
        }

        public void Initialize()
        {
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleNames.ModuleFinanceiro);
        }

        public string HeaderInfo
        {
            get { return "Financeiro"; }
        }
    }
}
