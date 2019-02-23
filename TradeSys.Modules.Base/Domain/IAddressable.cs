using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Modules.Base.Domain
{
    public interface IAddressable
    {
        string Bairro { get; set; }
        string Cep { get; set; }
        string Cidade { get; set; }
        string Complemento { get; set; }
        string Estado { get; set; }
        string Logadouro { get; set; }
    }
}
