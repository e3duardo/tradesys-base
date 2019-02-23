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
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TradeSys.Infrastructure.Models
{
    public class MarketHistoryCollection : ObservableCollection<MarketHistoryItem>
    {
        public MarketHistoryCollection()
        {
        }

        public MarketHistoryCollection(IEnumerable<MarketHistoryItem> list)
        {
            foreach (MarketHistoryItem marketHistoryItem in list)
            {
                this.Add(marketHistoryItem);
            }
        }
    }

    public class MarketHistoryItem
    {
        public DateTime DateTimeMarker { get; set; }

        public decimal Value { get; set; }
    }
}