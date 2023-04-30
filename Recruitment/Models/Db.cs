using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.Models
{
    public class Db
    {
        public static List<Candidate> candidatesList;
        public static List<Language> languagesList;
        static Db()
        {
            languagesList = new List<Language>()
            {
                new Language(1, "Java"),
                new Language(2, ".Net"),
                new Language(3, "NodeJS"),
                new Language(4, "Advanced Vanilla JS"),
                new Language(5, "React"),
                new Language(6, "Angular"),
                new Language(7, "Kotlin"),
                new Language(8, "Dart"),
                new Language(9, "Flutter")
            };

            candidatesList = new List<Candidate>()
            {
                new Candidate(1,"Moshe",2020,new DateTime(2022,11,3),new List<Language>(){languagesList[0],languagesList[1] }),
                new Candidate(20,"Avi",2020,new DateTime(2021,9,27),new List<Language>(){ languagesList[0],languagesList[2] }),
                new Candidate(300,"Gila",2023,new DateTime(2023-01-01),new List<Language>(){languagesList[1],languagesList[3],languagesList[6] }),
                new Candidate(301,"Rina",2019,new DateTime(2021-05-17),new List<Language>(){languagesList[1],languagesList[2],languagesList[5] }),
                new Candidate(1,"Moshe",2020,new DateTime(2022-11-03),new List<Language>()),
            };
        }
    }
}
