using AutoMapper;
using Common.DTOs;
using RecruitmentRepository.Entities;
using RecruitmentRepository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Services
{
    public class CandidateService : IService<CandidateDTO>
    {
        private readonly IRepository<Candidate> _CandidateRepository;
        private readonly IMapper _mapper;
        public CandidateService(IRepository<Candidate> repository, IMapper mapper)
        {
            _CandidateRepository = repository;
            _mapper = mapper;
        }

        public async Task<List<CandidateDTO>> GetAllAsync()
        {
            var newOne = await _CandidateRepository.GetAllAsync();
            return _mapper.Map<List<CandidateDTO>>(newOne);
        }

        public async Task<List<CandidateDTO>> GetAllMatchByLanguageAndLevel(LlanguageDTO language, int yearStartWork)
        {
            //if (junior == true)
            //    return Db.candidatesList.FindAll(candidate => candidate.languages.Find(l => l.id == languageId) != null && DateTime.Today.Year - candidate.yearOfStartWork > 3).OrderByDescending(candidate => candidate.lastUpdateDetails);
            //return Db.candidatesList.FindAll(candidate => candidate.languages.Find(l => l.id == languageId) != null && DateTime.Today.Year - candidate.yearOfStartWork <= 3).OrderByDescending(candidate => candidate.lastUpdateDetails);
            //var newOne = await _CandidateRepository.GetAllAsync().Result.FindAll(candidate => candidate.languages.Find(l => l.id == languageId) != null && DateTime.Today.Year - candidate.yearOfStartWork > 3).OrderByDescending(candidate => candidate.lastUpdateDetails); ;
            throw new NotImplementedException();
        }
    }
}
