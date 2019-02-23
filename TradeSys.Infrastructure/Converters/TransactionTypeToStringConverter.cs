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
using System.Globalization;
using System.Windows.Data;

namespace TradeSys.Infrastructure.Converters
{
    public class TransactionTypeToStringConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {


            if (value == null || !(value is TransactionType))
                return null;

            TransactionType transactionType = (TransactionType)value;
            return (transactionType == TransactionType.Buy ?"BUY":"SELL") + " ";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }
}
