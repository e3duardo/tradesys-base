using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.ViewModel;
using TradeSys.Modules.Produto.Domain;
using TradeSys.Modules.Produto.Repositories;

namespace TradeSys.Modules.Produto.ViewModel
{
    [Export(typeof(ProdutoFilterViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ProdutoFilterViewModel : NotificationObject
    {
        

        public ProdutoFilterViewModel()
        {
        }

        public string HeaderInfo
        {
            get { return "Lista DE Produto"; }
        }

    }
}
