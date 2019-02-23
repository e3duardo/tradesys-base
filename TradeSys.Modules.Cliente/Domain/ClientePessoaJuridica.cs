using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Modules.Cliente.Domain
{
    public class ClientePessoaJuridica : ICliente
    {
        public virtual long Id { get; set; }

        public virtual string NomeContato { get; set; }

        public virtual string NomeFantasia { get; set; }

        public virtual string Bairro { get; set; }

        public virtual string Cep { get; set; }

        public virtual string Cidade { get; set; }

        public virtual string Complemento { get; set; }

        public virtual string Estado { get; set; }

        public virtual string Logadouro { get; set; }

        public virtual string Celular { get; set; }

        public virtual string Telefone { get; set; }

        public virtual string Fax { get; set; }

        public virtual string TelefonesAdicionais { get; set; }

        public virtual string Email { get; set; }

        public virtual string Site { get; set; }

        public virtual string Cnpj { get; set; }

        public virtual string InscricaoEstadual { get; set; }

        public virtual Base.Domain.Pessoa Pessoa { get; set; }

        public virtual string Observacoes { get; set; }

        public virtual int LimiteParcelamento { get; set; }

        public virtual bool AptoParcelamento { get; set; }

        public virtual int DiaVencimentoParcelamento { get; set; }


        public virtual DateTime Sys_DataCadastro { get; set; }

        public virtual DateTime Sys_DataModificado { get; set; }

        public virtual bool Sys_Ativo { get; set; }

        public virtual string Sys_Ativo_Descricao { get; set; }
    }
}
