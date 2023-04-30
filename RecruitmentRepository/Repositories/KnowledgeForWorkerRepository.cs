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
    public class KnowledgeForWorkerRepository:IRepository<KnowledgeForWorker>
    {
        private readonly RecruitmentContext DB;
        public KnowledgeForWorkerRepository(RecruitmentContext context)
        {
            this.DB = context;
        }
        public async Task<List<KnowledgeForWorker>> GetAllAsync()
        {
            try
            {
                return await DB.KnowledgeForWorkers.ToListAsync();
            }
            catch
            {
                throw new Exception("Database reference failed");
            }
        }
    }
}

