using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
    public class KnowledgeForWorkerDTO
    {
        public int CandidateId { get; set; }
        public int LanguageId { get; set; }
        public int? KnowledgeLevel { get; set; }
    }
}
