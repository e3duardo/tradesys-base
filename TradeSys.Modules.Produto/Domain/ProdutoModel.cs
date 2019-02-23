using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TradeSys.Modules.Base.Domain;

namespace TradeSys.Modules.Produto.Domain
{
    /// <summary>
    /// Produtos
    /// </summary>
    public class ProdutoModel : IIdentifiable, ISystem
    {
        public ProdutoModel()
        {
          //  Fornecedor = new List<FornecedorModel>();
        }

        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }


        public virtual SetorModel Setor { get; set; }

        public virtual ICollection<FornecedorModel> Fornecedor { get; set; }


        /// <summary>
        /// Data de cadastro, com Time
        /// </summary>
        public virtual DateTime Sys_DataCadastro { get; set; }
        /// <summary>
        /// Data que foi modificado pela última vez, com Time
        /// </summary>
        public virtual DateTime Sys_DataModificado { get; set; }
        /// <summary>
        /// Se objeto esta ativo ou não
        /// </summary>
        public virtual bool Sys_Ativo { get; set; }
    }
}
