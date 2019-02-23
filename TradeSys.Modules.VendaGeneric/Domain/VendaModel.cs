using System;
using System.Collections.Generic;
using TradeSys.Modules.Base.Domain;
using TradeSys.Modules.Funcionario.Domain;
using TradeSys.Modules.Cliente.Domain;
using TradeSys.Modules.Produto.Domain;
using TradeSys.Modules.Financeiro.Domain;

namespace TradeSys.Modules.VendaGeneric.Domain
{
    /// <summary>
    /// Produtos
    /// </summary>
    public class VendaModel : IIdentifiable, ISystem
    {

        public virtual long Id { get; set; }

        public virtual FuncionarioModel Funcionario { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual TransacaoModel Transacao { get; set; }

        public virtual ICollection<ProdutoModel> Produto { get; set; }


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
