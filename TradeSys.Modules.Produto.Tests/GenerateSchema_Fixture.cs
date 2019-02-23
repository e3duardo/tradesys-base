﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace TradeSys.Modules.Produto.Tests
{
    [TestClass]
    public class GenerateSchema_Fixture
    {
        [TestMethod]
        public void Can_generate_schema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly("TradeSys.Modules.Produto");

            new SchemaExport(cfg).Execute(false, true, false);
        }
    }
}