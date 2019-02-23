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
    public interface IFuncionarioRepository
    {
        void Add(FuncionarioModel setor);

        void Update(FuncionarioModel setor);

        void Remove(FuncionarioModel setor);


        FuncionarioModel GetById(long setorId);

        ICollection<FuncionarioModel> GetByNome(string nome);

        ICollection<FuncionarioModel> GetAll();
    }
}
