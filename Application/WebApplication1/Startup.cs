using Bernhoeft.Api.Controllers;
using Bernhoeft.Infra.Context;
using Bernhoeft.Infra.Interface;
using Bernhoeft.Infra.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Bernhoeft.Infra.Service;
using Bernhoeft.Domain.Entity;
using Bernhoeft.Infra.Service.Interface;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ProductDbContext>();
            services.AddScoped<IEntityService<Product>>(ctx => new EntityService<Product>(ctx.GetRequiredService<ProductDbContext>()));
            services.AddScoped<IEntityService<Category>>(ctx => new EntityService<Category>(ctx.GetRequiredService<ProductDbContext>()));
            services.AddTransient<IProductRepository>(ctx => new ProductRepository(ctx.GetRequiredService<IEntityService<Product>>()));
            services.AddTransient<ICategoryRepository>(ctx => new CategoryRepository(ctx.GetRequiredService<IEntityService<Category>>()));
            services.AddScoped(ctx => new ProductController(ctx.GetRequiredService<IProductRepository>(), ctx.GetRequiredService<ProductDbContext>()));
            services.AddScoped(ctx => new CategoryController(ctx.GetRequiredService<ICategoryRepository>(), ctx.GetRequiredService<ProductDbContext>()));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Bernhoeft", Version = "v1" });
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bernhoeft v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
