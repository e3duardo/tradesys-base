using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using TradeSys.ModulesTracking;
using System.Collections;

namespace TradeSys.Infrastructure
{
    [Export(typeof(IModuleTracker))]
    public class ModuleTracker : IModuleTracker
    {
        private readonly ModuleTrackingState moduleBaseTrackingState;
        private readonly ModuleTrackingState moduleClienteTrackingState;
        private readonly ModuleTrackingState moduleFinanceiroTrackingState;
        private readonly ModuleTrackingState moduleFuncionarioTrackingState;
        private readonly ModuleTrackingState moduleProdutoTrackingState;
        private readonly ModuleTrackingState moduleVendaGenericTrackingState;

        [Import]
        private ILoggerFacade logger;

        public ModuleTracker()
        {
            this.moduleBaseTrackingState = new ModuleTrackingState
            {
                ModuleName = WellKnownModuleNames.ModuleBase,
                ExpectedDiscoveryMethod = DiscoveryMethod.ApplicationReference,
                ExpectedInitializationMode = InitializationMode.WhenAvailable,
                ExpectedDownloadTiming = DownloadTiming.WithApplication,
                //ConfiguredDependencies = WellKnownModuleNames.ModuleD,
            };
            this.moduleClienteTrackingState = new ModuleTrackingState
            {
                ModuleName = WellKnownModuleNames.ModuleCliente,
                ExpectedDiscoveryMethod = DiscoveryMethod.DirectorySweep,
                ExpectedInitializationMode = InitializationMode.OnDemand,
                ExpectedDownloadTiming = DownloadTiming.InBackground,
            };
            this.moduleFinanceiroTrackingState = new ModuleTrackingState
            {
                ModuleName = WellKnownModuleNames.ModuleFinanceiro,
                ExpectedDiscoveryMethod = DiscoveryMethod.ApplicationReference,
                ExpectedInitializationMode = InitializationMode.OnDemand,
                ExpectedDownloadTiming = DownloadTiming.WithApplication,
            };
            this.moduleFuncionarioTrackingState = new ModuleTrackingState
            {
                ModuleName = WellKnownModuleNames.ModuleFuncionario,
                ExpectedDiscoveryMethod = DiscoveryMethod.DirectorySweep,
                ExpectedInitializationMode = InitializationMode.WhenAvailable,
                ExpectedDownloadTiming = DownloadTiming.InBackground,
            };
            this.moduleProdutoTrackingState = new ModuleTrackingState
            {
                ModuleName = WellKnownModuleNames.ModuleProduto,
                ExpectedDiscoveryMethod = DiscoveryMethod.ConfigurationManifest,
                ExpectedInitializationMode = InitializationMode.OnDemand,
                ExpectedDownloadTiming = DownloadTiming.InBackground,
            };
            this.moduleVendaGenericTrackingState = new ModuleTrackingState
            {
                ModuleName = WellKnownModuleNames.ModuleVendaGeneric,
                ExpectedDiscoveryMethod = DiscoveryMethod.ConfigurationManifest,
                ExpectedInitializationMode = InitializationMode.OnDemand,
                ExpectedDownloadTiming = DownloadTiming.InBackground,
                //ConfiguredDependencies = WellKnownModuleNames.Produto, 
            };
        }

        public ModuleTrackingState ModuleBaseTrackingState
        {
            get { return this.moduleBaseTrackingState; }
        }
        public ModuleTrackingState ModuleClienteTrackingState
        {
            get { return this.moduleClienteTrackingState; }
        }
        public ModuleTrackingState ModuleFinanceiroTrackingState
        {
            get { return this.moduleFinanceiroTrackingState; }
        }
        public ModuleTrackingState ModuleFuncionarioTrackingState
        {
            get { return this.moduleFuncionarioTrackingState; }
        }
        public ModuleTrackingState ModuleProdutoTrackingState
        {
            get { return this.moduleProdutoTrackingState; }
        }
        public ModuleTrackingState ModuleVendaGenericTrackingState
        {
            get { return this.moduleVendaGenericTrackingState; }
        }


        public void RecordModuleDownloading(string moduleName, long bytesReceived, long totalBytesToReceive)
        {
            ModuleTrackingState moduleTrackingState = this.GetModuleTrackingState(moduleName);
            if (moduleTrackingState != null)
            {
                moduleTrackingState.BytesReceived = bytesReceived;
                moduleTrackingState.TotalBytesToReceive = totalBytesToReceive;

                if (bytesReceived < totalBytesToReceive)
                {
                    moduleTrackingState.ModuleInitializationStatus = ModuleInitializationStatus.Downloading;
                }
                else
                {
                    moduleTrackingState.ModuleInitializationStatus = ModuleInitializationStatus.Downloaded;
                }
            }

            this.logger.Log(
                string.Format("'{0}' module is loading {1}/{2} bytes.", moduleName, bytesReceived, totalBytesToReceive),
                Category.Debug,
                Priority.Low);
        }

        public void RecordModuleConstructed(string moduleName)
        {
            ModuleTrackingState moduleTrackingState = this.GetModuleTrackingState(moduleName);
            if (moduleTrackingState != null)
            {
                moduleTrackingState.ModuleInitializationStatus = ModuleInitializationStatus.Constructed;
            }

            this.logger.Log(string.Format("'{0}' module constructed.", moduleName), Category.Debug, Priority.Low);
        }

        public void RecordModuleInitialized(string moduleName)
        {
            ModuleTrackingState moduleTrackingState = this.GetModuleTrackingState(moduleName);
            if (moduleTrackingState != null)
            {
                moduleTrackingState.ModuleInitializationStatus = ModuleInitializationStatus.Initialized;
            }

            this.logger.Log(string.Format("{0} module initialized.", moduleName), Category.Debug, Priority.Low);
        }

        public void RecordModuleLoaded(string moduleName)
        {
            this.logger.Log(string.Format("'{0}' module loaded.", moduleName), Category.Debug, Priority.Low);
        }


        // A helper to make updating specific property instances by name easier.
        private ModuleTrackingState GetModuleTrackingState(string moduleName)
        {
            switch (moduleName)
            {
                case WellKnownModuleNames.ModuleBase:
                    return this.ModuleBaseTrackingState;
                case WellKnownModuleNames.ModuleCliente:
                    return this.ModuleClienteTrackingState;
                case WellKnownModuleNames.ModuleFinanceiro:
                    return this.ModuleFinanceiroTrackingState;
                case WellKnownModuleNames.ModuleFuncionario:
                    return this.ModuleFuncionarioTrackingState;
                case WellKnownModuleNames.ModuleProduto:
                    return this.ModuleProdutoTrackingState;
                case WellKnownModuleNames.ModuleVendaGeneric:
                    return this.ModuleVendaGenericTrackingState;
                default:
                    return null;
            }
        }

        
    }
}
