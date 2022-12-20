namespace Course_İntro
{
    partial class MainView
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
            System.Windows.Forms.Button button_addStudent;
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_maidenName = new System.Windows.Forms.TextBox();
            this.listView_students = new System.Windows.Forms.ListView();
            this.button_deleted = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_saveAfterEdit = new System.Windows.Forms.Button();
            button_addStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_addStudent
            // 
            button_addStudent.Location = new System.Drawing.Point(11, 235);
            button_addStudent.Name = "button_addStudent";
            button_addStudent.Size = new System.Drawing.Size(100, 23);
            button_addStudent.TabIndex = 0;
            button_addStudent.Text = "Add Student";
            button_addStudent.UseVisualStyleBackColor = true;
            button_addStudent.Click += new System.EventHandler(this.Button_addStudent_Click);
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(12, 30);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(100, 23);
            this.textBox_firstName.TabIndex = 1;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(12, 74);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 23);
            this.textBox_lastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Location = new System.Drawing.Point(11, 118);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(101, 23);
            this.comboBox_gender.TabIndex = 6;
            this.comboBox_gender.SelectedIndexChanged += new System.EventHandler(this.ComboBox_gender_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maiden Name";
            // 
            // textBox_maidenName
            // 
            this.textBox_maidenName.Enabled = false;
            this.textBox_maidenName.Location = new System.Drawing.Point(12, 162);
            this.textBox_maidenName.Name = "textBox_maidenName";
            this.textBox_maidenName.Size = new System.Drawing.Size(100, 23);
            this.textBox_maidenName.TabIndex = 8;
            // 
            // listView_students
            // 
            this.listView_students.Location = new System.Drawing.Point(551, 12);
            this.listView_students.MultiSelect = false;
            this.listView_students.Name = "listView_students";
            this.listView_students.Size = new System.Drawing.Size(237, 224);
            this.listView_students.TabIndex = 9;
            this.listView_students.UseCompatibleStateImageBehavior = false;
            this.listView_students.View = System.Windows.Forms.View.List;
            // 
            // button_deleted
            // 
            this.button_deleted.Location = new System.Drawing.Point(551, 242);
            this.button_deleted.Name = "button_deleted";
            this.button_deleted.Size = new System.Drawing.Size(75, 23);
            this.button_deleted.TabIndex = 10;
            this.button_deleted.Text = "Deleted";
            this.button_deleted.UseVisualStyleBackColor = true;
            this.button_deleted.Click += new System.EventHandler(this.Button_deleted_Click);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(632, 242);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 11;
            this.button_show.Text = "Show";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.Button_show_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(713, 242);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 12;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.Button_edit_Click);
            // 
            // button_saveAfterEdit
            // 
            this.button_saveAfterEdit.Location = new System.Drawing.Point(11, 264);
            this.button_saveAfterEdit.Name = "button_saveAfterEdit";
            this.button_saveAfterEdit.Size = new System.Drawing.Size(101, 23);
            this.button_saveAfterEdit.TabIndex = 13;
            this.button_saveAfterEdit.Text = "Save After Edit";
            this.button_saveAfterEdit.UseVisualStyleBackColor = true;
            this.button_saveAfterEdit.Click += new System.EventHandler(this.Button_saveAfterEdit_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_saveAfterEdit);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_deleted);
            this.Controls.Add(this.listView_students);
            this.Controls.Add(this.textBox_maidenName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(button_addStudent);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_addStudent;
        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_gender;
        private Label label4;
        private TextBox textBox_maidenName;
        private ListView listView_students;
        private Button button_deleted;
        private Button button_show;
        private Button button_edit;
        private Button button_saveAfterEdit;
    }
}