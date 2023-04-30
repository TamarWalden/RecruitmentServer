using Common.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruitment.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        readonly IService<CandidateDTO> _service;
        public CandidateController(IService<CandidateDTO> service)
        {
            _service = service;
        }
        [Route("GetAllCandidates")]
        [HttpGet]
        public async Task<IEnumerable<Candidate>> GetCandidates()
        {
            //return (IEnumerable<Candidate>)Ok(await _service.GetAllAsync());
            return Db.candidatesList;
        }

        [Route("GetAllLanguages")]
        [HttpGet]
        public async Task<IEnumerable<Language>> GetLanguages()
        {
            return Db.languagesList;
        }

        [Route("GetAllMatchCandidates")]
        [HttpGet]
        public async Task<IEnumerable<Candidate>> GetAllMatchCandidates(int languageId, Boolean junior)
        {
            //כדאי לעשות בביטוי למבדא
            if (junior == true)
                return Db.candidatesList.FindAll(candidate => candidate.languages.Find(l => l.id == languageId) != null && DateTime.Today.Year - candidate.yearOfStartWork > 3).OrderByDescending(candidate => candidate.lastUpdateDetails);
            return Db.candidatesList.FindAll(candidate => candidate.languages.Find(l => l.id == languageId) != null && DateTime.Today.Year - candidate.yearOfStartWork <= 3).OrderByDescending(candidate => candidate.lastUpdateDetails);
        }
    }
}
