using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.ViewModel;
using TradeSys.Modules.Cliente.Domain;
using TradeSys.Modules.Cliente.Repositories;

namespace TradeSys.Modules.Cliente.ViewModel
{
    [Export(typeof(ClienteFilterViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ClienteFilterViewModel : NotificationObject
    {
        

        public ClienteFilterViewModel()
        {
        }

        public string HeaderInfo
        {
            get { return "Lista DE CLIENTE"; }
        }

    }
}
