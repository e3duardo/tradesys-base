﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeSys.Modules.Base.Domain
{
    public interface IIdentifiable
    {
        long Id { get; set; }
    }
}