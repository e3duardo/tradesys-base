//===================================================================================
// Trade Management System
// Sistema de gerenciamento de comércio para lojas de pequeno á médio porte.
//===================================================================================
// Copyright (c) Eduardo Bastos dos Santos.  Todos direitos reservados.
// 
// CRIAÇÃO:         14/07/2011
// MODIFICAÇÔES: 
//===================================================================================
// <Resumo aqui>
//===================================================================================
using System;
using TradeSys.Modules.Base.Domain;

namespace TradeSys.Modules.Funcionario.Domain
{
    /// <summary>
    /// Funcionário
    /// </summary>
    public class FuncionarioModel : IIdentifiable, IAddressable, INameable, ISystem
    {
        public virtual long Id { get; set; }

        public virtual string Bairro { get; set; }

        public virtual string Cep { get; set; }

        public virtual string Cidade { get; set; }

        public virtual string Complemento { get; set; }

        public virtual string Estado { get; set; }

        public virtual string Logadouro { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Sobrenome { get; set; }


        public virtual decimal Salario { get; set; }
        public virtual float Comissao { get; set; }


        public virtual CargoModel Cargo { get; set; }
        public virtual PermissaoModel Permissao { get; set; }


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
