using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TradeSys.Modules.Produto.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace TradeSys.Modules.Produto.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public void Add(FornecedorModel fornecedor)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(fornecedor);
                transaction.Commit();
            }
        }

        public void Update(FornecedorModel fornecedor)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(fornecedor);
                transaction.Commit();
            }
        }

        public void Remove(FornecedorModel fornecedor)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(fornecedor);
                transaction.Commit();
            }
        }

        public FornecedorModel GetById(long fornecedorId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<FornecedorModel>(fornecedorId);
        }

        public ICollection<FornecedorModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(FornecedorModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<FornecedorModel>();
                return products;
            }
        }



        public ICollection<FornecedorModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(FornecedorModel))
                    .List<FornecedorModel>();
                return products;
            }
        }


    }
}
