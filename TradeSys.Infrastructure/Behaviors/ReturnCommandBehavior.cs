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

using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace TradeSys.Infrastructure.Behaviors
{
    public class ReturnCommandBehavior : CommandBehaviorBase<TextBox>
    {
        public ReturnCommandBehavior(TextBox textBox)
            : base(textBox)
        {
            textBox.AcceptsReturn = false;
            textBox.KeyDown += (s, e) => this.KeyPressed(e.Key);
            textBox.GotFocus += (s, e) => this.GotFocus();
            textBox.LostFocus += (s, e) => this.LostFocus();
        }

        public string DefaultTextAfterCommandExecution { get; set; }

        protected void KeyPressed(Key key)
        {
            if (key == Key.Enter && TargetObject != null)
            {
                this.CommandParameter = TargetObject.Text;
                ExecuteCommand();

                this.ResetText();
            }
        }

        private void GotFocus()
        {
            if (TargetObject != null && TargetObject.Text == this.DefaultTextAfterCommandExecution)
            {
                this.ResetText();
            }
        }

        private void ResetText()
        {
            TargetObject.Text = string.Empty;
        }

        private void LostFocus()
        {
            if (TargetObject != null && string.IsNullOrEmpty(TargetObject.Text) && this.DefaultTextAfterCommandExecution != null)
            {
                TargetObject.Text = this.DefaultTextAfterCommandExecution;
            }
        }
    }
}
