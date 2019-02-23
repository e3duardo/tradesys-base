using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using TradeSys.Modules.VendaGeneric.Domain;

namespace TradeSys.Modules.VendaGeneric.Repositories
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly("TradeSys.Modules.Cliente");
                    configuration.AddAssembly("TradeSys.Modules.Financeiro");
                    configuration.AddAssembly("TradeSys.Modules.Funcionario");
                    configuration.AddAssembly("TradeSys.Modules.Produto");

                    configuration.AddAssembly("TradeSys.Modules.VendaGeneric");

                    _sessionFactory = configuration.BuildSessionFactory();
                }

                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
