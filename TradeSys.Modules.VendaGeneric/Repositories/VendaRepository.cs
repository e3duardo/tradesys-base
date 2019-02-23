using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TradeSys.Modules.VendaGeneric.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace TradeSys.Modules.VendaGeneric.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        public void Add(VendaModel venda)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(venda);
                transaction.Commit();
            }
        }

        public void Update(VendaModel venda)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(venda);
                transaction.Commit();
            }
        }

        public void Remove(VendaModel venda)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(venda);
                transaction.Commit();
            }
        }

        public VendaModel GetById(long vendaId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<VendaModel>(vendaId);
        }

        public ICollection<VendaModel> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(VendaModel))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<VendaModel>();
                return products;
            }
        }



        public ICollection<VendaModel> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(VendaModel))
                    .List<VendaModel>();
                return products;
            }
        }


    }
}
