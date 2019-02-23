using System;
using TradeSys.Modules.Base.Domain;

namespace TradeSys.Modules.Produto.Domain
{
    /// <summary>
    /// Fornecedores
    /// </summary>
    public class FornecedorModel : IIdentifiable, IAddressable, INameable, ISystem
    {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Sobrenome { get; set; }

        public virtual string Bairro { get; set; }

        public virtual string Cep { get; set; }

        public virtual string Cidade { get; set; }

        public virtual string Complemento { get; set; }

        public virtual string Estado { get; set; }

        public virtual string Logadouro { get; set; }



        public virtual string Email { get; set; }


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
