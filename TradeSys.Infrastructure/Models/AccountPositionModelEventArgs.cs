using System;

namespace TradeSys.Infrastructure.Models
{
    public class AccountPositionModelEventArgs : EventArgs
    {
        public AccountPositionModelEventArgs(AccountPosition position)
        {
            AcctPosition = position;
        }

        public AccountPosition AcctPosition { get; set; }
    }
}
