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
using System.Globalization;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Data;

namespace TradeSys.Infrastructure.Converters
{
    public class ErrorConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IList<ValidationError> errors = value as IList<ValidationError>;

            if (errors == null || errors.Count == 0)
                return string.Empty;

            Exception exception = errors[0].Exception;
            if (exception != null)
            {
                if (exception is TargetInvocationException)
                {
                    exception = exception.InnerException;
                }

                return exception.Message;
            }

            return errors[0].ErrorContent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }
}
