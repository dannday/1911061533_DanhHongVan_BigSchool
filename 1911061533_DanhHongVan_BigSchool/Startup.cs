﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911061533_DanhHongVan_BigSchool.Startup))]
namespace _1911061533_DanhHongVan_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
