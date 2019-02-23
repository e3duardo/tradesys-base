using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Infrastructure.Interfaces
{
    public interface IHeaderInfoProvider<T>
    {
        T HeaderInfo { get; }
    }
}
