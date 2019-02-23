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
    public class PermissaoItemRepository : IPermissaoItemRepository
    {
        public void Add(PermissaoItemModel permissaoItem)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(permissaoItem);
                transaction.Commit();
            }
        }

        public void Update(PermissaoItemModel permissaoItem)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(permissaoItem);
                transaction.Commit();
            }
        }

        public void Remove(PermissaoItemModel permissaoItem)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(permissaoItem);
                transaction.Commit();
            }
        }

        public PermissaoItemModel GetById(long permissaoItemId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<PermissaoItemModel>(permissaoItemId);
        }

        public ICollection<PermissaoItemModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(PermissaoItemModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<PermissaoItemModel>();
                return products;
            }
        }



        public ICollection<PermissaoItemModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(PermissaoItemModel))
                    .List<PermissaoItemModel>();
                return products;
            }
        }


    }
}
