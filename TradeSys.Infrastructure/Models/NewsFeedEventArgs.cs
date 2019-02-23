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

namespace TradeSys.Infrastructure.Models
{
    public class NewsFeedEventArgs : EventArgs
    {
        public NewsFeedEventArgs(string tickerSymbol, string newsHeadline)
        {
            TickerSymbol = tickerSymbol;
            NewsHeadline = newsHeadline;
        }

        public string TickerSymbol { get; set; }
        public string NewsHeadline { get; set; }
    }
}
