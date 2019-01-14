namespace ProjectManager
{
    partial class DetailsProject
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
            this.projectNameTextbox = new System.Windows.Forms.TextBox();
            this.projectDatetextbox = new System.Windows.Forms.TextBox();
            this.ProgrammerComboBox = new System.Windows.Forms.ComboBox();
            this.SecretarComboBox = new System.Windows.Forms.ComboBox();
            this.accoutantComboBox = new System.Windows.Forms.ComboBox();
            this.designerComboBox = new System.Windows.Forms.ComboBox();
            this.marketingComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // projectNameTextbox
            // 
            this.projectNameTextbox.Location = new System.Drawing.Point(96, 55);
            this.projectNameTextbox.Name = "projectNameTextbox";
            this.projectNameTextbox.Size = new System.Drawing.Size(233, 22);
            this.projectNameTextbox.TabIndex = 0;
            // 
            // projectDatetextbox
            // 
            this.projectDatetextbox.Location = new System.Drawing.Point(96, 153);
            this.projectDatetextbox.Name = "projectDatetextbox";
            this.projectDatetextbox.Size = new System.Drawing.Size(233, 22);
            this.projectDatetextbox.TabIndex = 1;
            // 
            // ProgrammerComboBox
            // 
            this.ProgrammerComboBox.FormattingEnabled = true;
            this.ProgrammerComboBox.Location = new System.Drawing.Point(468, 38);
            this.ProgrammerComboBox.Name = "ProgrammerComboBox";
            this.ProgrammerComboBox.Size = new System.Drawing.Size(173, 24);
            this.ProgrammerComboBox.TabIndex = 2;
            // 
            // SecretarComboBox
            // 
            this.SecretarComboBox.FormattingEnabled = true;
            this.SecretarComboBox.Location = new System.Drawing.Point(468, 103);
            this.SecretarComboBox.Name = "SecretarComboBox";
            this.SecretarComboBox.Size = new System.Drawing.Size(173, 24);
            this.SecretarComboBox.TabIndex = 3;
            // 
            // accoutantComboBox
            // 
            this.accoutantComboBox.FormattingEnabled = true;
            this.accoutantComboBox.Location = new System.Drawing.Point(468, 171);
            this.accoutantComboBox.Name = "accoutantComboBox";
            this.accoutantComboBox.Size = new System.Drawing.Size(173, 24);
            this.accoutantComboBox.TabIndex = 4;
            // 
            // designerComboBox
            // 
            this.designerComboBox.FormattingEnabled = true;
            this.designerComboBox.Location = new System.Drawing.Point(468, 239);
            this.designerComboBox.Name = "designerComboBox";
            this.designerComboBox.Size = new System.Drawing.Size(173, 24);
            this.designerComboBox.TabIndex = 5;
            // 
            // marketingComboBox
            // 
            this.marketingComboBox.FormattingEnabled = true;
            this.marketingComboBox.Location = new System.Drawing.Point(468, 308);
            this.marketingComboBox.Name = "marketingComboBox";
            this.marketingComboBox.Size = new System.Drawing.Size(173, 24);
            this.marketingComboBox.TabIndex = 6;
            // 
            // DetailsProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.marketingComboBox);
            this.Controls.Add(this.designerComboBox);
            this.Controls.Add(this.accoutantComboBox);
            this.Controls.Add(this.SecretarComboBox);
            this.Controls.Add(this.ProgrammerComboBox);
            this.Controls.Add(this.projectDatetextbox);
            this.Controls.Add(this.projectNameTextbox);
            this.Name = "DetailsProject";
            this.Text = "DetailsProject";
            this.Load += new System.EventHandler(this.DetailsProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projectNameTextbox;
        private System.Windows.Forms.TextBox projectDatetextbox;
        private System.Windows.Forms.ComboBox ProgrammerComboBox;
        private System.Windows.Forms.ComboBox SecretarComboBox;
        private System.Windows.Forms.ComboBox accoutantComboBox;
        private System.Windows.Forms.ComboBox designerComboBox;
        private System.Windows.Forms.ComboBox marketingComboBox;
    }
}