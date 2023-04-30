using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitmentRepository.Entities;
using RecruitmentRepository.Interfaces;

namespace Repositories.Repositories
{
    public class CandidateRepository : IRepository<Candidate>
    {
        private readonly RecruitmentContext DB;
        public CandidateRepository(RecruitmentContext context)
        {
            DB = context;
        }
        public async Task<List<Candidate>> GetAllAsync()
        {
            try
            {
                DB.Candidates.Include(c => c.KnowledgeForWorkers).ToList();
                DB.Llanguages.Include(c => c.KnowledgeForWorkers);
                DB.KnowledgeForWorkers.Include(c => c.Candidate).ToList();
                DB.KnowledgeForWorkers.Include(c => c.Language).ToList();
                return await DB.Candidates.Include(c=>c.KnowledgeForWorkers).ToListAsync();
            }
            catch
            {
                throw new Exception("Database reference failed");
            }
        }
    }
}
