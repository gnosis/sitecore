﻿using System;
using System.Web;

using Sitecore.GnosisToolkit.Library.Mvc.Models;
using Sitecore.GnosisToolkit.Library.Attributes;

namespace Sitecore.GnosisToolkit.Areas.GnosisToolkit.Models.General
{
    public class CallToActionModel : ItemModel, ICallToAction
    {
        public HtmlString Heading { get; set; }
        public HtmlString Image { get; set; }
        public HtmlString Body { get; set; }
        public HtmlString Link { get; set; }
        public string LinkUrl { get; set; }
    }
}