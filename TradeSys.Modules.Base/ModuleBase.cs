//===================================================================================
// Trade Management System
// Sistema de gerenciamento de comércio para lojas de pequeno á médio porte.
//===================================================================================
// Copyright (c) Eduardo Bastos dos Santos.  Todos direitos reservados.
// 
// CRIAÇÃO:         15/07/2011
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
using Microsoft.Practices.Prism.Logging;

namespace TradeSys.Modules.Base
{
    [ModuleExport(typeof(ModuleBase))]
    public class ModuleBase : IModule
    {
        private readonly ILoggerFacade logger;
        private readonly IModuleTracker moduleTracker;


        [ImportingConstructor]
        public ModuleBase(ILoggerFacade logger, IModuleTracker moduleTracker)
        {
            if (logger == null)
            {
                throw new ArgumentNullException("logger");
            }

            if (moduleTracker == null)
            {
                throw new ArgumentNullException("moduleTracker");
            }

            this.logger = logger;
            this.moduleTracker = moduleTracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleNames.ModuleBase);
        }

        public void Initialize()
        {
            this.logger.Log("ModuleA demonstrates logging during Initialize().", Category.Info, Priority.Medium);
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleNames.ModuleBase);
        }

        public string HeaderInfo
        {
            get { return "Base"; }
        }
    }
}
