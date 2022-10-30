using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVentasCaprichos.Server.Data;
using SistemaVentasCaprichos.Shared;

[assembly: HostingStartup(typeof(SistemaVentasCaprichos.Server.Areas.Identity.IdentityHostingStartup))]
namespace SistemaVentasCaprichos.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}