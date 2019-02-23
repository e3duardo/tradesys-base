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

namespace TradeSys.Modules.Setor.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class SetorRepository_Fixture
    {

        private ISessionFactory _sessionFactory;

        private Configuration _configuration;

        private readonly SetorModel[] _Setors = new[]
                 {
                     new SetorModel {Nome = "teste1", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new SetorModel {Nome = "teste2", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new SetorModel {Nome = "teste3", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new SetorModel {Nome = "teste4", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today },
                     new SetorModel {Nome = "teste5", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today }
                 };


        public void CreateInitialData()
        {
            using (ISession session = _sessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                foreach (var Setor in _Setors)
                    session.Save(Setor);

                transaction.Commit();
            }
        }


        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _configuration = new Configuration();
            _configuration.Configure();
            _configuration.AddAssembly("TradeSys.Modules.Produto");
            _sessionFactory = _configuration.BuildSessionFactory();

        }

        [SetUp]
        public void SetupContext()
        {
            new SchemaExport(_configuration).Execute(false, true, false);

            CreateInitialData();
        }

        [Test]
        public void Can_add_new_Setor()
        {
            var Setor = new SetorModel { Nome = "added1", Sys_Ativo = true, Sys_DataCadastro = DateTime.Today };
            ISetorRepository repository = new SetorRepository();
            repository.Add(Setor);

            // use session to try to load the product

            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<SetorModel>(Setor.Id);
                // Test that the product was successfully inserted
                Assert.IsNotNull(fromDb);
                Assert.AreNotSame(Setor, fromDb);
                Assert.AreEqual(Setor.Nome, fromDb.Nome);
                // Assert.AreEqual(Setor.Sobrenome, fromDb.Sobrenome);
            }
        }

        [Test]
        public void Can_update_existing_Setor()
        {
            var Setor = _Setors[0];
            Setor.Nome = "edited";
            ISetorRepository repository = new SetorRepository();
            repository.Update(Setor);

            // use session to try to load the product
            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<SetorModel>(Setor.Id);
                Assert.AreEqual(Setor.Nome, fromDb.Nome);
            }
        }

        [Test]
        public void Can_remove_existing_Setor()
        {
            var product = _Setors[0];
            ISetorRepository repository = new SetorRepository();
            repository.Remove(product);

            using (ISession session = _sessionFactory.OpenSession())
            {
                var fromDb = session.Get<SetorModel>(product.Id);
                Assert.IsNull(fromDb);
            }
        }

        [Test]
        public void Can_get_existing_Setor_by_id()
        {
            ISetorRepository repository = new SetorRepository();
            var fromDb = repository.GetById(_Setors[1].Id);
            Assert.IsNotNull(fromDb);
            Assert.AreNotSame(_Setors[1], fromDb);
            Assert.AreEqual(_Setors[1].Nome, fromDb.Nome);
        }

        [Test]
        public void Can_get_existing_Setors_by_nome()
        {
            ISetorRepository repository = new SetorRepository();
            var fromDb = repository.GetByNome("Jaqueline");

            Assert.AreEqual(1, fromDb.Count);
            Assert.IsTrue(IsInCollection(_Setors[4], fromDb));
        }

        

        [Test]
        public void Can_get_existing_Setors()
        {
            ISetorRepository repository = new SetorRepository();
            var fromDb = repository.GetAll();

        }

        private bool IsInCollection(SetorModel Setor, ICollection<SetorModel> fromDb)
        {
            foreach (var item in fromDb)
                if (Setor.Id == item.Id)
                    return true;
            return false;
        }

    }
}
