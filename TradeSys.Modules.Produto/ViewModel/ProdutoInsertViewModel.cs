using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using TradeSys.Infrastructure;
using TradeSys.Modules.Base;
using TradeSys.Modules.Produto.Domain;
using TradeSys.Modules.Produto.Repositories;
using Microsoft.Practices.Prism.ViewModel;

namespace TradeSys.Modules.Produto.ViewModel
{
    [Export(typeof(ProdutoInsertViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ProdutoInsertViewModel : NotificationObject
    {
        private string nome;
        private string sobrenome;
        private string bairro;
        private string cep;
        private string cidade;
        private string complemento;
        private string estado;
        private string logadouro;
        private string email;

        private readonly List<string> errors = new List<string>();

        public ProdutoInsertViewModel()
        {
            this.SubmitCommand = new DelegateCommand<object>(this.Submit, this.CanSubmit);
            this.CancelCommand = new DelegateCommand<object>(this.Cancel);
        }



        public string HeaderInfo
        {
            get { return "CADASTRO DE Produto"; }
        }

        public string Nome
        {
            get { return this.nome; }
            set
            {
                //this.ValidateShares(value, true);
                //this.ValidateHasEnoughSharesToSell(value, this.TransactionType, true);

                if (this.nome != value)
                {
                    this.nome = value;
                    this.RaisePropertyChanged(() => this.Nome);
                }
            }
        }
        public string Sobrenome
        {
            get { return this.sobrenome; }
            set
            {
                //this.ValidateShares(value, true);
                //this.ValidateHasEnoughSharesToSell(value, this.TransactionType, true);

                if (this.sobrenome != value)
                {
                    this.sobrenome = value;
                    this.RaisePropertyChanged(() => this.Sobrenome);
                }
            }
        }
        public string Bairro
        {
            get { return this.bairro; }
            set
            {
                //this.ValidateShares(value, true);
                //this.ValidateHasEnoughSharesToSell(value, this.TransactionType, true);

                if (this.bairro != value)
                {
                    this.bairro = value;
                    this.RaisePropertyChanged(() => this.Bairro);
                }
            }
        }
        public string Cep
        {
            get { return this.cep; }
            set
            {
                //this.ValidateShares(value, true);
                //this.ValidateHasEnoughSharesToSell(value, this.TransactionType, true);

                if (this.cep != value)
                {
                    this.cep = value;
                    this.RaisePropertyChanged(() => this.Cep);
                }
            }
        }
        public string Cidade
        {
            get { return this.cidade; }
            set
            {
                //this.ValidateShares(value, true);
                //this.ValidateHasEnoughSharesToSell(value, this.TransactionType, true);

                if (this.cidade != value)
                {
                    this.cidade = value;
                    this.RaisePropertyChanged(() => this.Cidade);
                }
            }
        }
        public string Complemento
        {
            get { return this.complemento; }
            set
            {
                //this.ValidateShares(value, true);
                //this.ValidateHasEnoughSharesToSell(value, this.TransactionType, true);

                if (this.complemento != value)
                {
                    this.complemento = value;
                    this.RaisePropertyChanged(() => this.Complemento);
                }
            }
        }
        public string Estado
        {
            get { return this.estado; }
            set
            {
                //this.ValidateShares(value, true);
                //this.ValidateHasEnoughSharesToSell(value, this.TransactionType, true);

                if (this.estado != value)
                {
                    this.estado = value;
                    this.RaisePropertyChanged(() => this.Estado);
                }
            }
        }
        public string Logadouro
        {
            get { return this.logadouro; }
            set
            {
                //this.ValidateShares(value, true);
                //this.ValidateHasEnoughSharesToSell(value, this.TransactionType, true);

                if (this.logadouro != value)
                {
                    this.logadouro = value;
                    this.RaisePropertyChanged(() => this.Logadouro);
                }
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                //this.ValidateShares(value, true);
                //this.ValidateHasEnoughSharesToSell(value, this.TransactionType, true);

                if (this.email != value)
                {
                    this.email = value;
                    this.RaisePropertyChanged(() => this.Email);
                }
            }
        }


        public DelegateCommand<object> SubmitCommand { get; private set; }

        public DelegateCommand<object> CancelCommand { get; private set; }

        private bool CanSubmit(object parameter)
        {
            return this.errors.Count == 0;
        }

        private void Submit(object parameter)
        {
            //if (!this.CanSubmit(parameter))
            //{
            //    throw new InvalidOperationException();
            //}

            var Produto = new ProdutoModel();

            Produto.Nome = this.Nome;
           
            Produto.Sys_DataCadastro = DateTime.Now;
            Produto.Sys_Ativo = true;

            IProdutoRepository repository = new ProdutoRepository();
            repository.Add(Produto);

            //CloseViewRequested(this, EventArgs.Empty);
        }

        private void Cancel(object parameter)
        {
            //CloseViewRequested(this, EventArgs.Empty);
        }
    }
}
