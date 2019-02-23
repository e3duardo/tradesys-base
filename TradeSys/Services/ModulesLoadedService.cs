//===================================================================================
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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;
using TradeSys.Infrastructure.Interfaces;
using TradeSys.Infrastructure.Models;
using System.ComponentModel.Composition;
using System.Collections;

namespace TradeSys.Modules.News.Services
{
    [Export(typeof(IModulesLoadedService))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class ModulesLoadedService : IModulesLoadedService
    {
       readonly ICollection<Module> modulesData = new List<Module>();

        public ModulesLoadedService()
        {
            var document = XDocument.Parse(TradeSys.Properties.Resources.ModulesLoaded);

            //modulesData = document.Descendants("Modules").(x => new Module{Header = x.Element("Header").Value});

        }

        #region IModulesLoadedService Members

        public ICollection GetAllModulesLoaded()
        {
            return null;
        }


        #endregion
    }
}
