using System;
using System.IO;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        public Project list;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод добавления заметки
        /// </summary>
        private void AddNote()
        {
            EditNoteForm form = new EditNoteForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                list.NotesList.Add(form.Note);
                RefreshList();
            }
        }

        /// <summary>
        /// Метод редактирования заметки
        /// </summary>
        private void EditNote()
        {
            if (ListNotes.SelectedItem != null)
            {
                EditNoteForm form = new EditNoteForm();
                var temp = (Note)ListNotes.SelectedItem;
                form.Note = (Note)temp.Clone();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    temp = form.Note;

                    RefreshList();
                }
            }

        }

        /// <summary>
        /// Метод удаления заметки
        /// </summary>
        private void RemoveNote()
        {
            if (ListNotes.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить заметку?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    list.NotesList.Remove((Note)ListNotes.SelectedItem);
                    RefreshList();
                }
              
            }

        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Реализация метода обновления листа с заметками
        /// </summary>
        private void RefreshList()
        {
            ListNotes.DataSource = null;
            ListNotes.DataSource = list.Sort(categoryComboBox.SelectedIndex);
            ListNotes.DisplayMember = "Name";
            ProjectManager.Save(list, ProjectManager._defaultPath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ProjectManager._defaultPath))
            {
                list = new Project();
                ProjectManager.Save(list, ProjectManager._defaultPath);
            }
            else
            {
                list = ProjectManager.Load(ProjectManager._defaultPath);
            }

            RefreshList();
            categoryComboBox.SelectedIndex = 0;
        }

        private void editeNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void ListNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListNotes.SelectedItem != null)
            {
                var note = (Note)ListNotes.SelectedItem;
                headderLabel.Text = note.Name;
                headderCategoryLabel.Text = note.Category.ToString();
                createdDateTimePicker.Value = note.TimeCreated;
                updatedDateTimePicker.Value = note.LastChangeTime;
                noteTextBox.Text = note.Text;
            }
        }

        private void ListNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveNote();
            }   
        }
    }
}
    
