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

namespace TradeSys.Infrastructure.Behaviors
{
    public interface IWindow
    {
        event EventHandler Closed;

        object Content { get; set; }

        object Owner { get; set; }

        Style Style { get; set; }

        void Show();

        void Close();
    }
}
