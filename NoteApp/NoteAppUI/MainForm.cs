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
       
        private void addNoteButton_Click(object sender, EventArgs e)
        {
            EditNoteForm form = new EditNoteForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                list.NotesList.Add(form.Note);
                RefreshList();
            }
        }

        /// <summary>
       /// Реализация метода обновления листа с заметками
       /// </summary>

        private void RefreshList()
        {
            ListNotes.DataSource = null;
            ListNotes.DataSource = list.NotesList;
            ProjectManager.Save(list, "notes.notes");
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
            if (!File.Exists("notes.notes"))
            {
                list = new Project();
                ProjectManager.Save(list,"notes.notes");
            }
            else
            {
                list = ProjectManager.Load("notes.notes");
            }
            RefreshList();
        }

        private void editeNoteButton_Click(object sender, EventArgs e)
        {
            if (ListNotes.CurrentRow!=null)
            {
                EditNoteForm form = new EditNoteForm();
                form.Note = (Note) ListNotes.CurrentRow.DataBoundItem;
                Note temp = (Note)form.Note.Clone();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    for(var i=0;i<list.NotesList.Count;i++)
                    {
                        if (list.NotesList[i] == temp)
                        {
                            list.NotesList[i] = form.Note;
                        }
                    }
                    RefreshList();
                }
            }

        }

        private void ListNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            if (ListNotes.CurrentRow != null)
            {
                list.NotesList.Remove((Note) ListNotes.CurrentRow.DataBoundItem);
                
                RefreshList();
            }
        }

        private void ListNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListNotes.CurrentRow != null)
            {
                var note = (Note)ListNotes.CurrentRow.DataBoundItem;
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
    }
}
