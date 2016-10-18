using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using System.Collections.Generic;
using RepoQuiz.Models;
using Moq;
using System.Data.Entity;
using System.Linq;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class StudentRepositoryTests
    {
        Mock<StudentContext> mock_context { get; set; }
        Mock<DbSet<Student>> mock_student_table { get; set; }
        List<Student> student_list { get; set; }
        StudentRepository repo { get; set; }

        public void ConnectMocksToDatastore()
        {
            var queryable_list = student_list.AsQueryable();

            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Provider).Returns(queryable_list.Provider);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Expression).Returns(queryable_list.Expression);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.ElementType).Returns(queryable_list.ElementType);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.GetEnumerator()).Returns(() => queryable_list.GetEnumerator());

            mock_context.Setup(c => c.Students).Returns(mock_student_table.Object);
        }

        [TestInitialize]
        public void Initialize()
        {
            mock_context = new Mock<StudentContext>();
            mock_student_table = new Mock<DbSet<Student>>();
            student_list = new List<Student>();
            repo = new StudentRepository(mock_context.Object);

            ConnectMocksToDatastore();
        }

        [TestCleanup]
        public void TearDown()
        {
            repo = null;
        }

        [TestMethod]
        public void CanCreateAnInstanceOfRepository()
        {
            StudentRepository repo = new StudentRepository();
            Assert.IsNotNull(repo);
        }

        [TestMethod]
        public void EnsureRepoHasContext()
        {
            StudentRepository repo = new StudentRepository();

            StudentContext actual_context = repo.Context;

            Assert.IsInstanceOfType(actual_context, typeof(StudentContext));
        }

        [TestMethod]
        public void EnsureStudentListIsEmpty()
        {
            List<Student> actual_students = repo.GetStudents();
            int expected_students_count = 0;
            int actual_students_count = actual_students.Count;

            // Assert
            Assert.AreEqual(expected_students_count, actual_students_count);
        }
    }
}
