using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.Models
{
    public class Candidate
    {
        public Candidate(int id, String name, int yearOfStartWork, DateTime lastUpdateDetails, List<Language> languages)
        {
            this.id = id;
            this.name = name;
            this.yearOfStartWork = yearOfStartWork;
            this.lastUpdateDetails = lastUpdateDetails;
            this.languages = languages;
        }
        public int id { get; set; }
        public string name { get; set; }
        public int? yearOfStartWork { get; set; }
        public DateTime? lastUpdateDetails { get; set; }
        public List<Language> languages { get; set; }

    }
}
