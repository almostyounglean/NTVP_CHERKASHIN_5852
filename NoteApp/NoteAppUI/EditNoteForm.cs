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
                CategoryComboBox.SelectedIndex = 0;
            }
            else
            {
                CategoryComboBox.SelectedIndex = (int)(Note.Category - 1);
            }
            titleTextBox.Text = Note.Name;
            CreatedDateTimePicker.Value = Note.TimeCreated;
            UpdatedDateTimePicker.Value = Note.LastChangeTime;
            noteTextBox.Text = Note.Text;
            
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Note.Name = titleTextBox.Text;
                Note.LastChangeTime = DateTime.Now;
                Note.Text = noteTextBox.Text;
                Note.Category = (NoteCategory)(CategoryComboBox.SelectedIndex + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (titleTextBox.Text.Length > 50)
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
            if (noteTextBox.Text.Length > 200)
            {
                titleTextBox.BackColor = Color.LightSalmon;
            }
            else
            {
                titleTextBox.BackColor = Color.White;
            }
        }

        private void updatedLabel_Click(object sender, EventArgs e)
        {

        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


