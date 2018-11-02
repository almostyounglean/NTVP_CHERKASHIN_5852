using System;
using System.Linq;
using NUnit.Framework;



namespace NoteApp.UnitTests
{
    class ProjectTests
    {
        [TestFixture]
        public class ProjectTest
        {
            [Test(Description = "Позитивный тест добавления элемента в список")]
            public void TestProjectListAdd_CorrectValue()
            {
                Note note = new Note(DateTime.Now);
                note.Text = "Valid";
                var project = new Project();
                project.NotesList.Add(note);
                var actual = project.NotesList.First();
                Assert.AreEqual(note, actual, "Project возвращает неправильное значение");
            }

        }
    }
}
