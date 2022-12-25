namespace Course_İntro
{
    partial class DialogExport
    {
        private System.ComponentModel.IContainer components = null;

       
       
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
            this.button_Xml = new System.Windows.Forms.Button();
            this.button_Json = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Xml
            // 
            this.button_Xml.Location = new System.Drawing.Point(12, 89);
            this.button_Xml.Name = "button_Xml";
            this.button_Xml.Size = new System.Drawing.Size(75, 23);
            this.button_Xml.TabIndex = 0;
            this.button_Xml.Text = "Xml";
            this.button_Xml.UseVisualStyleBackColor = true;
            this.button_Xml.Click += new System.EventHandler(this.button_Xml_Click);
            // 
            // button_Json
            // 
            this.button_Json.Location = new System.Drawing.Point(122, 89);
            this.button_Json.Name = "button_Json";
            this.button_Json.Size = new System.Drawing.Size(75, 23);
            this.button_Json.TabIndex = 1;
            this.button_Json.Text = "Json";
            this.button_Json.UseVisualStyleBackColor = true;
            this.button_Json.Click += new System.EventHandler(this.button_Json_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(228, 89);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose one of them to export";
            // 
            // DialogExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Json);
            this.Controls.Add(this.button_Xml);
            this.Name = "DialogExport";
            this.Text = "DialogExport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Xml;
        private Button button_Json;
        private Button button_Cancel;
        private Label label1;
    }
}