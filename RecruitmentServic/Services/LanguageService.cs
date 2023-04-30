using Services.Interfaces;
using Common.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitmentRepository.Interfaces;
using RecruitmentRepository.Entities;

namespace Services.Services
{
    internal class LanguageService : IService<LlanguageDTO>
    {
        private readonly IRepository<Llanguage> _LanguageRepository;
        private readonly IMapper _mapper;
        public LanguageService(IRepository<Llanguage> repository, IMapper mapper)
        {
            _LanguageRepository = repository;
            _mapper = mapper;
        }

        public async Task<List<LlanguageDTO>> GetAllAsync()
        {
            var newOne = await _LanguageRepository.GetAllAsync();
            return _mapper.Map<List<LlanguageDTO>>(newOne);
        }
    }
}
