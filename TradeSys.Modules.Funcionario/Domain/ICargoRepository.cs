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
    public interface ICargoRepository
    {
        void Add(CargoModel Cargo);

        void Update(CargoModel Cargo);

        void Remove(CargoModel Cargo);


        CargoModel GetById(long CargoId);

        ICollection<CargoModel> GetByNome(string nome);

        ICollection<CargoModel> GetAll();
    }
}
