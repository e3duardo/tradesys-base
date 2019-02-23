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
    /// Cargos de Funcinários
    /// </summary>
    public class CargoModel : IIdentifiable, ISystem
    {
        public virtual long Id { get; set; }

        public virtual string Funcao { get; set; }

        public virtual string Descricao { get; set; }

        public virtual decimal SalarioBase { get; set; }

        public virtual float ComissaoBase { get; set; }


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
