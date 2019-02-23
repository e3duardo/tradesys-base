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
using Microsoft.Practices.Prism.Regions;
using System.ComponentModel;
using Microsoft.Practices.ServiceLocation;

namespace TradeSys.Infrastructure.Behaviors
{
    public static class RegionPopupBehaviors
    {

        public static readonly DependencyProperty CreatePopupRegionWithNameProperty = DependencyProperty.RegisterAttached("CreatePopupRegionWithName", typeof(string), typeof(RegionPopupBehaviors), new PropertyMetadata(CreatePopupRegionWithNamePropertyChanged));

        public static readonly DependencyProperty ContainerWindowStyleProperty = DependencyProperty.RegisterAttached("ContainerWindowStyle", typeof(Style), typeof(RegionPopupBehaviors), null);


        public static string GetCreatePopupRegionWithName(DependencyObject owner)
        {
            return owner.GetValue(CreatePopupRegionWithNameProperty) as string;
        }

        public static void SetCreatePopupRegionWithName(DependencyObject owner, string value)
        {
            owner.SetValue(CreatePopupRegionWithNameProperty, value);
        }


        public static Style GetContainerWindowStyle(DependencyObject owner)
        {
            return owner.GetValue(ContainerWindowStyleProperty) as Style;
        }

        public static void SetContainerWindowStyle(DependencyObject owner, Style style)
        {
            owner.SetValue(ContainerWindowStyleProperty, style);
        }

        public static void RegisterNewPopupRegion(DependencyObject owner, string regionName)
        {
            IRegionManager regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            if (regionManager != null)
            {
                IRegion region = new SingleActiveRegion();
                DialogActivationBehavior behavior;

#if SILVERLIGHT
                behavior = new PopupDialogActivarionBehavior();
#else
                behavior = new WindowDialogActivationBehavior();
#endif
                behavior.HostControl = owner;

                region.Behaviors.Add(DialogActivationBehavior.BehaviorKey, behavior);
                regionManager.Regions.Add(regionName, region);
            }
        }

        private static void CreatePopupRegionWithNamePropertyChanged(DependencyObject hostControl, DependencyPropertyChangedEventArgs e)
        {
            if(IsInDesignMode(hostControl))
            {
                return;
            }

            RegisterNewPopupRegion(hostControl, e.NewValue as string);
        }

        private static bool IsInDesignMode(DependencyObject element)
        {
            return DesignerProperties.GetIsInDesignMode(element) || Application.Current == null || Application.Current.GetType() == typeof(Application);
        }
    }
}
