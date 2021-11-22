using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.api
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
          
            services.AddControllers();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IAccountService, AccountManager>();
            services.AddTransient<IAccountRoleAuthorizationService, AccountRoleAuthorizationManager>();
            services.AddTransient<IAnswerSetService, AnswerSetManager>();
            services.AddTransient<IAnswerSetDetailService, AnswerSetDetailManager>();
            services.AddTransient<IAuditService, AuditManager>();
            services.AddTransient<IAuditAnswersService, AuditAnswersManager>();
            services.AddTransient<IBlockService, BlockManager>();
            services.AddTransient<ICompanyService, CompanyManager>();
            services.AddTransient<IPreventiveActivityService, PreventiveActivityManager>();
            services.AddTransient<IFacilityService, FacilityManager>();
            services.AddTransient<IFacilityTypeService, FacilityTypeManager>();
            services.AddTransient<IFloorService, FloorManager>();
            services.AddTransient<IImportanceLevelService, ImportanceLevelManager>();
            services.AddTransient<IInspectionSetService, InspectionSetManager>();
            services.AddTransient<IInspectionSetQuestionsService, InspectionSetQuestionManager>();
            services.AddTransient<IInspectionUnsuitabilityService, InspectionUnsuitabilityManager>();
            services.AddTransient<ILocationAuthorizationService, LocationAuthorizationManager>();
            services.AddTransient<IPeriodService, PeriodManager>();
            services.AddTransient<IPreventiveActivityService, PreventiveActivityManager>();
            services.AddTransient<IRoleAuthorizationService, RoleAuthorizationManager>();
            services.AddTransient<IRoleService, RoleManager>();
            services.AddTransient<IRoomService, RoomManager>();
            services.AddTransient<IRoomTypeService, RoomTypeManager>();
            services.AddTransient<ISISServiceService, SISServiceManager>();
            services.AddTransient<ISurveyDesignService, SurveyDesignManager>();
            services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("DevConnection"), x => x.MigrationsAssembly("DataAccessLayer")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Web.api", Version = "v1" });
            });
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins(
                                        "http://localhost:3000")
                            .AllowAnyMethod().AllowAnyHeader();
                                  });
            });
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
            {
                option.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Token:Issuer"],
                    ValidAudience = Configuration["Token:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecurityKey"])),
                    ClockSkew = TimeSpan.Zero
                };
            });
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider services)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web.api v1"));
            }

            app.UseHttpsRedirection();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseRouting();

            app.UseCors();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
