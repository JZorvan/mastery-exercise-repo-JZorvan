namespace RepoQuiz.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RepoQuiz.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepoQuiz.DAL.StudentContext context)
        {
            context.Students.AddOrUpdate(
                s = s.StudentID,
                    new Student { FirstName = "Agnes", LastName = "Butts", Major = "Underwater Basket Weaving" },
                    new Student { FirstName = "Ethel", LastName = "Hitler", Major = "Cannibis Agriculture" },
                    new Student { FirstName = "Mildred", LastName = "Hooker", Major = "Fermentation Sciences" },
                    new Student { FirstName = "Bertha", LastName = "Boner", Major = "Auctioneering" },
                    new Student { FirstName = "Gertrude", LastName = "Wang", Major = "Canadian Studies" },
                    new Student { FirstName = "Dick", LastName = "Head", Major = "Jazz Hands" },
                    new Student { FirstName = "Angus", LastName = "Trumpizievil", Major = "Pupperty" },
                    new Student { FirstName = "Herman", LastName = "McUgly", Major = "Kitten Management" },
                    new Student { FirstName = "Mortimer", LastName = "Fuchs", Major = "Confection Distribution by Van" },
                    new Student { FirstName = "Rupert", LastName = "Dickfloss", Major = "Petting Doggies" }
                );
        }
    }
}
