using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Web.Administration;

namespace SiteManager.Models
{
    public class Website
    {
        public string Name { get; set; }
        public IEnumerable<string> OtherUrls { get; set; }
        public string PrimaryUrl { get; set; }
    }
}