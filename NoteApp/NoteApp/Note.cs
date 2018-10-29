using Newtonsoft.Json;
using System;
using System.Data;
using System.Dynamic;
using System.Runtime.CompilerServices;


namespace NoteApp


{
    /// <summary>
    /// Класс заметки,  с полями Название, Категория заметки, Текст заметки,
    /// Время создания, Время последнего изменения. 
    /// </summary>
    public class Note : ICloneable

    {
        [JsonProperty("TimeCreated")]
        public readonly DateTime TimeCreated;
        private DateTime _lastChangeTime;
        private string _name = "Без названия";
        private NoteCategory _noteCategory;
        private string _text;


        /// <summary>
        /// Создание заметки (с указанием времени создания)
        /// </summary>
        /// <param name="CreationTime">Дата созадния заметки</param>
        public Note(DateTime CreationTime)
        {
            if (CreationTime <= DateTime.Now)
            {
                TimeCreated = CreationTime;
                _lastChangeTime = CreationTime;
            }
            else
            {
                throw new ArgumentException("Некорректная дата!");
            }
        }

        /// <summary>
        /// Возвращает имя заметки
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if ((value.Length > 0) || (value.Length < 50))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Имя заметки должна быть больше 0 и меньше 50");
                }
            }

        }

        /// <summary>
        /// Возвращает текст заметки
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (value.Length > 0)
                {
                    _text = value;
                }
                else
                {
                    throw new ArgumentException("Текст заметки должен быть больше 0");
                }
            }
        }

        /// <summary>
        /// Возвращает категорию заметки
        /// </summary>
        public NoteCategory Category
        {
           get
            {
                return _noteCategory;
            }
            set
            {
                if (value >= 0)
                {
                    _noteCategory = value;
                }
                else
                {
                    throw new ArgumentException("Некорректная категория");
                }
            }
        }

        /// <summary>
        /// Возвращает время внесения последних изменений
        /// </summary>
        public DateTime LastChangeTime
        {
            get { return _lastChangeTime; }

            set
            {
                if (value <= DateTime.Now)
                {
                    _lastChangeTime = value;
                }
                else
                {
                    throw new ArgumentException("Дата изменения не может быть позже текущей даты.");
                }
            }
        }
        /// <summary>
        /// Клонирование объектов
        /// </summary>
        /// <returns>Возвращает копию данной записи</returns>
        public object Clone()
        {
            var newNote = new Note(TimeCreated);
            newNote.Name = _name;
            newNote.Text = _text;
            newNote.LastChangeTime = _lastChangeTime;
            newNote.Category = _noteCategory;
            return newNote;
        }

    }
}
