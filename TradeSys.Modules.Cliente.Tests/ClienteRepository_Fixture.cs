using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NHibernate.Tool.hbm2ddl;
using NHibernate;
using NHibernate.Cfg;
using TradeSys.Modules.Cliente.Repositories;
using TradeSys.Modules.Cliente.Domain;

namespace TradeSys.Modules.Cliente.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class ClienteRepository_Fixture
    {

        private ISessionFactory _sessionFactory;

        private Configuration _configuration;

        private readonly Cliente[] _clientes = new[]
                 {
                     new Cliente { Nome = "José", Sobrenome = "dos Santos", Email = "frioarts@hotmail.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new Cliente { Nome = "Laíse", Sobrenome = "Silva", Email = "laisebastos@hotmail.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new Cliente { Nome = "Wanessa", Sobrenome = "Bastos dos Santos", Email = "nessinha-bastos@hotmail.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new Cliente { Nome = "Vinícius", Sobrenome = "Bastos dos Santos", Email = "vini_guitar@hotmail.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new Cliente { Nome = "Jaqueline", Sobrenome = "Ferreira", Email = "jsbferreira@hotmail.com.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today }
                 };


        public void CreateInitialData()
        {
            using (ISession session = _sessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                foreach (var cliente in _clientes)
                    session.Save(cliente);

                transaction.Commit();
            }
        }


        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _configuration = new Configuration();
            _configuration.Configure();
            _configuration.AddAssembly(typeof(Cliente).Assembly);
            _sessionFactory = _configuration.BuildSessionFactory();

        }

        [SetUp]
        public void SetupContext()
        {
            new SchemaExport(_configuration).Execute(false, true, false);

            CreateInitialData();
        }

        [Test]
        public void Can_add_new_cliente()
        {
            var cliente = new Cliente { Nome = "Eduardo", Sobrenome = "Santos", Email = "e3duardo@facebook.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today };
            IClienteRepository repository = new ClienteRepository();
            repository.Add(cliente);

            // use session to try to load the product

            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<Cliente>(cliente.Id);
                // Test that the product was successfully inserted
                Assert.IsNotNull(fromDb);
                Assert.AreNotSame(cliente, fromDb);
                Assert.AreEqual(cliente.Nome, fromDb.Nome);
                Assert.AreEqual(cliente.Sobrenome, fromDb.Sobrenome);
            }
        }

        [Test]
        public void Can_update_existing_cliente()
        {
            var cliente = _clientes[0];
            cliente.Nome = "Yellow Pear";
            IClienteRepository repository = new ClienteRepository();
            repository.Update(cliente);

            // use session to try to load the product
            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<Cliente>(cliente.Id);
                Assert.AreEqual(cliente.Nome, fromDb.Nome);
            }
        }

        [Test]
        public void Can_remove_existing_cliente()
        {
            var product = _clientes[0];
            IClienteRepository repository = new ClienteRepository();
            repository.Remove(product);

            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<Cliente>(product.Id);
                Assert.IsNull(fromDb);
            }
        }

        [Test]
        public void Can_get_existing_cliente_by_id()
        {
            IClienteRepository repository = new ClienteRepository();
            var fromDb = repository.GetById(_clientes[1].Id);
            Assert.IsNotNull(fromDb);
            Assert.AreNotSame(_clientes[1], fromDb);
            Assert.AreEqual(_clientes[1].Nome, fromDb.Nome);
        }
        
        [Test]
        public void Can_get_existing_clientes_by_nome()
        {
            IClienteRepository repository = new ClienteRepository();
            var fromDb = repository.GetByNome("Jaqueline");

            Assert.AreEqual(1, fromDb.Count);
            Assert.IsTrue(IsInCollection(_clientes[4], fromDb));
        }

        [Test]
        public void Can_get_existing_clientes_by_sobrenome()
        {
            IClienteRepository repository = new ClienteRepository();
            var fromDb = repository.GetBySobrenome("Silva");

            Assert.AreEqual(1, fromDb.Count);
            Assert.IsTrue(IsInCollection(_clientes[1], fromDb));
        }

        [Test]
        public void Can_get_existing_clientes()
        {
            IClienteRepository repository = new ClienteRepository();
            var fromDb = repository.GetAll();

        }

        private bool IsInCollection(Cliente cliente, ICollection<Cliente> fromDb)
        {
            foreach (var item in fromDb)
                if (cliente.Id == item.Id)
                    return true;
            return false;
        }



        //para um resultado
        //[Test]
        //public void Can_get_existing_product_by_name()
        //{
        //    IClientesRepository repository = new ClientesRepository();
        //    var fromDb = repository.GetByNome(_clientes[1].Nome);
        //
        //    Assert.IsNotNull(fromDb);
        //    Assert.AreNotSame(_clientes[1], fromDb);
        //    Assert.AreEqual(_clientes[1].Id, fromDb.Id);
        //}

    }
}
