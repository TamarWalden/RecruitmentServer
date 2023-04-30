using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
    public class CandidateDTO
    {
        public CandidateDTO()
        {
            KnowledgeForWorkers = new List<KnowledgeForWorkerDTO>();
        }
        public int Id { get; set; }
        public string CandidateName { get; set; } = null!;
        public string? YearOfStartWork { get; set; }
        public DateTime? LastUpdateDetails { get; set; }

        public List<KnowledgeForWorkerDTO> KnowledgeForWorkers { get; set; }
    }
}