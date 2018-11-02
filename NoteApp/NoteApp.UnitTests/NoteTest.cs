using System;
using NUnit.Framework;


namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;

        [SetUp]
        public void InitNote()
        {
            _note = new Note(DateTime.Now);
        }

        [Test(Description = "Позитивный тест геттера Name")]
        public void TestTitleGet_CorrectValue()
        {
            var Title = "Заметка";
            _note.Name = Title;
            var actual = _note.Name;
            Assert.AreEqual(Title, actual, "Геттер Name возвращает неправильное значение");
        }
        [Test(Description = "Позитивный тест cеттера Name")]
        public void TestTitleSet_CorrectValue()
        {
            var Title = "Заметка";
            _note.Name = Title;

            var NewTitle = "Заметка";
            var actual = _note.Name;
            Assert.AreEqual(NewTitle, actual, "Сеттер Name задает неверное значение");
        }
        [Test(Description = "Проверка на заголовок, длиной больше 50.")]
        public void TestTitleSet_Longer50()
        {
            var wrongTitle = "ЗаметкаЗаметкаЗаметкаЗаметкаЗаметкаЗаметкаЗаметкаЗаметкаЗаметкаЗаметка";
            Assert.Throws<ArgumentException>(() => { _note.Name = wrongTitle; }, "Должно возникать исключение, если длина заголовка длиннее 50 символов");
        }
        
        [Test(Description = "Позитивный тест геттера Text")]
        public void TestTextGet_CorrectValue()
        {
            var Text = "Заметка";
            _note.Text = Text;
            var actual = _note.Text;
            Assert.AreEqual(Text, actual, "Геттер Text возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест cеттера Text")]
        public void TestTextSet_CorrectValue()
        {
            var text = "Заметка";
            _note.Text = text;

            var NewText = "Заметка";
            var actual = _note.Text;
            Assert.AreEqual(NewText, actual, "Сеттер Text задает неверное значение");
        }
        [Test(Description = "Проверка текста, длиной равной 0.")]
        public void TestTextSet_Equal0()
        {
            var wrongText = "";
            Assert.Throws<ArgumentException>(() => { _note.Text = wrongText; }, "Должно возникать исключение, если длина текста равно 0");
        }
        [Test(Description = "Позитивный тест геттера Category")]
        public void TestCategoryGet_CorrectValue()
        {
            var Text = NoteCategory.Home;
            _note.Category = Text;
            var actual = _note.Category;
            Assert.AreEqual(Text, actual, "Геттер Category возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест cеттера Category")]
        public void TestCategorySet_CorrectValue()
        {
            var category = NoteCategory.Home;
            _note.Category = category;

            var newCategory = NoteCategory.Home;
            var actual = _note.Category;
            Assert.AreEqual(newCategory, actual, "Сеттер Category задает неверное значение");
        }
     
        [Test(Description = "Позитивный тест геттера NoteCreated")]
        public void TestNoteCreatedGet_CorrectValue()
        {
            var time = DateTime.Now;
            var actual = _note.TimeCreated;
            Assert.AreEqual(time, actual, "Геттер TimeCreated возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест геттера LastChangeTime")]
        public void TestNoteChangedGet_CorrectValue()
        {
            var time = DateTime.Now;
            var actual = _note.LastChangeTime;
            Assert.AreEqual(time, actual, "Геттер LastChangeTime возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест сеттера LastChangeTime")]
        public void TestNoteChangedSet_CorrectValue()
        {
            var time = DateTime.Now;
            _note.LastChangeTime = time;
            var current = _note.LastChangeTime;
            Assert.AreEqual(time, current, "Сеттер LastChangeTime возвращает неправильное значение");
        }

        [Test(Description = "Дата изменения больше, чем текущая дата")]
        public void TestNoteChangedSet_LongerCurrentDate()
        {
            var time = DateTime.Now;
            time = time.AddDays(100);
            Assert.Throws<ArgumentException>(() => { _note.LastChangeTime = time; }, "Должно возникать исключение, если дата изменения больше, чем текущая.");
        }

        [Test(Description = "Дата создания больше, чем текущая дата")]
        public void TestNoteCreatedSet_LongerCurrentDate()
        {
            var time = DateTime.Now;
            time = time.AddDays(100);
            Assert.Throws<ArgumentException>(() => { var note = new Note(time); }, "Должно возникать исключение, если дата создания больше, чем текущая.");
        }

        [Test(Description = "Позитивный тест Clone()")]
        public void TestClone_CorrectValue()
        {
            var note = new Note(DateTime.Now);
            note.Text = "Заметка";
            Note clone = (Note)note.Clone();
            Assert.AreEqual(note.ToString(), clone.ToString(), "Метод Clone возвращает неверное значение.");
        }

    

    }
}
