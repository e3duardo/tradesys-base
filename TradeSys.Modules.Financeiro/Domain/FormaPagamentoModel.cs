using System;
using TradeSys.Modules.Base.Domain;

namespace TradeSys.Modules.Financeiro.Domain
{
    /// <summary>
    /// Forma de Pagamento de uma transação
    /// </summary>
    public class FormaPagamentoModel : IIdentifiable, ISystem
    {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Descricao { get; set; }

        /// <summary>
        /// Se esta forma de pagamento "cai direto no caixa"
        /// </summary>
        public virtual bool Debito { get; set; }

        /// <summary>
        /// Se esta forma de pagamento é parcelada
        /// </summary>
        public virtual bool Parcelada { get; set; }

        /// <summary>
        /// Se parcelada for true, este atribudo determina se as parcelas terão mesmo valor ou se ele será variante
        /// </summary>
        public virtual bool ParcelaVariante { get; set; }

        /// <summary>
        /// String contendo numero possiveis de parcelas separados por virgula (ex "5,10,12")
        /// </summary>
        public virtual string Parcelas { get; set; }

        /// <summary>
        /// Porcentagem de juros sob esta forma de pagamento
        /// </summary>
        public virtual float Juros { get; set; }

        /// <summary>
        /// Quantidade de dinheiro que vai "direto ao caixa" em forma de pagamento parcelada
        /// </summary>
        public virtual decimal Entrada { get; set; }

        


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
