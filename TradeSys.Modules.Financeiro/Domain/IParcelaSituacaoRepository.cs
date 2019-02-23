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
    public interface IParcelaSituacaoRepository
    {
        void Add(ParcelaSituacaoModel parcelaSituacao);

        void Update(ParcelaSituacaoModel parcelaSituacao);

        void Remove(ParcelaSituacaoModel parcelaSituacao);


        ParcelaSituacaoModel GetById(long parcelaSituacaoId);

        ICollection<ParcelaSituacaoModel> GetByNome(string nome);

        ICollection<ParcelaSituacaoModel> GetAll();
    }
}
