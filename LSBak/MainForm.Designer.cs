namespace LSBak
{
    partial class MainForm
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
            this.runJobButton = new System.Windows.Forms.Button();
            this.createJobButton = new System.Windows.Forms.Button();
            this.manageJobButton = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // runJobButton
            // 
            this.runJobButton.Location = new System.Drawing.Point(39, 126);
            this.runJobButton.Name = "runJobButton";
            this.runJobButton.Size = new System.Drawing.Size(188, 61);
            this.runJobButton.TabIndex = 0;
            this.runJobButton.Text = "Run Job";
            this.runJobButton.UseVisualStyleBackColor = true;
            this.runJobButton.Click += new System.EventHandler(this.runJobButton_Click);
            // 
            // createJobButton
            // 
            this.createJobButton.Location = new System.Drawing.Point(39, 193);
            this.createJobButton.Name = "createJobButton";
            this.createJobButton.Size = new System.Drawing.Size(188, 61);
            this.createJobButton.TabIndex = 1;
            this.createJobButton.Text = "Create Job";
            this.createJobButton.UseVisualStyleBackColor = true;
            // 
            // manageJobButton
            // 
            this.manageJobButton.Location = new System.Drawing.Point(39, 260);
            this.manageJobButton.Name = "manageJobButton";
            this.manageJobButton.Size = new System.Drawing.Size(188, 61);
            this.manageJobButton.TabIndex = 2;
            this.manageJobButton.Text = "Manage Jobs";
            this.manageJobButton.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Georgia", 40F);
            this.labelControl1.Location = new System.Drawing.Point(37, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(192, 77);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "LSBak";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 340);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.manageJobButton);
            this.Controls.Add(this.createJobButton);
            this.Controls.Add(this.runJobButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LSBak";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runJobButton;
        private System.Windows.Forms.Button createJobButton;
        private System.Windows.Forms.Button manageJobButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}

