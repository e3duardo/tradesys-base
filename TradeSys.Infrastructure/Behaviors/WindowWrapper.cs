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
    public class WindowWrapper : IWindow
    {
        private readonly Window window;

        public WindowWrapper()
        {
            this.window = new Window();
        }

        public event EventHandler Closed
        {
            add { this.window.Closed += value; }
            remove { this.window.Closed -= value; }
        }

        public object Content
        {
            get { return this.window.Content; }
            set { this.window.Content = value; }
        }

        public object Owner
        {
            get { return this.window.Owner; }
            set { this.window.Owner = value as Window; }
        }

        public Style Style
        {
            get { return this.window.Style; }
            set { this.window.Style = value; }
        }

        public void Show()
        {
            this.window.Show();
        }

        public void Close()
        {
            this.window.Close();
        }
    }
}
