﻿using System.Web;
using System.Web.Mvc;

namespace Proje.PresentationLayer_MvcUi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
