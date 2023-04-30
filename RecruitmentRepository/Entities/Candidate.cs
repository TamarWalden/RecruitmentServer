using System;
using System.Collections.Generic;

#nullable disable

namespace RecruitmentRepository.Entities
{
    public partial class Candidate
    {
        public Candidate()
        {
            KnowledgeForWorkers = new HashSet<KnowledgeForWorker>();
        }

        public int Id { get; set; }
        public string CandidateName { get; set; }
        public int? YearOfStartWork { get; set; }
        public DateTime? LastUpdateDetails { get; set; }

        public virtual ICollection<KnowledgeForWorker> KnowledgeForWorkers { get; set; }
    }
}
