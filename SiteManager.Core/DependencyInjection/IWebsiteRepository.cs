using System.Collections.Generic;
using SiteManager.Core.Websites;

namespace SiteManager.Core.DependencyInjection
{
    public interface IWebsiteRepository : IRepository
    {
        IEnumerable<Website> GetWebsites();
    }
}