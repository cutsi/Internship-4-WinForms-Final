namespace ProjectManager
{
    partial class Overview
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
            this.checkedListBoxOverview = new System.Windows.Forms.CheckedListBox();
            this.Details = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxOverview
            // 
            this.checkedListBoxOverview.FormattingEnabled = true;
            this.checkedListBoxOverview.Location = new System.Drawing.Point(49, 50);
            this.checkedListBoxOverview.Name = "checkedListBoxOverview";
            this.checkedListBoxOverview.Size = new System.Drawing.Size(228, 276);
            this.checkedListBoxOverview.TabIndex = 0;
            this.checkedListBoxOverview.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxOverview_SelectedIndexChanged);
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(449, 50);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(148, 96);
            this.Details.TabIndex = 1;
            this.Details.Text = "Details";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(449, 230);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(148, 96);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.checkedListBoxOverview);
            this.Name = "Overview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxOverview;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.Button Edit;
    }
}