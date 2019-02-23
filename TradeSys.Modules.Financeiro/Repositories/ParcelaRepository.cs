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
using TradeSys.Modules.Financeiro.Domain;

namespace TradeSys.Modules.Financeiro.Repositories
{
    public class FuncionarioRepository : IParcelaRepository
    {
        public void Add(ParcelaModel parcela)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(parcela);
                transaction.Commit();
            }
        }

        public void Update(ParcelaModel parcela)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(parcela);
                transaction.Commit();
            }
        }

        public void Remove(ParcelaModel parcela)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(parcela);
                transaction.Commit();
            }
        }

        public ParcelaModel GetById(long parcelaId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<ParcelaModel>(parcelaId);
        }

        public ICollection<ParcelaModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(ParcelaModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<ParcelaModel>();
                return products;
            }
        }



        public ICollection<ParcelaModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(ParcelaModel))
                    .List<ParcelaModel>();
                return products;
            }
        }


    }
}
