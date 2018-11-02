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

        [Test(Description = "Позитивный тест Name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Валидное имя";
            _note.Name = expected;
            var actual = _note.Name;
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }
        
        [Test(Description = "Негативный тест Name")]
        public void TestNameGet_IncorrectValueLongerThan50Symbols()
        {
            var wrongName = "Ровно 51 символ ааааааааааааааааааааааааааааааааааа";
            Assert.Throws<ArgumentException>(() => { _note.Name = wrongName; },
                "Имя длиннее 50 символов");

        }

        [Test(Description = "Тест с нулевым значением в поле Name")]
        public void TestNameGet_IncorrectValue0Symbols()
        {
            var nullName = "";
            Assert.Throws<ArgumentException>(() => { _note.Name = nullName; },
                "Имя не может быть из нуля символов");
        }


        [Test(Description = "Позитивный тест сеттера Categoty")]
        public void TestCategotyGet_CorrectValue()
        {
            var expected = NoteCategory.Work;
            _note.Category = expected;
            var actual = _note.Category;
            Assert.AreEqual(expected, actual, "Сеттер Category возвращает неправильную категорию");

        }

        [Test(Description = "Позитивный тест Геттера Categoty")]
        public void TestCategotyGet_NullValue()
        {
            var expected = NoteCategory.Work;
            _note.Category = expected;
            var actual = _note.Category;
            Assert.AreEqual(expected, actual, "Сеттер Category возвращает неправильную категорию");
        }


        [Test(Description = "Негативный тест Text")]
        public void TestTextGet_IncorrectValue()
        {
            var NullText = "";
            Assert.Throws<ArgumentException>(() => { _note.Text = NullText; },
                "Текст не может быть из нуля символов");
        }

        [Test(Description = "Позитивный тест Text")]
        public void TestTextSet_CorrectValue()
        {
            var expected = "Текст";
            _note.Text = expected;
            var actual = _note.Text;
            Assert.AreEqual(expected, actual, "Сеттер Text возвращает неправильную категорию");
        }

        [TestCase("Геттер LastChangeTime возвращает неправильную дату",
            TestName = "Позитивный тест геттера DateChange")]
        [TestCase("Сеттер lastChangeTime записывает неправильную дату",
            TestName = "Позитивный тест сеттера DateChange")]
        public void TestDateChangeGetSet_CorrectValue(string message)
        {
            var expected = DateTime.Now;
            _note.LastChangeTime = expected;
            var actual = _note.LastChangeTime;
            Assert.AreEqual(expected, actual, message);
        }

        [Test(Description = "Негативный тест если LastChangeTime больше текущей даты")]
        public void TestDateChangeSet_LongerDateTimeNow()
        {
            var date = DateTime.Now;
            var wrongTitle = date.AddSeconds(1);
            Assert.Throws<ArgumentException>(
                () => { _note.LastChangeTime = wrongTitle; },
                "Должно возникнуть исключение, если длина LastChangeTime больше текущей даты");
        }

        [Test(Description = "Тест коструктора класса Note")]
        public void TestNoteConstructor_CorrectValue()
        {
            var actual = _note;
            Assert.AreEqual(_note.Name, actual.Name, "Неправильное значение в поле Name");
            Assert.AreEqual(_note.Category, actual.Category, "Неправильное значение в поле Category");
            Assert.AreEqual(_note.Text, actual.Text, "Неправильное значение в поле Text");
            Assert.AreEqual(_note.TimeCreated, actual.TimeCreated, "Неправильное значение в поле TimeCreated");
            Assert.AreEqual(_note.LastChangeTime, actual.LastChangeTime, "Неправильное значение в поле LastChangeTime");
        }

        [Test(Description = "Тест Clone в классе Note")]
        public void TestClone_CorrectValue()
        {
            _note.Text = "Заметка";
            var actual = (Note) _note.Clone();

            Assert.AreEqual(_note.Name, actual.Name, "Неправильное значение в поле Name");
            Assert.AreEqual(_note.Category, actual.Category, "Неправильное значение в поле Category");
            Assert.AreEqual(_note.Text, actual.Text, "Неправильное значение в поле Text");
            Assert.AreEqual(_note.TimeCreated, actual.TimeCreated, "Неправильное значение в поле TimeCreated");
            Assert.AreEqual(_note.LastChangeTime, actual.LastChangeTime, "Неправильное значение в поле LastChangeTime");
        }

    }
}
