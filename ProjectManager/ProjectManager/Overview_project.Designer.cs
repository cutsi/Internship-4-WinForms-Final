namespace ProjectManager
{
    partial class Overview_project
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
            this.projectCheckedListbox = new System.Windows.Forms.CheckedListBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectCheckedListbox
            // 
            this.projectCheckedListbox.FormattingEnabled = true;
            this.projectCheckedListbox.Location = new System.Drawing.Point(57, 41);
            this.projectCheckedListbox.Name = "projectCheckedListbox";
            this.projectCheckedListbox.Size = new System.Drawing.Size(199, 293);
            this.projectCheckedListbox.TabIndex = 0;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(375, 60);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(182, 91);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(375, 213);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(182, 91);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // Overview_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.projectCheckedListbox);
            this.Name = "Overview_project";
            this.Text = "Overview_project";
            //this.Load += new System.EventHandler(this.Overview_project_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox projectCheckedListbox;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button editButton;
    }
}