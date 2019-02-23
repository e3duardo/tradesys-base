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
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using Fluent;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace TradeSys
{
    [Export]
    public class ShellViewModel : NotificationObject
    {
        public ShellViewModel()
        {
            this.ClienteCommand = new DelegateCommand<object>(this.Cliente);  
        }

        public DelegateCommand<object> ClienteCommand { get; private set; }

        public void Cliente(object parameter)
        {
            TradeSys.Modules.Base.WindowShell shell = new TradeSys.Modules.Base.WindowShell();
            shell.Show();
        }
    
    }
}
