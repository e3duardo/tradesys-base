using System;
using TradeSys.Modules.Base.Domain;

namespace TradeSys.Modules.Financeiro.Domain
{
    public enum Situacao {

    }

    /// <summary>
    /// Parcelas de Transacao
    /// </summary>
    public class ParcelaSituacaoModel : IIdentifiable, ISystem
    {
        public virtual long Id { get; set; }

        public virtual ParcelaModel Pacela { get; set; }


        public virtual decimal Valor { get; set; }

        public virtual Situacao Situacao { get; set; }

        
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
