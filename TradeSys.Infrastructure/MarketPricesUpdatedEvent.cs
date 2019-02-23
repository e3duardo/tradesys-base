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

using System.Collections.Generic;
using Microsoft.Practices.Prism.Events;

namespace TradeSys.Infrastructure
{
    public class MarketPricesUpdatedEvent : CompositePresentationEvent<IDictionary<string, decimal>>
    {
    }
}
