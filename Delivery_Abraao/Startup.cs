//using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

using Delivery_Abraao.Context;
using Delivery_Abraao.Models;
using Delivery_Abraao.Repositories;
using Delivery_Abraao.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace Delivery_Abraao;

public class Startup
{
    public Startup(IConfiguration configuration) 
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        services.AddControllersWithViews();

        services.AddTransient<ILancheRepository, LancheRepository>();
        services.AddTransient<ICategoriaRepository, CategoriaRepository>();

        services.AddTransient<IPedidoRepository, PedidoRepository>();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));

        //Adiciona uma implementação padrão de IDistributedCache
        services.AddMemoryCache();
        services.AddSession();

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseSession();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name:"categoriaFiltro",
                pattern: "Lanche/{action}/{categoria?}",
                defaults: new {controller = "Lanche", action = "List"});

            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
