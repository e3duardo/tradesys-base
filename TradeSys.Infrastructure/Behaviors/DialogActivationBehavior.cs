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

using System.Collections.Specialized;
using System.Windows;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Regions.Behaviors;

namespace TradeSys.Infrastructure.Behaviors
{
    public abstract class DialogActivationBehavior : RegionBehavior, IHostAwareRegionBehavior
    {
        public const string BehaviorKey = "DialogActivation";

        private IWindow contentDialog;

        public DependencyObject HostControl { get; set; }

        protected override void OnAttach()
        {
            this.Region.ActiveViews.CollectionChanged += this.ActiveViews_CollectionChanged;
        }

        protected abstract IWindow CreateWindow();

        private void ActiveViews_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                this.CloseContentDialog();
                this.PrepareContentDialog(e.NewItems[0]);
            }
            else if(e.Action == NotifyCollectionChangedAction.Remove)
            {
                this.CloseContentDialog();
            }
        }

        private Style GetStyleForView()
        {
            return this.HostControl.GetValue(RegionPopupBehaviors.ContainerWindowStyleProperty) as Style;
        }

        private void PrepareContentDialog(object view)
        {
            this.contentDialog = this.CreateWindow();
            this.contentDialog.Content = view;
            this.contentDialog.Owner = this.HostControl;
            this.contentDialog.Closed += this.ContentDialogClosed;
            this.contentDialog.Style = this.GetStyleForView();
            this.contentDialog.Show();
        }

        private void CloseContentDialog()
        {
            if (this.contentDialog != null)
            {
                this.contentDialog.Closed -= this.ContentDialogClosed;
                this.contentDialog.Close();
                this.contentDialog.Content = null;
                this.contentDialog.Owner = null;
            }
        }

        private void ContentDialogClosed(object sender, System.EventArgs e)
        {
            this.Region.Deactivate(this.contentDialog.Content);
            this.CloseContentDialog();
        }
    }
}
