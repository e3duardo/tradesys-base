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
    public class FormaPagamentoRepository : IFormaPagamentoRepository
    {
        public void Add(FormaPagamentoModel formaPagamento)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(formaPagamento);
                transaction.Commit();
            }
        }

        public void Update(FormaPagamentoModel formaPagamento)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(formaPagamento);
                transaction.Commit();
            }
        }

        public void Remove(FormaPagamentoModel formaPagamento)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(formaPagamento);
                transaction.Commit();
            }
        }

        public FormaPagamentoModel GetById(long formaPagamentoId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<FormaPagamentoModel>(formaPagamentoId);
        }

        public ICollection<FormaPagamentoModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(FormaPagamentoModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<FormaPagamentoModel>();
                return products;
            }
        }



        public ICollection<FormaPagamentoModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(FormaPagamentoModel))
                    .List<FormaPagamentoModel>();
                return products;
            }
        }


    }
}
