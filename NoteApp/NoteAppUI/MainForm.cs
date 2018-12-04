using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (ListNotes.CurrentRow != null)
            {
                EditNoteForm form = new EditNoteForm();
                var temp = (Note)ListNotes.CurrentRow.DataBoundItem;
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
            if (ListNotes.CurrentRow != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить заметку?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    list.NotesList.Remove((Note)ListNotes.CurrentRow.DataBoundItem);
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

            categoryComboBox.SelectedIndex = 0;
            RefreshList();
        }

        private void editeNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void ListNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void ListNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListNotes.CurrentRow != null)
            {
                var note = (Note) ListNotes.CurrentRow.DataBoundItem;
                headderLabel.Text = note.Name;
                headderCategoryLabel.Text = note.Category.ToString();
                createdDateTimePicker.Value = note.TimeCreated;
                updatedDateTimePicker.Value = note.LastChangeTime;
                noteTextBox.Text = note.Text;
            }
        }

        private void updatedLabel_Click(object sender, EventArgs e)
        {

        }

        private void createdDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void createdLabel_Click(object sender, EventArgs e)
        {

        }

        private void headderCategoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoryHeadderLabelText_Click(object sender, EventArgs e)
        {

        }

        private void headderLabel_Click(object sender, EventArgs e)
        {

        }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void showCategorylabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
    
