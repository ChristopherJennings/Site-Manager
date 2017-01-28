using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.Administration;
using SiteManager.Core.Websites;

namespace SiteManager.IIS.Extensions
{
    public static class ObjectStateExtensions
    {
        public static Status ToStatus(this ObjectState value)
        {
            switch (value)
            {
                case ObjectState.Started:
                    return Status.Started;
                case ObjectState.Starting:
                    return Status.Starting;
                case ObjectState.Stopped:
                    return Status.Stopped;
                case ObjectState.Stopping:
                    return Status.Stopping;
                default:
                    return Status.Unknown;
            }
        }
    }
}
