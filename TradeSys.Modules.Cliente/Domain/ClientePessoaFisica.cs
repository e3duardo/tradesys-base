using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Modules.Cliente.Domain
{
    public class ClientePessoaFisica : ICliente
    {
        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string ICliente.Sobrenome { get; set; }

        public virtual string Bairro { get; set; }

        public virtual string Cep { get; set; }

        public virtual string Cidade { get; set; }

        public virtual string Complemento { get; set; }

        public virtual string Estado { get; set; }

        public virtual string Logadouro { get; set; }

        public virtual string Celular { get; set; }

        public virtual string Telefone { get; set; }

        public virtual string Fax { get; set; }

        public virtual string Email { get; set; }

        public virtual string Site { get; set; }

        public virtual string Cpf { get; set; }

        public virtual string Rg { get; set; }

        public virtual string RgEstado { get; set; }

        public virtual string Paternidade { get; set; }

        public virtual string Maternidade { get; set; }

        public virtual DateTime Nascimento { get; set; }

        public virtual Base.Domain.Pessoa Pessoa { get; set; }

        public virtual string Observacoes { get; set; }

        public virtual string ReferenciaComercial { get; set; }

        public virtual string EstadoCivil { get; set; }

        public virtual string Sexo { get; set; }

        public virtual string RendaMensal { get; set; }

        public virtual string Profissao { get; set; }

        public virtual int LimiteParcelamento { get; set; }

        public virtual bool AptoParcelamento { get; set; }

        public virtual int DiaVencimentoParcelamento { get; set; }


        public virtual DateTime Sys_DataCadastro { get; set; }

        public virtual DateTime Sys_DataModificado { get; set; }

        public virtual bool Sys_Ativo { get; set; }

        public virtual string Sys_Ativo_Descricao { get; set; }

    }
}
