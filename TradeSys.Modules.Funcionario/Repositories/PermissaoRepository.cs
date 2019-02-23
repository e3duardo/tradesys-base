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
    public class PermissaoRepository : IPermissaoRepository
    {
        public void Add(PermissaoModel permissao)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(permissao);
                transaction.Commit();
            }
        }

        public void Update(PermissaoModel permissao)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(permissao);
                transaction.Commit();
            }
        }

        public void Remove(PermissaoModel permissao)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(permissao);
                transaction.Commit();
            }
        }

        public PermissaoModel GetById(long permissaoId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<PermissaoModel>(permissaoId);
        }

        public ICollection<PermissaoModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(PermissaoModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<PermissaoModel>();
                return products;
            }
        }



        public ICollection<PermissaoModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(PermissaoModel))
                    .List<PermissaoModel>();
                return products;
            }
        }


    }
}
