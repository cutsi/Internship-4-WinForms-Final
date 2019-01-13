namespace ProjectManager
{
    partial class DeleteProjectForm
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
            this.projectCheckBox = new System.Windows.Forms.CheckedListBox();
            this.deleteProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectCheckBox
            // 
            this.projectCheckBox.FormattingEnabled = true;
            this.projectCheckBox.Location = new System.Drawing.Point(70, 57);
            this.projectCheckBox.Name = "projectCheckBox";
            this.projectCheckBox.Size = new System.Drawing.Size(212, 242);
            this.projectCheckBox.TabIndex = 0;
            // 
            // deleteProjectButton
            // 
            this.deleteProjectButton.Location = new System.Drawing.Point(413, 57);
            this.deleteProjectButton.Name = "deleteProjectButton";
            this.deleteProjectButton.Size = new System.Drawing.Size(199, 110);
            this.deleteProjectButton.TabIndex = 1;
            this.deleteProjectButton.Text = "Delete ";
            this.deleteProjectButton.UseVisualStyleBackColor = true;
            this.deleteProjectButton.Click += new System.EventHandler(this.deleteProjectButton_Click);
            // 
            // DeleteProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteProjectButton);
            this.Controls.Add(this.projectCheckBox);
            this.Name = "DeleteProjectForm";
            this.Text = "DeleteProjectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox projectCheckBox;
        private System.Windows.Forms.Button deleteProjectButton;
    }
}