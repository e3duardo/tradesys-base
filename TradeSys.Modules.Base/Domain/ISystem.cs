using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Modules.Base.Domain
{
    public interface ISystem
    {
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
    }
}
