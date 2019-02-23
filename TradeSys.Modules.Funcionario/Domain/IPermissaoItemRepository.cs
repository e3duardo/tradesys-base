//===================================================================================
// Trade Management System
// Sistema de gerenciamento de comércio para lojas de pequeno á médio porte.
//===================================================================================
// Copyright (c) Eduardo Bastos dos Santos.  Todos direitos reservados.
// 
// CRIAÇÃO:         14/07/2011
// MODIFICAÇÔES: 
//===================================================================================
// <Resumo aqui>
//===================================================================================
using System.Collections.Generic;

namespace TradeSys.Modules.Funcionario.Domain
{
    public interface IPermissaoItemRepository
    {
        void Add(PermissaoItemModel setor);

        void Update(PermissaoItemModel setor);

        void Remove(PermissaoItemModel setor);


        PermissaoItemModel GetById(long setorId);

        ICollection<PermissaoItemModel> GetByNome(string nome);

        ICollection<PermissaoItemModel> GetAll();
    }
}
