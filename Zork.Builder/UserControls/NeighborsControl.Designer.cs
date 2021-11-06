
namespace Zork.Builder.UserControls
{
    partial class NeighborsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.neighborsComboBox = new System.Windows.Forms.ComboBox();
            this.neighborsDirectionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // neighborsComboBox
            // 
            this.neighborsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neighborsComboBox.DisplayMember = "Name";
            this.neighborsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.neighborsComboBox.FormattingEnabled = true;
            this.neighborsComboBox.Location = new System.Drawing.Point(0, 42);
            this.neighborsComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.neighborsComboBox.Name = "neighborsComboBox";
            this.neighborsComboBox.Size = new System.Drawing.Size(180, 28);
            this.neighborsComboBox.TabIndex = 0;
            this.neighborsComboBox.SelectedIndexChanged += new System.EventHandler(this.NeighborsComboBox_SelectedIndexChanged);
            // 
            // neighborsDirectionTextBox
            // 
            this.neighborsDirectionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neighborsDirectionTextBox.Location = new System.Drawing.Point(0, 2);
            this.neighborsDirectionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.neighborsDirectionTextBox.Name = "neighborsDirectionTextBox";
            this.neighborsDirectionTextBox.ReadOnly = true;
            this.neighborsDirectionTextBox.Size = new System.Drawing.Size(180, 26);
            this.neighborsDirectionTextBox.TabIndex = 1;
            this.neighborsDirectionTextBox.TabStop = false;
            this.neighborsDirectionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NeighborsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neighborsDirectionTextBox);
            this.Controls.Add(this.neighborsComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NeighborsControl";
            this.Size = new System.Drawing.Size(184, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox neighborsComboBox;
        private System.Windows.Forms.TextBox neighborsDirectionTextBox;
    }
}
