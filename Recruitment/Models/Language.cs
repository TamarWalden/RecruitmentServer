using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.Models
{
    public class Language
    {
        public Language(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public int id { get; set; }
        public String name { get; set; }
    }
}
