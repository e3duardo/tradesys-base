using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TradeSys.Modules.Produto.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace TradeSys.Modules.Produto.Repositories
{
    public class SetorRepository : ISetorRepository
    {
        public void Add(SetorModel setor)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(setor);
                transaction.Commit();
            }
        }

        public void Update(SetorModel setor)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(setor);
                transaction.Commit();
            }
        }

        public void Remove(SetorModel setor)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(setor);
                transaction.Commit();
            }
        }

        public SetorModel GetById(long setorId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<SetorModel>(setorId);
        }

        public ICollection<SetorModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(SetorModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<SetorModel>();
                return products;
            }
        }



        public ICollection<SetorModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(SetorModel))
                    .List<SetorModel>();
                return products;
            }
        }


    }
}
