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
    public class FuncionarioRepository : IFuncionarioRepository
    {
        public void Add(FuncionarioModel funcionario)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(funcionario);
                transaction.Commit();
            }
        }

        public void Update(FuncionarioModel funcionario)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(funcionario);
                transaction.Commit();
            }
        }

        public void Remove(FuncionarioModel funcionario)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(funcionario);
                transaction.Commit();
            }
        }

        public FuncionarioModel GetById(long funcionarioId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<FuncionarioModel>(funcionarioId);
        }

        public ICollection<FuncionarioModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(FuncionarioModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<FuncionarioModel>();
                return products;
            }
        }



        public ICollection<FuncionarioModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(FuncionarioModel))
                    .List<FuncionarioModel>();
                return products;
            }
        }


    }
}
