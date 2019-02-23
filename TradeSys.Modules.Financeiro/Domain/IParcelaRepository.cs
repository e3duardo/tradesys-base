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
    public interface IParcelaRepository
    {
        void Add(ParcelaModel parcela);

        void Update(ParcelaModel parcela);

        void Remove(ParcelaModel parcela);


        ParcelaModel GetById(long parcelaId);

        ICollection<ParcelaModel> GetByNome(string nome);

        ICollection<ParcelaModel> GetAll();
    }
}
