using System;
using TradeSys.Modules.Base.Domain;
using System.Collections.Generic;

namespace TradeSys.Modules.Financeiro.Domain
{
    /// <summary>
    /// Transações de caixa
    /// </summary>
    public class TransacaoModel : IIdentifiable, ISystem
    {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }
        
        public virtual TimeSpan Hora { get; set; }

        public virtual decimal Valor { get; set; }

        public virtual decimal ValorPago { get; set; }

        public virtual string Descricao { get; set; }


        public virtual CaixaModel Caixa { get; set; }

        public virtual FormaPagamentoModel FormaPagamento { get; set; }

        public virtual ICollection<ParcelaModel> Parcela { get; set; }

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
