using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NFCWebApi.Models;

namespace NFCWebApi
{
    public class Startup
    {
        private readonly string AllowSpecificOrigin = "AllowSpecificOrigin";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
       

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => { options.EnableEndpointRouting = false; });
            services.AddDbContext<NFCContext>(option => option.UseNpgsql(Configuration.GetConnectionString("PostgreSql")));
            services.AddControllers();

            #region ����
            services.AddCors(options =>
            {
                options.AddPolicy(AllowSpecificOrigin,
                    builder =>
                    {
                        builder.AllowAnyMethod()
                            .AllowAnyOrigin()
                            .AllowAnyHeader();
                    });
            });
            #endregion

        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            //CORS �м����������Ϊ�ڶ� UseRouting �� UseEndpoints�ĵ���֮��ִ�С� ���ò���ȷ�������м��ֹͣ�������С�
            app.UseCors(AllowSpecificOrigin);
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
        }

    }
}
