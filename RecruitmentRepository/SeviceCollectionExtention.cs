using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentRepository.Entities;
using RecruitmentRepository.Interfaces;
using Repositories.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repositories
{
    public static class SeviceCollectionExtention
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<RecruitmentContext>(opt => opt.UseSqlServer("Server=LAPTOP - UNOI3OU0\\MSSQLSERVER01; Database = Recruitment;Trusted_Connection=true;Encrypt=False"));
            services.AddScoped<IRepository<Candidate>, CandidateRepository>();
            services.AddScoped<IRepository<Llanguage>, LanguageRepository>();
            services.AddScoped<IRepository<KnowledgeForWorker>, KnowledgeForWorkerRepository>();
        }
    }
}
