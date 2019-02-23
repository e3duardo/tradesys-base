using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TradeSys.Infrastructure.Models;

namespace TradeSys.Infrastructure.Interfaces
{
    public interface IAccountPositionService
    {
        event EventHandler<AccountPositionModelEventArgs> Updated;
        IList<AccountPosition> GetAccountPositions();
    }
}
