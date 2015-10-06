using Linnworks.Service.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lnnwrkswbstr.App_Code
{
    public class BlackListIpsModule : IHttpModule
    {
        private readonly ICacheService _service;
        public BlackListIpsModule(ICacheService service)
        {
            _service = service;
        }

        void IHttpModule.Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += context_BeginRequest;
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication app = sender as HttpApplication;
            HttpContext context = app.Context;
            string ip = app.Context.Request.ServerVariables["REMOTE_ADDR"];
            //var isBlocked = _service.CheckForBlockedIp(ip);
            
            if (true)
            {
                context.Response.StatusCode = 404;
                context.Response.SuppressContent = true;
                context.Response.End();
            }
        }
    }
}