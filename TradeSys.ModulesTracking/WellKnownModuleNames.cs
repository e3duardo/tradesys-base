﻿//===================================================================================
// Microsoft patterns & practices
// Composite Application Guidance for Windows Presentation Foundation and Silverlight
//===================================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===================================================================================
namespace TradeSys.ModulesTracking
{
    /// <summary>
    /// A set of well-known module names for communication with IModuleTracker.
    /// </summary>
    public static class WellKnownModuleNames
    {
        /// <summary>
        /// The name of module A.
        /// </summary>
        public const string ModuleBase = "ModuleBase";

        /// <summary>
        /// The name of module B.
        /// </summary>
        public const string ModuleCliente = "ModuleCliente";

        /// <summary>
        /// The name of module C.
        /// </summary>
        public const string ModuleFinanceiro = "ModuleFinanceiro";

        /// <summary>
        /// The name of module D.
        /// </summary>
        public const string ModuleFuncionario = "ModuleFuncionario";

        /// <summary>
        /// The name of module E.
        /// </summary>
        public const string ModuleProduto = "ModuleProduto";

        /// <summary>
        /// The name of module F.
        /// </summary>
        public const string ModuleVendaGeneric = "ModuleVendaGeneric";
    }
}