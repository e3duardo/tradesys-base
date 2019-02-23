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

namespace TradeSys.Modules.Financeiro.Domain
{
    public interface ITransacaoRepository
    {
        void Add(TransacaoModel transacao);

        void Update(TransacaoModel transacao);

        void Remove(TransacaoModel transacao);


        TransacaoModel GetById(long transacaoId);

        ICollection<TransacaoModel> GetByNome(string nome);

        ICollection<TransacaoModel> GetAll();
    }
}
