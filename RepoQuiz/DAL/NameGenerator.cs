using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepoQuiz.Migrations;
using RepoQuiz.Models;

namespace RepoQuiz.DAL
{
    public class NameGenerator
    {
        StudentRepository Repo = new StudentRepository();
        Random Random = new Random();

        private List<string> FirstNames = new List<string>
        {
            "Agnes", "Ethel", "Milred", "Bertha", "Gertrude", "Helga", "Agatha", "Beulah", "Winifred", "Prudence", "Dick", "Angus", "Herman", "Mortimer", "Rupert", "Wilbur", "Sherman", "Eugene", "Orson", "Herbert"
        };

        private List<string> LastNames = new List<string>
        {
            "Butts", "Hitler", "Hooker", "Boner", "Wang", "Head", "Trumpizievil", "McUgly", "Fuchs", "Dickfloss", "Dumfarht", "Suk", "Mangina", "Stroker", "Dorkoff", "Short", "Buttsavage", "Wiener", "Cox", "Poon"
        };

        private List<string> Majors = new List<string>
        {
            "Underwater Basket Weaving", "Cannibis Agriculture", "Fermentation Sciences", "Auctioneering", "Canadian Studies", "Full Contact Jazz Hands", "Puppetry", "Kitten Management", "Confection Distribution by Van", "Petting Doggies", "Fuckery", "Extraterrestrial Diplomacy", "Bagpipe", "Script Writing for Silent Film", "Competative Sneezing", "Arson", "Dumpster Fire Strategy", "Power Napping", "Blanket Fort Construction", "Revenge"
        };

        public Student RandomizedStudent()
        {
            int randoNumber1 = Random.Next(0, 19);
            int randoNumber2 = Random.Next(0, 19);
            int randoNumber3 = Random.Next(0, 19);

            Student randomStudent = new Student();
            randomStudent.FirstName = FirstNames[randoNumber1];
            randomStudent.LastName= LastNames[randoNumber2];
            randomStudent.Major = Majors[randoNumber3];

            return randomStudent;
        }
    }
}