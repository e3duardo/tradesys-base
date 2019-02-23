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

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TradeSys.Infrastructure.Behaviors;

namespace TradeSys.Infrastructure
{
    public static class ReturnKey
    {
        public static readonly DependencyProperty CommandProperty = DependencyProperty.RegisterAttached("Command", typeof(ICommand), typeof(ReturnKey), new PropertyMetadata(OnSetCommandCallback));

        public static readonly DependencyProperty DefaultTextAfterCommandExecutionProperty = DependencyProperty.RegisterAttached("DetaultTextAfterCommandExecution", typeof(string), typeof(ReturnKey), new PropertyMetadata(OnSetDefaultTextAfterCommandExecutionCallback));

        public static readonly DependencyProperty ReturnCommandBehaviorProperty = DependencyProperty.RegisterAttached("ReturnCommandBehavior", typeof(ReturnCommandBehavior), typeof(ReturnKey), null);


        public static void SetDefaultTextAfterCommandExecution(TextBox textBox, string defaultText)
        {
            textBox.SetValue(DefaultTextAfterCommandExecutionProperty, defaultText);
        }

        public static string GetDefaultTextAfterCommandExecution(TextBox textBox)
        {
            return textBox.GetValue(DefaultTextAfterCommandExecutionProperty) as string;
        }


        public static void SetCommand(TextBox textBox, ICommand command)
        {
            textBox.SetValue(CommandProperty, command);
        }

        public static ICommand GetCommand(TextBox textBox)
        {
            return textBox.GetValue(CommandProperty) as ICommand;
        }

        private static void OnSetDefaultTextAfterCommandExecutionCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            TextBox textBox = dependencyObject as TextBox;
            if (textBox != null)
            {
                ReturnCommandBehavior behavior = GetOrCreateBehavior(textBox);
                behavior.DefaultTextAfterCommandExecution = e.NewValue as string;
            }
        }

        private static void OnSetCommandCallback(DependencyObject dependencyObject,DependencyPropertyChangedEventArgs e)
        {
            TextBox textBox = dependencyObject as TextBox;
            if (textBox != null)
            {
                ReturnCommandBehavior behavior = GetOrCreateBehavior(textBox);
                behavior.Command = e.NewValue as ICommand;
            }
        }

        private static ReturnCommandBehavior GetOrCreateBehavior(TextBox textBox)
        {
            ReturnCommandBehavior behavior = textBox.GetValue(ReturnCommandBehaviorProperty) as ReturnCommandBehavior;
            if (behavior == null)
            {
                behavior = new ReturnCommandBehavior(textBox);
                textBox.SetValue(ReturnCommandBehaviorProperty, behavior);
            }
            return behavior;
        }

    }
}
