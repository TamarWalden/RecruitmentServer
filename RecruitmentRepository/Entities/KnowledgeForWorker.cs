using System;
using System.Collections.Generic;

#nullable disable

namespace RecruitmentRepository.Entities
{
    public partial class KnowledgeForWorker
    {
        public int CandidateId { get; set; }
        public int LanguageId { get; set; }
        public int? KnowledgeLevel { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Llanguage Language { get; set; }
    }
}
