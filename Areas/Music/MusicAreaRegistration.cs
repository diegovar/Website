﻿using System.Web.Mvc;

namespace Website.Areas.Music
{
    public class MusicAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Music";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Music_default",
                "Music/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
