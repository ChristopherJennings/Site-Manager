using System.Collections.Generic;

namespace SiteManager.Core.Websites
{
    public class Website
    {
        public string Name { get; set; }
        public IEnumerable<string> OtherUrls { get; set; }
        public string PrimaryUrl { get; set; }
        public Status Status { get; set; }
    }
}