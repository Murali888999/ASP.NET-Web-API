﻿using HelloWebAPI.Configuration;
using System;
using System.Web.Http;

public class Global : System.Web.HttpApplication
{
    protected void Application_Start(object sender, EventArgs e)
    {
        GlobalConfiguration.Configure(HelloWebAPIConfig.Register);
    }
}