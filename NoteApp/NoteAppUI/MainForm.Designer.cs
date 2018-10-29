namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCategorylabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.headderLabel = new System.Windows.Forms.Label();
            this.categoryHeadderLabelText = new System.Windows.Forms.Label();
            this.headderCategoryLabel = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.createdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updatedLabel = new System.Windows.Forms.Label();
            this.editeNoteButton = new System.Windows.Forms.Button();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.ListNotes = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastChangeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.deleteNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // deleteNoteToolStripMenuItem
            // 
            this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            this.deleteNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteNoteToolStripMenuItem.Text = "Delete Note";
            this.deleteNoteToolStripMenuItem.Click += new System.EventHandler(this.deleteNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // showCategorylabel
            // 
            this.showCategorylabel.AutoSize = true;
            this.showCategorylabel.Location = new System.Drawing.Point(16, 39);
            this.showCategorylabel.Name = "showCategorylabel";
            this.showCategorylabel.Size = new System.Drawing.Size(78, 13);
            this.showCategorylabel.TabIndex = 1;
            this.showCategorylabel.Text = "Show category";
            this.showCategorylabel.Click += new System.EventHandler(this.showCategorylabel_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(101, 39);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(104, 21);
            this.categoryComboBox.TabIndex = 2;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // headderLabel
            // 
            this.headderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headderLabel.Location = new System.Drawing.Point(251, 26);
            this.headderLabel.Name = "headderLabel";
            this.headderLabel.Size = new System.Drawing.Size(531, 22);
            this.headderLabel.TabIndex = 8;
            this.headderLabel.Text = "PlaceHolder";
            this.headderLabel.Click += new System.EventHandler(this.headderLabel_Click);
            // 
            // categoryHeadderLabelText
            // 
            this.categoryHeadderLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryHeadderLabelText.AutoSize = true;
            this.categoryHeadderLabelText.Location = new System.Drawing.Point(252, 50);
            this.categoryHeadderLabelText.Name = "categoryHeadderLabelText";
            this.categoryHeadderLabelText.Size = new System.Drawing.Size(52, 13);
            this.categoryHeadderLabelText.TabIndex = 9;
            this.categoryHeadderLabelText.Text = "Category:";
            this.categoryHeadderLabelText.Click += new System.EventHandler(this.categoryHeadderLabelText_Click);
            // 
            // headderCategoryLabel
            // 
            this.headderCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headderCategoryLabel.AutoSize = true;
            this.headderCategoryLabel.Location = new System.Drawing.Point(310, 50);
            this.headderCategoryLabel.Name = "headderCategoryLabel";
            this.headderCategoryLabel.Size = new System.Drawing.Size(63, 13);
            this.headderCategoryLabel.TabIndex = 10;
            this.headderCategoryLabel.Text = "Placeholder";
            this.headderCategoryLabel.Click += new System.EventHandler(this.headderCategoryLabel_Click);
            // 
            // createdLabel
            // 
            this.createdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(602, 48);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(47, 13);
            this.createdLabel.TabIndex = 11;
            this.createdLabel.Text = "Created:";
            this.createdLabel.Click += new System.EventHandler(this.createdLabel_Click);
            // 
            // createdDateTimePicker
            // 
            this.createdDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createdDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.createdDateTimePicker.Enabled = false;
            this.createdDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createdDateTimePicker.Location = new System.Drawing.Point(655, 44);
            this.createdDateTimePicker.MaximumSize = new System.Drawing.Size(75, 20);
            this.createdDateTimePicker.MinimumSize = new System.Drawing.Size(75, 20);
            this.createdDateTimePicker.Name = "createdDateTimePicker";
            this.createdDateTimePicker.Size = new System.Drawing.Size(75, 20);
            this.createdDateTimePicker.TabIndex = 12;
            this.createdDateTimePicker.ValueChanged += new System.EventHandler(this.createdDateTimePicker_ValueChanged);
            // 
            // updatedDateTimePicker
            // 
            this.updatedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatedDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.updatedDateTimePicker.Enabled = false;
            this.updatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.updatedDateTimePicker.Location = new System.Drawing.Point(510, 44);
            this.updatedDateTimePicker.MaximumSize = new System.Drawing.Size(75, 20);
            this.updatedDateTimePicker.MinimumSize = new System.Drawing.Size(75, 20);
            this.updatedDateTimePicker.Name = "updatedDateTimePicker";
            this.updatedDateTimePicker.Size = new System.Drawing.Size(75, 20);
            this.updatedDateTimePicker.TabIndex = 14;
            // 
            // updatedLabel
            // 
            this.updatedLabel.AutoSize = true;
            this.updatedLabel.Location = new System.Drawing.Point(453, 48);
            this.updatedLabel.Name = "updatedLabel";
            this.updatedLabel.Size = new System.Drawing.Size(51, 13);
            this.updatedLabel.TabIndex = 13;
            this.updatedLabel.Text = "Updated:";
            this.updatedLabel.Click += new System.EventHandler(this.updatedLabel_Click);
            // 
            // editeNoteButton
            // 
            this.editeNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editeNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("editeNoteButton.Image")));
            this.editeNoteButton.Location = new System.Drawing.Point(43, 414);
            this.editeNoteButton.Name = "editeNoteButton";
            this.editeNoteButton.Size = new System.Drawing.Size(22, 22);
            this.editeNoteButton.TabIndex = 5;
            this.editeNoteButton.UseVisualStyleBackColor = true;
            this.editeNoteButton.Click += new System.EventHandler(this.editeNoteButton_Click);
            // 
            // addNoteButton
            // 
            this.addNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("addNoteButton.Image")));
            this.addNoteButton.Location = new System.Drawing.Point(12, 414);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(25, 22);
            this.addNoteButton.TabIndex = 4;
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // ListNotes
            // 
            this.ListNotes.AllowUserToAddRows = false;
            this.ListNotes.AllowUserToDeleteRows = false;
            this.ListNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListNotes.AutoGenerateColumns = false;
            this.ListNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListNotes.ColumnHeadersVisible = false;
            this.ListNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.lastChangeTimeDataGridViewTextBoxColumn});
            this.ListNotes.DataSource = this.noteBindingSource;
            this.ListNotes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListNotes.Location = new System.Drawing.Point(12, 66);
            this.ListNotes.MultiSelect = false;
            this.ListNotes.Name = "ListNotes";
            this.ListNotes.ReadOnly = true;
            this.ListNotes.RowHeadersVisible = false;
            this.ListNotes.Size = new System.Drawing.Size(223, 342);
            this.ListNotes.TabIndex = 15;
            this.ListNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListNotes_CellClick);
            this.ListNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListNotes_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            this.textDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastChangeTimeDataGridViewTextBoxColumn
            // 
            this.lastChangeTimeDataGridViewTextBoxColumn.DataPropertyName = "LastChangeTime";
            this.lastChangeTimeDataGridViewTextBoxColumn.HeaderText = "LastChangeTime";
            this.lastChangeTimeDataGridViewTextBoxColumn.Name = "lastChangeTimeDataGridViewTextBoxColumn";
            this.lastChangeTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastChangeTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(NoteApp.Note);
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteNoteButton.Image")));
            this.deleteNoteButton.Location = new System.Drawing.Point(70, 414);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(24, 22);
            this.deleteNoteButton.TabIndex = 6;
            this.deleteNoteButton.UseVisualStyleBackColor = true;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextBox.Enabled = false;
            this.noteTextBox.Location = new System.Drawing.Point(241, 66);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(583, 342);
            this.noteTextBox.TabIndex = 7;
            this.noteTextBox.TextChanged += new System.EventHandler(this.noteTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 452);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.ListNotes);
            this.Controls.Add(this.updatedDateTimePicker);
            this.Controls.Add(this.updatedLabel);
            this.Controls.Add(this.createdDateTimePicker);
            this.Controls.Add(this.createdLabel);
            this.Controls.Add(this.headderCategoryLabel);
            this.Controls.Add(this.categoryHeadderLabelText);
            this.Controls.Add(this.headderLabel);
            this.Controls.Add(this.deleteNoteButton);
            this.Controls.Add(this.editeNoteButton);
            this.Controls.Add(this.addNoteButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.showCategorylabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(736, 300);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label showCategorylabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.Button editeNoteButton;
        private System.Windows.Forms.Label headderLabel;
        private System.Windows.Forms.Label categoryHeadderLabelText;
        private System.Windows.Forms.Label headderCategoryLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.DateTimePicker createdDateTimePicker;
        private System.Windows.Forms.DateTimePicker updatedDateTimePicker;
        private System.Windows.Forms.Label updatedLabel;
        private System.Windows.Forms.DataGridView ListNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastChangeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private System.Windows.Forms.Button deleteNoteButton;
        private System.Windows.Forms.TextBox noteTextBox;
    }
}