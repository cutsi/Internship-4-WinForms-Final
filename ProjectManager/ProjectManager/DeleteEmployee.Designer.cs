namespace ProjectManager
{
    partial class DeleteEmployee
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
            this.EmpListBox = new System.Windows.Forms.CheckedListBox();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmpListBox
            // 
            this.EmpListBox.FormattingEnabled = true;
            this.EmpListBox.Location = new System.Drawing.Point(57, 39);
            this.EmpListBox.Name = "EmpListBox";
            this.EmpListBox.Size = new System.Drawing.Size(179, 242);
            this.EmpListBox.TabIndex = 0;
            //this.EmpListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(485, 39);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(125, 61);
            this.DeleteEmployeeButton.TabIndex = 1;
            this.DeleteEmployeeButton.Text = "Delete";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.EmpListBox);
            this.Name = "DeleteEmployee";
            this.Text = "DeleteEmployee";
            //this.Load += new System.EventHandler(this.DeleteEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox EmpListBox;
        private System.Windows.Forms.Button DeleteEmployeeButton;
    }
}