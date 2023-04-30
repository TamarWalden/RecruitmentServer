using Services.Interfaces;
using Common.DTOs;
using AutoMapper;
using Repositories.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitmentRepository.Interfaces;
using RecruitmentRepository.Entities;

namespace Services.Services
{
    public class KnowledgeForWorkerService : IService<KnowledgeForWorkerDTO>
    {
        private readonly IRepository<KnowledgeForWorker> _LanguagePerCandidateRepository;
        private readonly IMapper _mapper;
        public KnowledgeForWorkerService(IRepository<KnowledgeForWorker> repository, IMapper mapper)
        {
            _LanguagePerCandidateRepository = repository;
            _mapper = mapper;
        }

        public async Task<List<KnowledgeForWorkerDTO>> GetAllAsync()
        {
            var newOne = await _LanguagePerCandidateRepository.GetAllAsync();
            return _mapper.Map<List<KnowledgeForWorkerDTO>>(newOne);
        }
    }
}
