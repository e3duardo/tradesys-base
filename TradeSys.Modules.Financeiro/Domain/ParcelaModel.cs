using System;
using TradeSys.Modules.Base.Domain;

namespace TradeSys.Modules.Financeiro.Domain
{
    /// <summary>
    /// Parcelas de Transacao
    /// </summary>
    public class ParcelaModel : IIdentifiable, ISystem
    {
        public virtual long Id { get; set; }

        public virtual DateTime Vencimento { get; set; }

        public virtual DateTime Pagamento { get; set; }

        public virtual decimal Valor { get; set; }

        //todo: verificar como fazer quando paga um valor menor que o da parcela.
        /// <summary>
        /// Transação de uma parcela. Se for null não esta paga
        /// </summary>
        public virtual TransacaoModel Transacao { get; set; }


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
