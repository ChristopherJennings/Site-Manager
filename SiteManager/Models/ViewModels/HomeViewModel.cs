﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiteManager.Core.Websites;

namespace SiteManager.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<Website> Websites { get; set; }
    }
}