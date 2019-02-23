using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace TradeSys.Modules.Tests
{
    [TestClass]
    public class GenerateSchema_Fixture
    {
        [TestMethod]
        public void Can_generate_schema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly("TradeSys.Modules.Cliente");
            cfg.AddAssembly("TradeSys.Modules.Financeiro");
            cfg.AddAssembly("TradeSys.Modules.Funcionario");
            cfg.AddAssembly("TradeSys.Modules.Produto");
            cfg.AddAssembly("TradeSys.Modules.VendaGeneric");

            new SchemaExport(cfg).Execute(false, true, false);
        }
    }
}