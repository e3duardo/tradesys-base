//===================================================================================
// Trade Management System
// Sistema de gerenciamento de comércio para lojas de pequeno á médio porte.
//===================================================================================
// Copyright (c) Eduardo Bastos dos Santos.  Todos direitos reservados.
// 
// CRIAÇÃO:         24/06/2011
// MODIFICAÇÔES: 
//===================================================================================
// Em comparação com a Classe Caixa antiga temos que este caixa, atual, não tem os
//  atributos, Saldo e Status. 
// Pois com a nova arquitetura deste sistema, TradeSys, não precisamos do atributo 
//  Saldo, que já vem em todas as classes que implementam ISystem como Sys_Ativo. E 
//  Saldo será calculado pela soma de todas as transações com IdCaixa == 
//  "IdCaixaAtual".
//===================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TradeSys.Modules.Base.Domain;

namespace TradeSys.Modules.Financeiro.Domain
{
    /// <summary>
    /// Caixa
    /// </summary>
    public class CaixaModel : IIdentifiable, ISystem
    {
        public virtual long Id { get; set; }

        public virtual DateTime Data { get; set; }

        /// <summary>
        /// Data de cadastro, com Time
        /// </summary>
        public virtual DateTime Sys_DataCadastro { get; set; }
        /// <summary>
        /// Data que foi modificado pela última vez, com Time
        /// </summary>
        public virtual DateTime Sys_DataModificado { get; set; }
        /// <summary>
        /// Se objeto esta ativo ou não.
        /// </summary>
        public virtual bool Sys_Ativo { get; set; }
    }
}
