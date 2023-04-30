using AutoMapper;
using Common.DTOs;
using RecruitmentRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Candidate, CandidateDTO>().ReverseMap();
            CreateMap<Llanguage, LlanguageDTO>().ReverseMap();
            CreateMap<KnowledgeForWorker, KnowledgeForWorkerDTO>().ReverseMap();
        }
    }
}
