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
    public class CaixaRepository : ICaixaRepository
    {
        public void Add(CaixaModel caixa)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(caixa);
                transaction.Commit();
            }
        }

        public void Update(CaixaModel caixa)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(caixa);
                transaction.Commit();
            }
        }

        public void Remove(CaixaModel caixa)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(caixa);
                transaction.Commit();
            }
        }

        public CaixaModel GetById(long caixaId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<CaixaModel>(caixaId);
        }

        public ICollection<CaixaModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(CaixaModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<CaixaModel>();
                return products;
            }
        }



        public ICollection<CaixaModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(CaixaModel))
                    .List<CaixaModel>();
                return products;
            }
        }


    }
}
