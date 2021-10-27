
namespace Zork.Builder.Forms
{
    partial class StartUp
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
            System.Windows.Forms.GroupBox MainMenuBox;
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ButtonsBox = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.createWorldButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            MainMenuBox = new System.Windows.Forms.GroupBox();
            MainMenuBox.SuspendLayout();
            this.ButtonsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuBox
            // 
            MainMenuBox.Controls.Add(this.TitleLabel);
            MainMenuBox.Controls.Add(this.ButtonsBox);
            MainMenuBox.Dock = System.Windows.Forms.DockStyle.Fill;
            MainMenuBox.Location = new System.Drawing.Point(0, 0);
            MainMenuBox.Name = "MainMenuBox";
            MainMenuBox.Size = new System.Drawing.Size(404, 321);
            MainMenuBox.TabIndex = 0;
            MainMenuBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(105, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(171, 89);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Zork";
            // 
            // ButtonsBox
            // 
            this.ButtonsBox.Controls.Add(this.closeButton);
            this.ButtonsBox.Controls.Add(this.createWorldButton);
            this.ButtonsBox.Controls.Add(this.openButton);
            this.ButtonsBox.Controls.Add(this.continueButton);
            this.ButtonsBox.Controls.Add(this.newButton);
            this.ButtonsBox.Location = new System.Drawing.Point(115, 111);
            this.ButtonsBox.Name = "ButtonsBox";
            this.ButtonsBox.Size = new System.Drawing.Size(149, 153);
            this.ButtonsBox.TabIndex = 1;
            this.ButtonsBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.closeButton.Location = new System.Drawing.Point(3, 111);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(143, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // createWorldButton
            // 
            this.createWorldButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createWorldButton.Location = new System.Drawing.Point(3, 88);
            this.createWorldButton.Name = "createWorldButton";
            this.createWorldButton.Size = new System.Drawing.Size(143, 23);
            this.createWorldButton.TabIndex = 3;
            this.createWorldButton.Text = "Create New World";
            this.createWorldButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openButton.Location = new System.Drawing.Point(3, 65);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(143, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.continueButton.Location = new System.Drawing.Point(3, 42);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(143, 23);
            this.continueButton.TabIndex = 1;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            this.newButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newButton.Location = new System.Drawing.Point(3, 19);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(143, 23);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 321);
            this.Controls.Add(MainMenuBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zork Builder";
            MainMenuBox.ResumeLayout(false);
            MainMenuBox.PerformLayout();
            this.ButtonsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainMenuBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.GroupBox ButtonsBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button createWorldButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}