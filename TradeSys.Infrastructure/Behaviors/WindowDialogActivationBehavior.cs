﻿//===================================================================================
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


namespace TradeSys.Infrastructure.Behaviors
{
    public class WindowDialogActivationBehavior : DialogActivationBehavior
    {
        protected override IWindow CreateWindow()
        {
            return new WindowWrapper();
        }
    }
}
