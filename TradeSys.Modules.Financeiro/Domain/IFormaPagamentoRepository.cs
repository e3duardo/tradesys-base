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
    public interface IFormaPagamentoRepository
    {
        void Add(FormaPagamentoModel formaPagamento);

        void Update(FormaPagamentoModel formaPagamento);

        void Remove(FormaPagamentoModel formaPagamento);


        FormaPagamentoModel GetById(long formaPagamentoId);

        ICollection<FormaPagamentoModel> GetByNome(string nome);

        ICollection<FormaPagamentoModel> GetAll();
    }
}
