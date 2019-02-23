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

using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Commands;

namespace TradeSys.Infrastructure
{
    public static class TradeSysCommands
    {
        private static CompositeCommand submitOrderCommand = new CompositeCommand(true);
        private static CompositeCommand cancelOrderCommand = new CompositeCommand(true);
        private static CompositeCommand submitAllOrdersCommand = new CompositeCommand();
        private static CompositeCommand cancelAllOrdersCommand = new CompositeCommand();

        public static CompositeCommand SubmitOrderCommand
        {
            get { return submitOrderCommand; }
            set { submitOrderCommand = value; }
        }
        public static CompositeCommand CancelOrderCommand
        {
            get { return cancelOrderCommand; }
            set { cancelOrderCommand = value; }
        }
        public static CompositeCommand SubmitAllOrdersCommand
        {
            get { return submitAllOrdersCommand; }
            set { submitAllOrdersCommand = value; }
        }
        public static CompositeCommand CancelAllOrdersCommand
        {
            get { return cancelAllOrdersCommand; }
            set { cancelAllOrdersCommand = value; }
        }
    }

    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class TradeSysCommandProxy
    {
        virtual public CompositeCommand SubmitOrderCommand
        {
            get { return TradeSysCommands.SubmitOrderCommand; }
        }
        virtual public CompositeCommand CancelOrderCommand
        {
            get { return TradeSysCommands.CancelOrderCommand; }
        }
        virtual public CompositeCommand SubmitAllOrdersCommand
        {
            get { return TradeSysCommands.SubmitAllOrdersCommand; }
        }
        virtual public CompositeCommand CancelAllOrdersCommand
        {
            get { return TradeSysCommands.CancelAllOrdersCommand; }
        }
    }
}
