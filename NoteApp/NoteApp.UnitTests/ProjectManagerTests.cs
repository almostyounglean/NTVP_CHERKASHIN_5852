using NUnit.Framework;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using Assert = NUnit.Framework.Assert;
using CollectionAssert = NUnit.Framework.CollectionAssert;
using System.Linq;

namespace NoteApp.UnitTests
{
    class ProjectManagerTests
    {
        [TestFixture]
        public class ProjectManagerTest
        {
            [Test(Description = "Позитивный тест сериализации. Сохранение")]
            public void TestProjectManagerSaveTToFile_CorrectValue()
            {
                Note note = new Note(DateTime.Now);
                note.Text = "aw";
                var project = new Project();
                project.NotesList.Add(note);
                ProjectManager.Save(project, "C:\\Users\\nikit\\file.txt");

                var actual = ProjectManager.Load("C:\\Users\\nikit\\file.txt").NotesList.Last();
                Assert.AreEqual(note.Text, actual.Text, "Сериализация работает неверно!");
            }
            [Test(Description = "Сохранение в неверный путь.")]
            public void TestProjectManagerSaveToFile_NotCorrectPath()
            {
                Note note = new Note(DateTime.Now);
                note.Text = "aw";
                var project = new Project();
                project.NotesList.Add(note);
                Assert.Throws<System.IO.IOException>(() => { ProjectManager.Save(project, "c:\\distribution\\"); }, "Должно возникать исключение, если путь неверен.");
            }
            [Test(Description = "Открытие из неверного пути.")]
            public void TestProjectManagerLoadFromFile_NotCorrectPath()
            {
                Assert.Throws<System.IO.FileNotFoundException>(() => { var project = ProjectManager.Load("c:\\distribution\\"); }, "Должно возникать исключение, если путь неверен.");
            }

            [Test(Description = "Открытие испорченного файла пути.")]
            public void TestProjectManagerLoadFromFile_NotCorrectFile()
            {
                var text = "I not correct file";
                var fileName = "C:\\Users\\nikit\\broken.txt";
                File.WriteAllText(fileName, text);
                Assert.Throws<JsonReaderException>(() => { var project = ProjectManager.Load(fileName); }, "Должно возникать исключение, если файл испорчен.");
            }

        }
    }
}
