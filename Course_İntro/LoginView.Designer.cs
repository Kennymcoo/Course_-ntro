namespace Course_İntro
{
    partial class LoginView
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
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(145, 94);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(100, 23);
            this.textBox_Password.TabIndex = 2;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(145, 28);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(100, 23);
            this.textBox_Username.TabIndex = 1;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(25, 94);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(57, 15);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(22, 31);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(60, 15);
            this.label_Username.TabIndex = 3;
            this.label_Username.Text = "Username";
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(25, 166);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 239);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_Password);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Password;
        private TextBox textBox_Username;
        private Label label_Password;
        private Label label_Username;
        private Button button_Login;
    }
}