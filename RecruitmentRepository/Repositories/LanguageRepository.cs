using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using RecruitmentRepository.Interfaces;
using RecruitmentRepository.Entities;

namespace Repositories.Repositories
{
    public class LanguageRepository:IRepository<Llanguage>
    {
        private readonly RecruitmentContext DB;
        public LanguageRepository(RecruitmentContext context)
        {
            this.DB = context;
        }
        public async Task<List<Llanguage>> GetAllAsync()
        {
            try
            {
                return await DB.Llanguages.ToListAsync();
            }
            catch
            {
                throw new Exception("Database reference failed");
            }
        }
    }
}

