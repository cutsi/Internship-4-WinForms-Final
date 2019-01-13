namespace ProjectManager
{
    partial class EditEmployeeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HoursTextbox = new System.Windows.Forms.TextBox();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectListBox = new System.Windows.Forms.CheckedListBox();
            this.Save = new System.Windows.Forms.Button();
            this.birthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LastNametextbox = new System.Windows.Forms.TextBox();
            this.FirstNametextbox = new System.Windows.Forms.TextBox();
            this.OibTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Working hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Last name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(42, 111);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(74, 17);
            this.FirstNameLabel.TabIndex = 24;
            this.FirstNameLabel.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "OIB";
            // 
            // HoursTextbox
            // 
            this.HoursTextbox.Location = new System.Drawing.Point(567, 28);
            this.HoursTextbox.Name = "HoursTextbox";
            this.HoursTextbox.Size = new System.Drawing.Size(166, 22);
            this.HoursTextbox.TabIndex = 22;
            // 
            // JobComboBox
            // 
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Location = new System.Drawing.Point(123, 277);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(245, 24);
            this.JobComboBox.TabIndex = 21;
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(553, 87);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(205, 276);
            this.ProjectListBox.TabIndex = 20;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(123, 336);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(161, 87);
            this.Save.TabIndex = 19;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // birthTimePicker
            // 
            this.birthTimePicker.Location = new System.Drawing.Point(123, 224);
            this.birthTimePicker.Name = "birthTimePicker";
            this.birthTimePicker.Size = new System.Drawing.Size(199, 22);
            this.birthTimePicker.TabIndex = 18;
            // 
            // LastNametextbox
            // 
            this.LastNametextbox.Location = new System.Drawing.Point(123, 171);
            this.LastNametextbox.Name = "LastNametextbox";
            this.LastNametextbox.Size = new System.Drawing.Size(250, 22);
            this.LastNametextbox.TabIndex = 17;
            // 
            // FirstNametextbox
            // 
            this.FirstNametextbox.Location = new System.Drawing.Point(123, 111);
            this.FirstNametextbox.Name = "FirstNametextbox";
            this.FirstNametextbox.Size = new System.Drawing.Size(250, 22);
            this.FirstNametextbox.TabIndex = 16;
            // 
            // OibTextbox
            // 
            this.OibTextbox.Location = new System.Drawing.Point(123, 45);
            this.OibTextbox.Name = "OibTextbox";
            this.OibTextbox.Size = new System.Drawing.Size(250, 22);
            this.OibTextbox.TabIndex = 15;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HoursTextbox);
            this.Controls.Add(this.JobComboBox);
            this.Controls.Add(this.ProjectListBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.birthTimePicker);
            this.Controls.Add(this.LastNametextbox);
            this.Controls.Add(this.FirstNametextbox);
            this.Controls.Add(this.OibTextbox);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HoursTextbox;
        private System.Windows.Forms.ComboBox JobComboBox;
        private System.Windows.Forms.CheckedListBox ProjectListBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DateTimePicker birthTimePicker;
        private System.Windows.Forms.TextBox LastNametextbox;
        private System.Windows.Forms.TextBox FirstNametextbox;
        private System.Windows.Forms.TextBox OibTextbox;
    }
}