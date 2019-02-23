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

namespace TradeSys.Infrastructure
{
    public static class TreeHelper
    {
        public static DependencyObject FindAncestor(DependencyObject dependencyObject, Func<DependencyObject,bool> predicate)
        {
            if (predicate(dependencyObject))
                return dependencyObject;

            DependencyObject parent = null;

            parent = LogicalTreeHelper.GetParent(dependencyObject);

            if (parent != null)
                return FindAncestor(parent, predicate);

            return null;

        }
    }
}
