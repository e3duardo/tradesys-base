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
    [Export(typeof(ClienteListViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ClienteListViewModel : NotificationObject
    {
        private ICollection<Cliente> clientes;

        public ICollection<Cliente> Clientes
        {
            get { return this.clientes; }
            set
            {
                //this.ValidateShares(value, true);
                //this.ValidateHasEnoughSharesToSell(value, this.TransactionType, true);

                if (this.clientes != value)
                {
                    this.clientes = value;
                    this.RaisePropertyChanged(() => this.Clientes);
                }
            }
        }

        public ClienteListViewModel()
        {
            IClienteRepository repository = new ClienteRepository();
            this.Clientes = repository.GetAll();
            Console.Write(this);
        }

        public string HeaderInfo
        {
            get { return "Lista DE CLIENTE"; }
        }

    }
}
