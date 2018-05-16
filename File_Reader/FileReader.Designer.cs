namespace File_Reader
{
    partial class FileReader
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
            this.ReadButton = new System.Windows.Forms.Button();
            this.RTBox = new System.Windows.Forms.RichTextBox();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.lblFileType = new System.Windows.Forms.Label();
            this.rbTxtFileType = new System.Windows.Forms.RadioButton();
            this.rbXmlFileType = new System.Windows.Forms.RadioButton();
            this.ckBoxEncryotion = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRoleAdmin = new System.Windows.Forms.RadioButton();
            this.rbRoleOthers = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbJsonFileType = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(23, 70);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(75, 23);
            this.ReadButton.TabIndex = 0;
            this.ReadButton.Text = "Read File";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // RTBox
            // 
            this.RTBox.Enabled = false;
            this.RTBox.Location = new System.Drawing.Point(22, 99);
            this.RTBox.Name = "RTBox";
            this.RTBox.Size = new System.Drawing.Size(633, 293);
            this.RTBox.TabIndex = 1;
            this.RTBox.Text = "";
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Enabled = false;
            this.txtBoxPath.Location = new System.Drawing.Point(104, 73);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(551, 20);
            this.txtBoxPath.TabIndex = 2;
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(3, 3);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(56, 13);
            this.lblFileType.TabIndex = 3;
            this.lblFileType.Text = "File Type :";
            // 
            // rbTxtFileType
            // 
            this.rbTxtFileType.AutoSize = true;
            this.rbTxtFileType.Checked = true;
            this.rbTxtFileType.Location = new System.Drawing.Point(70, 3);
            this.rbTxtFileType.Name = "rbTxtFileType";
            this.rbTxtFileType.Size = new System.Drawing.Size(62, 17);
            this.rbTxtFileType.TabIndex = 4;
            this.rbTxtFileType.TabStop = true;
            this.rbTxtFileType.Text = "Text file";
            this.rbTxtFileType.UseVisualStyleBackColor = true;
            // 
            // rbXmlFileType
            // 
            this.rbXmlFileType.AutoSize = true;
            this.rbXmlFileType.Location = new System.Drawing.Point(138, 3);
            this.rbXmlFileType.Name = "rbXmlFileType";
            this.rbXmlFileType.Size = new System.Drawing.Size(58, 17);
            this.rbXmlFileType.TabIndex = 5;
            this.rbXmlFileType.TabStop = true;
            this.rbXmlFileType.Text = "Xml file";
            this.rbXmlFileType.UseVisualStyleBackColor = true;
            // 
            // ckBoxEncryotion
            // 
            this.ckBoxEncryotion.AutoSize = true;
            this.ckBoxEncryotion.Location = new System.Drawing.Point(383, 13);
            this.ckBoxEncryotion.Name = "ckBoxEncryotion";
            this.ckBoxEncryotion.Size = new System.Drawing.Size(113, 17);
            this.ckBoxEncryotion.TabIndex = 7;
            this.ckBoxEncryotion.Text = "Enablle encryption";
            this.ckBoxEncryotion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Role :";
            // 
            // rbRoleAdmin
            // 
            this.rbRoleAdmin.AutoSize = true;
            this.rbRoleAdmin.Location = new System.Drawing.Point(70, 3);
            this.rbRoleAdmin.Name = "rbRoleAdmin";
            this.rbRoleAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbRoleAdmin.TabIndex = 9;
            this.rbRoleAdmin.TabStop = true;
            this.rbRoleAdmin.Text = "Admin";
            this.rbRoleAdmin.UseVisualStyleBackColor = true;
            // 
            // rbRoleOthers
            // 
            this.rbRoleOthers.AutoSize = true;
            this.rbRoleOthers.Location = new System.Drawing.Point(138, 3);
            this.rbRoleOthers.Name = "rbRoleOthers";
            this.rbRoleOthers.Size = new System.Drawing.Size(56, 17);
            this.rbRoleOthers.TabIndex = 10;
            this.rbRoleOthers.TabStop = true;
            this.rbRoleOthers.Text = "Others";
            this.rbRoleOthers.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbJsonFileType);
            this.panel1.Controls.Add(this.rbXmlFileType);
            this.panel1.Controls.Add(this.rbTxtFileType);
            this.panel1.Controls.Add(this.lblFileType);
            this.panel1.Location = new System.Drawing.Point(22, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 23);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbRoleOthers);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rbRoleAdmin);
            this.panel2.Location = new System.Drawing.Point(22, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 23);
            this.panel2.TabIndex = 12;
            // 
            // rbJsonFileType
            // 
            this.rbJsonFileType.AutoSize = true;
            this.rbJsonFileType.Location = new System.Drawing.Point(202, 3);
            this.rbJsonFileType.Name = "rbJsonFileType";
            this.rbJsonFileType.Size = new System.Drawing.Size(63, 17);
            this.rbJsonFileType.TabIndex = 6;
            this.rbJsonFileType.TabStop = true;
            this.rbJsonFileType.Text = "Json file";
            this.rbJsonFileType.UseVisualStyleBackColor = true;
            // 
            // FileReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ckBoxEncryotion);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.RTBox);
            this.Controls.Add(this.ReadButton);
            this.Name = "FileReader";
            this.Text = "FileReader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.RichTextBox RTBox;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.RadioButton rbTxtFileType;
        private System.Windows.Forms.RadioButton rbXmlFileType;
        private System.Windows.Forms.CheckBox ckBoxEncryotion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRoleAdmin;
        private System.Windows.Forms.RadioButton rbRoleOthers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbJsonFileType;
    }
}

