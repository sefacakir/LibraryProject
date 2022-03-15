using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Autofac ile bu kýsýmlar artýk kullanýlmýyor.
            //Bu kýsýmlarý apide deðilde backend kýsmýnda hallediyoruz.
            services.AddControllers();

            /*services.AddSingleton<IBookService, BookManager>();
            services.AddSingleton<IBookDal, BookDal>();
            services.AddSingleton<IAuthorService, AuthorManager>();
            services.AddSingleton<IAuthorDal, AuthorDal>();
            services.AddSingleton<ICategoryDal, CategoryDal>();
            services.AddSingleton<ICategoryService, CategoryManager>();*/

            services.AddSwaggerDocument();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
