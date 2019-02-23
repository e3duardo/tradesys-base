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

using TradeSys.Infrastructure.Models;

namespace TradeSys.Infrastructure.Interfaces
{
    public interface IMarketHistoryService
    {
        MarketHistoryCollection GetPriceHistory(string tickerSymbol);
    }
}
