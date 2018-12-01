using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс - список всех заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список всех заметок
        /// </summary>
        public List<Note> NotesList;

        /// <summary>
        /// Конструктор класса Project
        /// </summary>
        public Project()
        {
            NotesList = new List<Note>();
        }

        //Текущая заметка.
        public Note CurrentNote = null;


        /// <summary>
        /// Сортировка по выбранной категории
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<Note> Sort(int category)
        {
            if (category == 0)
            {
                return Sort();
            }
            else
            {
                return Sort().FindAll(a => a.Category == (NoteCategory)category);
            }
        }

        /// <summary>
        /// Сортировка списка по дате изменения.
        /// </summary>
        /// <returns>Список заметок.</returns>
        public List<Note> Sort()
        {
            var list = NotesList;
            list.Sort((a, b) =>
            {
                if (a.LastChangeTime > b.LastChangeTime)
                    return -1;
                return 1;
            });
            return list;
        }
    }
}
