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
using NHibernate;
using NHibernate.Criterion;
using TradeSys.Modules.Funcionario.Domain;

namespace TradeSys.Modules.Funcionario.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        public void Add(CargoModel cargo)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(cargo);
                transaction.Commit();
            }
        }

        public void Update(CargoModel cargo)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(cargo);
                transaction.Commit();
            }
        }

        public void Remove(CargoModel cargo)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(cargo);
                transaction.Commit();
            }
        }

        public CargoModel GetById(long cargoId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<CargoModel>(cargoId);
        }

        public ICollection<CargoModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(CargoModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<CargoModel>();
                return products;
            }
        }



        public ICollection<CargoModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(CargoModel))
                    .List<CargoModel>();
                return products;
            }
        }


    }
}
