using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManager.Core.Websites
{
    public enum Status
    {
        Starting = 0,
        Started = 1,
        Stopping = 2,
        Stopped = 3,
        Unknown = 4
    }
}
