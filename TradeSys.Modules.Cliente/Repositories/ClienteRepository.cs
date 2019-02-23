using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TradeSys.Modules.Cliente.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace TradeSys.Modules.Cliente.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public void Add(Cliente cliente)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(cliente);
                transaction.Commit();
            }
        }

        public void Update(Cliente cliente)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(cliente);
                transaction.Commit();
            }
        }

        public void Remove(Cliente cliente)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(cliente);
                transaction.Commit();
            }
        }

        public Cliente GetById(long clienteId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Cliente>(clienteId);
        }

        public ICollection<Cliente> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var clientes = session
                    .CreateCriteria(typeof(Cliente))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<Cliente>();
                return clientes;
            }
        }
        

        public ICollection<Cliente> GetBySobrenome(string sobrenome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var clientes = session
                    .CreateCriteria(typeof(Cliente))
                    .Add(Restrictions.Eq("Sobrenome", sobrenome))
                    .List<Cliente>();
                return clientes;
            }
        }

        public ICollection<Cliente> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var clientes = session
                    .CreateCriteria(typeof(Cliente))
                    .List<Cliente>();
                return clientes;
            }
        }


        //para um resultado
        //public ICollection<Clientes> GetByNome(string nome)
        //{
        //    using (ISession session = NHibernateHelper.OpenSession())
        //    {
        //        Product product = session
        //            .CreateCriteria(typeof(Product))
        //            .Add(Restrictions.Eq("Name", name))
        //            .UniqueResult<Product>();
        //        return product;
        //    }
        //}
    }
}
