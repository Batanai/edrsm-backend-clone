using System;
using System.Collections.Generic;
using System.Text;

namespace ContactCenter.Lib
{
    public enum TicketStatus : int
    {
        PENDING = 0,
        IN_PROGRESS = 1,
        RESOLVED = 2,
        CANCELLED = 3,
    }
}
