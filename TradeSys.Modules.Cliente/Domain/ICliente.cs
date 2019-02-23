using System;
using TradeSys.Modules.Base.Domain;

namespace TradeSys.Modules.Cliente.Domain
{
    /// <summary>
    /// Clientes
    /// </summary>
    public interface ICliente : IIdentifiable, INameable, IAddressable, ISystem
    {
        long Id { get; set; }

        string Bairro { get; set; }

        string Cep { get; set; }

        string Cidade { get; set; }

        string Complemento { get; set; }

        string Estado { get; set; }

        string Logadouro { get; set; }

        string Celular { get; set; }

        string Telefone { get; set; }

        string Fax { get; set; }

        string TelefonesAdicionais { get; set; }

        string Email { get; set; }

        string Site { get; set; }

        Pessoa Pessoa { get; set; }

        string Observacoes { get; set; }

        int LimiteParcelamento { get; set; }

        bool AptoParcelamento { get; set; }

        int DiaVencimentoParcelamento { get; set; }

        /// <summary>
        /// Data de cadastro, com Time
        /// </summary>
        DateTime Sys_DataCadastro { get; set; }
        /// <summary>
        /// Data que foi modificado pela última vez, com Time
        /// </summary>
        DateTime Sys_DataModificado { get; set; }
        /// <summary>
        /// Se objeto esta ativo ou não
        /// </summary>
        bool Sys_Ativo { get; set; }

        string Sys_Ativo_Descricao { get; set; }
    }
}
