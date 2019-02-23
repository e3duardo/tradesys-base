using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Modules.Base.Domain
{
    public interface INameable
    {
        string Nome { get; set; }
        string Sobrenome { get; set; }
    }
}
