using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NHibernate.Tool.hbm2ddl;
using NHibernate;
using NHibernate.Cfg;
using TradeSys.Modules.Produto.Repositories;
using TradeSys.Modules.Produto.Domain;

namespace TradeSys.Modules.Produto.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class ProdutoRepository_Fixture
    {

        private ISessionFactory _sessionFactory;

        private Configuration _configuration;

        private readonly ProdutoModel[] _Produtos = new[]
                 {
                     new ProdutoModel { Nome = "José", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new ProdutoModel { Nome = "Laíse", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new ProdutoModel { Nome = "Wanessa", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new ProdutoModel { Nome = "Vinícius", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new ProdutoModel { Nome = "Jaqueline", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today }
                 };


        public void CreateInitialData()
        {
            using (ISession session = _sessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                foreach (var Produto in _Produtos)
                    session.Save(Produto);

                transaction.Commit();
            }
        }


        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _configuration = new Configuration();
            _configuration.Configure();
            _configuration.AddAssembly(typeof(ProdutoModel).Assembly);
            _sessionFactory = _configuration.BuildSessionFactory();

        }

        [SetUp]
        public void SetupContext()
        {
            new SchemaExport(_configuration).Execute(false, true, false);

            CreateInitialData();
        }

        [Test]
        public void Can_add_new_Produto()
        {
            var Produto = new ProdutoModel { Nome = "Eduardo", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today };
            IProdutoRepository repository = new ProdutoRepository();
            repository.Add(Produto);

            // use session to try to load the product

            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<ProdutoModel>(Produto.Id);
                // Test that the product was successfully inserted
                Assert.IsNotNull(fromDb);
                Assert.AreNotSame(Produto, fromDb);
                Assert.AreEqual(Produto.Nome, fromDb.Nome);
            }
        }

        [Test]
        public void Can_update_existing_Produto()
        {
            var Produto = _Produtos[0];
            Produto.Nome = "Yellow Pear";
            IProdutoRepository repository = new ProdutoRepository();
            repository.Update(Produto);

            // use session to try to load the product
            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<ProdutoModel>(Produto.Id);
                Assert.AreEqual(Produto.Nome, fromDb.Nome);
            }
        }

        [Test]
        public void Can_remove_existing_Produto()
        {
            var product = _Produtos[0];
            IProdutoRepository repository = new ProdutoRepository();
            repository.Remove(product);

            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<ProdutoModel>(product.Id);
                Assert.IsNull(fromDb);
            }
        }

        [Test]
        public void Can_get_existing_Produto_by_id()
        {
            IProdutoRepository repository = new ProdutoRepository();
            var fromDb = repository.GetById(_Produtos[1].Id);
            Assert.IsNotNull(fromDb);
            Assert.AreNotSame(_Produtos[1], fromDb);
            Assert.AreEqual(_Produtos[1].Nome, fromDb.Nome);
        }
        
        [Test]
        public void Can_get_existing_Produtos_by_nome()
        {
            IProdutoRepository repository = new ProdutoRepository();
            var fromDb = repository.GetByNome("Jaqueline");

            Assert.AreEqual(1, fromDb.Count);
            Assert.IsTrue(IsInCollection(_Produtos[4], fromDb));
        }

        [Test]
        public void Can_get_existing_Produtos()
        {
            IProdutoRepository repository = new ProdutoRepository();
            var fromDb = repository.GetAll();

        }

        private bool IsInCollection(ProdutoModel Produto, ICollection<ProdutoModel> fromDb)
        {
            foreach (var item in fromDb)
                if (Produto.Id == item.Id)
                    return true;
            return false;
        }

    }
}
