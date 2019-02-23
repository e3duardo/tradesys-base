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
    public class TransacaoRepository : ITransacaoRepository
    {
        public void Add(TransacaoModel transacao)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(transacao);
                transaction.Commit();
            }
        }

        public void Update(TransacaoModel transacao)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(transacao);
                transaction.Commit();
            }
        }

        public void Remove(TransacaoModel transacao)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(transacao);
                transaction.Commit();
            }
        }

        public TransacaoModel GetById(long transacaoId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<TransacaoModel>(transacaoId);
        }

        public ICollection<TransacaoModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(TransacaoModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<TransacaoModel>();
                return products;
            }
        }



        public ICollection<TransacaoModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(TransacaoModel))
                    .List<TransacaoModel>();
                return products;
            }
        }


    }
}
