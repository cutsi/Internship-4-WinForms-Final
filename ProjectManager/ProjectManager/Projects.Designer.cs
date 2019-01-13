namespace ProjectManager
{
    partial class Projects
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
            this.AddProject = new System.Windows.Forms.Button();
            this.DeleteProject = new System.Windows.Forms.Button();
            this.OverviewProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProject
            // 
            this.AddProject.Location = new System.Drawing.Point(45, 22);
            this.AddProject.Name = "AddProject";
            this.AddProject.Size = new System.Drawing.Size(152, 84);
            this.AddProject.TabIndex = 0;
            this.AddProject.Text = "Add project";
            this.AddProject.UseVisualStyleBackColor = true;
            this.AddProject.Click += new System.EventHandler(this.AddProject_Click);
            // 
            // DeleteProject
            // 
            this.DeleteProject.Location = new System.Drawing.Point(45, 157);
            this.DeleteProject.Name = "DeleteProject";
            this.DeleteProject.Size = new System.Drawing.Size(152, 84);
            this.DeleteProject.TabIndex = 1;
            this.DeleteProject.Text = "Delete project";
            this.DeleteProject.UseVisualStyleBackColor = true;
            // 
            // OverviewProject
            // 
            this.OverviewProject.Location = new System.Drawing.Point(45, 288);
            this.OverviewProject.Name = "OverviewProject";
            this.OverviewProject.Size = new System.Drawing.Size(152, 84);
            this.OverviewProject.TabIndex = 2;
            this.OverviewProject.Text = "Overview";
            this.OverviewProject.UseVisualStyleBackColor = true;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OverviewProject);
            this.Controls.Add(this.DeleteProject);
            this.Controls.Add(this.AddProject);
            this.Name = "Projects";
            this.Text = "Projects";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddProject;
        private System.Windows.Forms.Button DeleteProject;
        private System.Windows.Forms.Button OverviewProject;
    }
}