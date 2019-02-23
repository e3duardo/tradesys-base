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
    public interface ICaixaRepository
    {
        void Add(CaixaModel caixa);

        void Update(CaixaModel caixa);

        void Remove(CaixaModel caixa);


        CaixaModel GetById(long caixaId);

        ICollection<CaixaModel> GetByNome(string nome);

        ICollection<CaixaModel> GetAll();
    }
}
