using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TradeSys.Modules.Produto.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace TradeSys.Modules.Produto.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public void Add(ProdutoModel produto)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(produto);
                transaction.Commit();
            }
        }

        public void Update(ProdutoModel produto)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(produto);
                transaction.Commit();
            }
        }

        public void Remove(ProdutoModel produto)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(produto);
                transaction.Commit();
            }
        }

        public ProdutoModel GetById(long produtoId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<ProdutoModel>(produtoId);
        }

        public ICollection<ProdutoModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(ProdutoModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<ProdutoModel>();
                return products;
            }
        }



        public ICollection<ProdutoModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(ProdutoModel))
                    .List<ProdutoModel>();
                return products;
            }
        }


    }
}
