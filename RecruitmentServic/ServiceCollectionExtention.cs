using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common.DTOs;
using Services.Interfaces;
using Services.Services;
using Repositories;


namespace Services
{
    public static class ServiceCollectionExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IService<CandidateDTO>,CandidateService>();
            services.AddScoped<IService<LlanguageDTO>, LanguageService>();
            services.AddScoped<IService<KnowledgeForWorkerDTO>, KnowledgeForWorkerService>();
            services.AddAutoMapper(typeof(Mapper));
        }
    }
}
