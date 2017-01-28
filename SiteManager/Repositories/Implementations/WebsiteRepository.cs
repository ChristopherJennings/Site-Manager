using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.Web.Administration;
using SiteManager.Models;

namespace SiteManager.Repositories.Implementations
{
    public class WebsiteRepository : IWebsiteRepository
    {
        private static ServerManager serverManager = ServerManager.OpenRemote("127.0.0.1");

        public IEnumerable<Website> GetWebsites()
        {
            return serverManager.Sites.Select(x=> GetWebsite(x));
        }

        private Website GetWebsite(Site site) {
            var Urls = GetUrls(site.Bindings);

            if(Urls.Count > 0)
            {
                return new Website()
                {
                    Name = site.Name,
                    PrimaryUrl = Urls.First(),
                    OtherUrls = Urls.Skip(1)
                };
            }

            return null;
        }

        private List<string> GetUrls(BindingCollection bindings) {
            var results = new List<string>();

            foreach (var binding in bindings)
            {
                var protocol = binding.Protocol + "://";
                var host = string.IsNullOrWhiteSpace(binding.Host) ? "localhost" : binding.Host;
                var ip = binding.EndPoint.Address != IPAddress.Any ? binding.EndPoint.Address.ToString() : string.Empty;
                var UrlBase = string.IsNullOrWhiteSpace(ip) ? host : ip;
                var port = binding.EndPoint.Port == 80 ? string.Empty : ":" + binding.EndPoint.Port.ToString();
                var url = protocol + UrlBase + port;

                results.Add(url);
            }

            return results;
        }
    }
}