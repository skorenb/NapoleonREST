﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AutoMapper;
using NapoleonNotes.Filters;

namespace NapoleonNotes
{
    public class Startup
    {        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services
                .AddMvc(options=>
                {
                    options.Filters.Add<InvalidModelResponseFilter>();
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }
        
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
