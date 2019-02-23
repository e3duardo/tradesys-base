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
using TradeSys.Infrastructure.Models;
using System.Collections;

namespace TradeSys.Infrastructure.Interfaces
{
    public interface IModulesLoadedService
    {
        ICollection GetAllModulesLoaded();
    }
}
