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
using System.Windows;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace TradeSys
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

#if (DEBUG)
            RunInDebugMode();
#else
            RunInReleaseMode();
#endif
            this.ShutdownMode = ShutdownMode.OnMainWindowClose;

        }

        private static void RunInDebugMode()
        {
            Console.WriteLine("Running in Debug Mode");

            TradeSysBootstrapper bootstraper = new TradeSysBootstrapper();
            bootstraper.Run();
        }

        private static void RunInReleaseMode()
        {
            Console.WriteLine("Running in Release Mode");

            AppDomain.CurrentDomain.UnhandledException += AppDomainUnloadedException;
            try
            {
                TradeSysBootstrapper bootstraper = new TradeSysBootstrapper();
                bootstraper.Run();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private static void AppDomainUnloadedException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }

        private static void HandleException(Exception ex)
        {
            if (ex == null)
                return;

            ExceptionPolicy.HandleException(ex, "Default Policy");
            MessageBox.Show(TradeSys.Properties.Resources.UnhandledException);
            Environment.Exit(1);
        }
    }
}
