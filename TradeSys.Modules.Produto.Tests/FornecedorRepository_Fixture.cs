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

namespace TradeSys.Modules.Fornecedor.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class FornecedorRepository_Fixture
    {

        private ISessionFactory _sessionFactory;

        private Configuration _configuration;

        private readonly FornecedorModel[] _Fornecedors = new[]
                 {
                     new FornecedorModel { Nome = "José", Sobrenome = "dos Santos", Email = "frioarts@hotmail.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new FornecedorModel { Nome = "Laíse", Sobrenome = "Silva", Email = "laisebastos@hotmail.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new FornecedorModel { Nome = "Wanessa", Sobrenome = "Bastos dos Santos", Email = "nessinha-bastos@hotmail.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new FornecedorModel { Nome = "Vinícius", Sobrenome = "Bastos dos Santos", Email = "vini_guitar@hotmail.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new FornecedorModel { Nome = "Jaqueline", Sobrenome = "Ferreira", Email = "jsbferreira@hotmail.com.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today }
                 };


        public void CreateInitialData()
        {
            using (ISession session = _sessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                foreach (var Fornecedor in _Fornecedors)
                    session.Save(Fornecedor);

                transaction.Commit();
            }
        }


        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _configuration = new Configuration();
            _configuration.Configure();
            _configuration.AddAssembly(typeof(FornecedorModel).Assembly);
            _sessionFactory = _configuration.BuildSessionFactory();

        }

        [SetUp]
        public void SetupContext()
        {
            new SchemaExport(_configuration).Execute(false, true, false);

            CreateInitialData();
        }

        [Test]
        public void Can_add_new_Fornecedor()
        {
            var Fornecedor = new FornecedorModel { Nome = "Eduardo", Sobrenome = "Santos", Email = "e3duardo@facebook.com", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today };
            IFornecedorRepository repository = new FornecedorRepository();
            repository.Add(Fornecedor);

            // use session to try to load the product

            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<FornecedorModel>(Fornecedor.Id);
                // Test that the product was successfully inserted
                Assert.IsNotNull(fromDb);
                Assert.AreNotSame(Fornecedor, fromDb);
                Assert.AreEqual(Fornecedor.Nome, fromDb.Nome);
                Assert.AreEqual(Fornecedor.Sobrenome, fromDb.Sobrenome);
            }
        }

        [Test]
        public void Can_update_existing_Fornecedor()
        {
            var Fornecedor = _Fornecedors[0];
            Fornecedor.Nome = "Yellow Pear";
            IFornecedorRepository repository = new FornecedorRepository();
            repository.Update(Fornecedor);

            // use session to try to load the product
            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<FornecedorModel>(Fornecedor.Id);
                Assert.AreEqual(Fornecedor.Nome, fromDb.Nome);
            }
        }

        [Test]
        public void Can_remove_existing_Fornecedor()
        {
            var product = _Fornecedors[0];
            IFornecedorRepository repository = new FornecedorRepository();
            repository.Remove(product);

            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<FornecedorModel>(product.Id);
                Assert.IsNull(fromDb);
            }
        }

        [Test]
        public void Can_get_existing_Fornecedor_by_id()
        {
            IFornecedorRepository repository = new FornecedorRepository();
            var fromDb = repository.GetById(_Fornecedors[1].Id);
            Assert.IsNotNull(fromDb);
            Assert.AreNotSame(_Fornecedors[1], fromDb);
            Assert.AreEqual(_Fornecedors[1].Nome, fromDb.Nome);
        }
        
        [Test]
        public void Can_get_existing_Fornecedors_by_nome()
        {
            IFornecedorRepository repository = new FornecedorRepository();
            var fromDb = repository.GetByNome("Jaqueline");

            Assert.AreEqual(1, fromDb.Count);
            Assert.IsTrue(IsInCollection(_Fornecedors[4], fromDb));
        }

        [Test]
        public void Can_get_existing_Fornecedors()
        {
            IFornecedorRepository repository = new FornecedorRepository();
            var fromDb = repository.GetAll();

        }

        private bool IsInCollection(FornecedorModel Fornecedor, ICollection<FornecedorModel> fromDb)
        {
            foreach (var item in fromDb)
                if (Fornecedor.Id == item.Id)
                    return true;
            return false;
        }



        //para um resultado
        //[Test]
        //public void Can_get_existing_product_by_name()
        //{
        //    IFornecedorsRepository repository = new FornecedorsRepository();
        //    var fromDb = repository.GetByNome(_Fornecedors[1].Nome);
        //
        //    Assert.IsNotNull(fromDb);
        //    Assert.AreNotSame(_Fornecedors[1], fromDb);
        //    Assert.AreEqual(_Fornecedors[1].Id, fromDb.Id);
        //}

    }
}
