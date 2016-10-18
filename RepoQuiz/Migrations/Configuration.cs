namespace RepoQuiz.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RepoQuiz.Models;
    using RepoQuiz.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepoQuiz.DAL.StudentContext context)
        {
            NameGenerator NameGen = new NameGenerator();

            Student Student01 = NameGen.RandomizedStudent();
            Student Student02 = NameGen.RandomizedStudent();
            Student Student03 = NameGen.RandomizedStudent();
            Student Student04 = NameGen.RandomizedStudent();
            Student Student05 = NameGen.RandomizedStudent();
            Student Student06 = NameGen.RandomizedStudent();
            Student Student07 = NameGen.RandomizedStudent();
            Student Student08 = NameGen.RandomizedStudent();
            Student Student09 = NameGen.RandomizedStudent();
            Student Student10 = NameGen.RandomizedStudent();

            context.Students.AddOrUpdate(s => s.LastName,
                Student01, Student02, Student03, Student04, Student05, Student06, Student07, Student08, Student09, Student10);
        }
    }
}
