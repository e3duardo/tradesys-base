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
    public interface IPermissaoRepository
    {
        void Add(PermissaoModel setor);

        void Update(PermissaoModel setor);

        void Remove(PermissaoModel setor);


        PermissaoModel GetById(long setorId);

        ICollection<PermissaoModel> GetByNome(string nome);

        ICollection<PermissaoModel> GetAll();
    }
}
