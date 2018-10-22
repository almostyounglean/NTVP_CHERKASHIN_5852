using System;
using System.Drawing;
using NoteApp;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class EditNoteForm : Form
    {
        public Note Note;

        public EditNoteForm()
        {
            InitializeComponent();
        }

        private void EditNoteForm_Load(object sender, System.EventArgs e)
        {
            if (Note == null)
            {
                Note = new Note(DateTime.Now);
            }
            titleTextBox.Text = Note.Name;
            CreatedDateTimePicker.Value = Note.TimeCreated;
            UpdatedDateTimePicker.Value = Note.LastChangeTime;
            noteTextBox.Text = Note.Text;
            CategoryComboBox.SelectedIndex = (int)Note.Category;
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            try
            {
                Note.Name = titleTextBox.Text;
                Note.LastChangeTime = DateTime.Now;
                Note.Text = noteTextBox.Text;
                Note.Category = (NoteCategory) CategoryComboBox.SelectedIndex;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Note.Name.Length > 50)
            {
                titleTextBox.BackColor = Color.LightSalmon;
            }
            else
            {
                titleTextBox.BackColor = Color.White;
            }
        }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

