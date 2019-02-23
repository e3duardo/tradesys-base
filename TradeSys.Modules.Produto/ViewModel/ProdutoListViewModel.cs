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
    [Export(typeof(ProdutoListViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ProdutoListViewModel : NotificationObject
    {
        private ICollection<ProdutoModel> produtos;

        public ICollection<ProdutoModel> Produtos
        {
            get { return this.produtos; }
            set
            {
                //this.ValidateShares(value, true);
                //this.ValidateHasEnoughSharesToSell(value, this.TransactionType, true);

                if (this.produtos != value)
                {
                    this.produtos = value;
                    this.RaisePropertyChanged(() => this.Produtos);
                }
            }
        }

        public ProdutoListViewModel()
        {
            IProdutoRepository repository = new ProdutoRepository();
            this.Produtos = repository.GetAll();
            Console.Write(this);
        }

        public string HeaderInfo
        {
            get { return "Lista DE Produto"; }
        }

    }
}
