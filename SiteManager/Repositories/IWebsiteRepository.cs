using System.Collections.Generic;

using SiteManager.Models;

namespace SiteManager.Repositories
{
    public interface IWebsiteRepository : IRepository
    {
        IEnumerable<Website> GetWebsites();
    }
}