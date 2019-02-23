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
    //todo:renomear esta classe ou não...
    /// <summary>
    /// Item de permissões. Isto é uma "lista" com todas as janelas e seu nivel de visibilidade
    /// </summary>
    public class PermissaoItemModel : IIdentifiable, ISystem
    {

        public virtual long Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Descricao { get; set; }


        public virtual bool Acessivel { get; set; }//se é permitido acesso ou não

        public virtual string AssemblyPath { get; set; }//assembly do item a ser permitido

        public virtual string AssemblyName { get; set; }//item a ser permetido


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
