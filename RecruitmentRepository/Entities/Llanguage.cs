using System;
using System.Collections.Generic;

#nullable disable

namespace RecruitmentRepository.Entities
{
    public partial class Llanguage
    {
        public Llanguage()
        {
            KnowledgeForWorkers = new HashSet<KnowledgeForWorker>();
        }

        public int Id { get; set; }
        public string LanguageName { get; set; }

        public virtual ICollection<KnowledgeForWorker> KnowledgeForWorkers { get; set; }
    }
}
