
namespace ZorkBuilder
{
    partial class ItemsForm
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
            this.itemsBox = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.itemDescriptionBox = new System.Windows.Forms.TextBox();
            this.itemNameBox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.containsComboBox = new System.Windows.Forms.ComboBox();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.capacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startOpenCheckBox = new System.Windows.Forms.CheckBox();
            this.containerCheckBox = new System.Windows.Forms.CheckBox();
            this.canTakeCheckBox = new System.Windows.Forms.CheckBox();
            this.usedOnComboBox = new System.Windows.Forms.ComboBox();
            this.newItemOnUseComboBox = new System.Windows.Forms.ComboBox();
            this.newItemOnUseCheckBox = new System.Windows.Forms.CheckBox();
            this.limitedUsesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.limitedUsesCheckBox = new System.Windows.Forms.CheckBox();
            this.usedOnLabel = new System.Windows.Forms.Label();
            this.awardOnComboBox = new System.Windows.Forms.ComboBox();
            this.awardPointsnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.awardPointsCheckBox = new System.Windows.Forms.CheckBox();
            this.itemsBox.SuspendLayout();
            this.itemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitedUsesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardPointsnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsBox
            // 
            this.itemsBox.Controls.Add(this.itemsListBox);
            this.itemsBox.Controls.Add(this.Delete);
            this.itemsBox.Controls.Add(this.AddItemButton);
            this.itemsBox.Location = new System.Drawing.Point(2, 3);
            this.itemsBox.Name = "itemsBox";
            this.itemsBox.Size = new System.Drawing.Size(177, 315);
            this.itemsBox.TabIndex = 4;
            this.itemsBox.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(93, 286);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(8, 286);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(75, 23);
            this.AddItemButton.TabIndex = 4;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Items.AddRange(new object[] {
            "Jewel Encrusted Egg",
            "Mailbox",
            "Leaflet",
            "Mat"});
            this.itemsListBox.Location = new System.Drawing.Point(8, 4);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(160, 277);
            this.itemsListBox.TabIndex = 11;
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Controls.Add(this.usedOnComboBox);
            this.itemsGroupBox.Controls.Add(this.newItemOnUseComboBox);
            this.itemsGroupBox.Controls.Add(this.newItemOnUseCheckBox);
            this.itemsGroupBox.Controls.Add(this.limitedUsesNumericUpDown);
            this.itemsGroupBox.Controls.Add(this.limitedUsesCheckBox);
            this.itemsGroupBox.Controls.Add(this.usedOnLabel);
            this.itemsGroupBox.Controls.Add(this.awardOnComboBox);
            this.itemsGroupBox.Controls.Add(this.awardPointsnumericUpDown);
            this.itemsGroupBox.Controls.Add(this.awardPointsCheckBox);
            this.itemsGroupBox.Controls.Add(this.containsComboBox);
            this.itemsGroupBox.Controls.Add(this.capacityLabel);
            this.itemsGroupBox.Controls.Add(this.capacityNumericUpDown);
            this.itemsGroupBox.Controls.Add(this.startOpenCheckBox);
            this.itemsGroupBox.Controls.Add(this.containerCheckBox);
            this.itemsGroupBox.Controls.Add(this.canTakeCheckBox);
            this.itemsGroupBox.Controls.Add(this.Save);
            this.itemsGroupBox.Controls.Add(this.itemDescriptionLabel);
            this.itemsGroupBox.Controls.Add(this.itemDescriptionBox);
            this.itemsGroupBox.Controls.Add(this.itemNameBox);
            this.itemsGroupBox.Controls.Add(this.itemNameLabel);
            this.itemsGroupBox.Location = new System.Drawing.Point(185, 3);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(379, 324);
            this.itemsGroupBox.TabIndex = 5;
            this.itemsGroupBox.TabStop = false;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(6, 49);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 40;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Location = new System.Drawing.Point(149, 8);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.itemDescriptionLabel.TabIndex = 28;
            this.itemDescriptionLabel.Text = "Description";
            // 
            // itemDescriptionBox
            // 
            this.itemDescriptionBox.Location = new System.Drawing.Point(152, 23);
            this.itemDescriptionBox.Multiline = true;
            this.itemDescriptionBox.Name = "itemDescriptionBox";
            this.itemDescriptionBox.Size = new System.Drawing.Size(215, 71);
            this.itemDescriptionBox.TabIndex = 27;
            // 
            // itemNameBox
            // 
            this.itemNameBox.Location = new System.Drawing.Point(6, 23);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemNameBox.Size = new System.Drawing.Size(140, 20);
            this.itemNameBox.TabIndex = 25;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(3, 8);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(35, 13);
            this.itemNameLabel.TabIndex = 26;
            this.itemNameLabel.Text = "Name";
            // 
            // containsComboBox
            // 
            this.containsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.containsComboBox.Enabled = false;
            this.containsComboBox.Font = new System.Drawing.Font("Calibri", 7F);
            this.containsComboBox.FormattingEnabled = true;
            this.containsComboBox.Location = new System.Drawing.Point(17, 183);
            this.containsComboBox.Name = "containsComboBox";
            this.containsComboBox.Size = new System.Drawing.Size(120, 140);
            this.containsComboBox.TabIndex = 46;
            this.containsComboBox.Text = "Contains";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Calibri", 7F);
            this.capacityLabel.Location = new System.Drawing.Point(14, 142);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(41, 13);
            this.capacityLabel.TabIndex = 45;
            this.capacityLabel.Text = "Capacity";
            // 
            // capacityNumericUpDown
            // 
            this.capacityNumericUpDown.Enabled = false;
            this.capacityNumericUpDown.Font = new System.Drawing.Font("Calibri", 7F);
            this.capacityNumericUpDown.Location = new System.Drawing.Point(17, 158);
            this.capacityNumericUpDown.Name = "capacityNumericUpDown";
            this.capacityNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.capacityNumericUpDown.TabIndex = 44;
            this.capacityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startOpenCheckBox
            // 
            this.startOpenCheckBox.AutoSize = true;
            this.startOpenCheckBox.Enabled = false;
            this.startOpenCheckBox.Font = new System.Drawing.Font("Calibri", 7F);
            this.startOpenCheckBox.Location = new System.Drawing.Point(17, 122);
            this.startOpenCheckBox.Name = "startOpenCheckBox";
            this.startOpenCheckBox.Size = new System.Drawing.Size(69, 17);
            this.startOpenCheckBox.TabIndex = 43;
            this.startOpenCheckBox.Text = "Start Open";
            this.startOpenCheckBox.UseVisualStyleBackColor = true;
            // 
            // containerCheckBox
            // 
            this.containerCheckBox.AutoSize = true;
            this.containerCheckBox.Location = new System.Drawing.Point(6, 103);
            this.containerCheckBox.Name = "containerCheckBox";
            this.containerCheckBox.Size = new System.Drawing.Size(71, 17);
            this.containerCheckBox.TabIndex = 42;
            this.containerCheckBox.Text = "Container";
            this.containerCheckBox.UseVisualStyleBackColor = true;
            // 
            // canTakeCheckBox
            // 
            this.canTakeCheckBox.AutoSize = true;
            this.canTakeCheckBox.Location = new System.Drawing.Point(6, 80);
            this.canTakeCheckBox.Name = "canTakeCheckBox";
            this.canTakeCheckBox.Size = new System.Drawing.Size(73, 17);
            this.canTakeCheckBox.TabIndex = 41;
            this.canTakeCheckBox.Text = "Can Take";
            this.canTakeCheckBox.UseVisualStyleBackColor = true;
            // 
            // usedOnComboBox
            // 
            this.usedOnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.usedOnComboBox.Font = new System.Drawing.Font("Calibri", 7F);
            this.usedOnComboBox.FormattingEnabled = true;
            this.usedOnComboBox.Location = new System.Drawing.Point(149, 206);
            this.usedOnComboBox.Name = "usedOnComboBox";
            this.usedOnComboBox.Size = new System.Drawing.Size(221, 118);
            this.usedOnComboBox.TabIndex = 55;
            this.usedOnComboBox.Text = "Item";
            // 
            // newItemOnUseComboBox
            // 
            this.newItemOnUseComboBox.Enabled = false;
            this.newItemOnUseComboBox.Font = new System.Drawing.Font("Calibri", 7F);
            this.newItemOnUseComboBox.FormattingEnabled = true;
            this.newItemOnUseComboBox.Location = new System.Drawing.Point(152, 168);
            this.newItemOnUseComboBox.Name = "newItemOnUseComboBox";
            this.newItemOnUseComboBox.Size = new System.Drawing.Size(121, 19);
            this.newItemOnUseComboBox.TabIndex = 54;
            this.newItemOnUseComboBox.Text = "Item";
            // 
            // newItemOnUseCheckBox
            // 
            this.newItemOnUseCheckBox.AutoSize = true;
            this.newItemOnUseCheckBox.Enabled = false;
            this.newItemOnUseCheckBox.Font = new System.Drawing.Font("Calibri", 7F);
            this.newItemOnUseCheckBox.Location = new System.Drawing.Point(149, 147);
            this.newItemOnUseCheckBox.Name = "newItemOnUseCheckBox";
            this.newItemOnUseCheckBox.Size = new System.Drawing.Size(92, 17);
            this.newItemOnUseCheckBox.TabIndex = 53;
            this.newItemOnUseCheckBox.Text = "New item on use";
            this.newItemOnUseCheckBox.UseVisualStyleBackColor = true;
            // 
            // limitedUsesNumericUpDown
            // 
            this.limitedUsesNumericUpDown.Enabled = false;
            this.limitedUsesNumericUpDown.Font = new System.Drawing.Font("Calibri", 7F);
            this.limitedUsesNumericUpDown.Location = new System.Drawing.Point(149, 120);
            this.limitedUsesNumericUpDown.Name = "limitedUsesNumericUpDown";
            this.limitedUsesNumericUpDown.Size = new System.Drawing.Size(125, 19);
            this.limitedUsesNumericUpDown.TabIndex = 52;
            this.limitedUsesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // limitedUsesCheckBox
            // 
            this.limitedUsesCheckBox.AutoSize = true;
            this.limitedUsesCheckBox.Location = new System.Drawing.Point(137, 103);
            this.limitedUsesCheckBox.Name = "limitedUsesCheckBox";
            this.limitedUsesCheckBox.Size = new System.Drawing.Size(86, 17);
            this.limitedUsesCheckBox.TabIndex = 51;
            this.limitedUsesCheckBox.Text = "Limited Uses";
            this.limitedUsesCheckBox.UseVisualStyleBackColor = true;
            // 
            // usedOnLabel
            // 
            this.usedOnLabel.AutoSize = true;
            this.usedOnLabel.Location = new System.Drawing.Point(150, 192);
            this.usedOnLabel.Name = "usedOnLabel";
            this.usedOnLabel.Size = new System.Drawing.Size(49, 13);
            this.usedOnLabel.TabIndex = 50;
            this.usedOnLabel.Text = "Used On";
            // 
            // awardOnComboBox
            // 
            this.awardOnComboBox.Enabled = false;
            this.awardOnComboBox.Font = new System.Drawing.Font("Calibri", 7F);
            this.awardOnComboBox.FormattingEnabled = true;
            this.awardOnComboBox.Location = new System.Drawing.Point(300, 145);
            this.awardOnComboBox.Name = "awardOnComboBox";
            this.awardOnComboBox.Size = new System.Drawing.Size(67, 19);
            this.awardOnComboBox.TabIndex = 49;
            this.awardOnComboBox.Text = "Award On";
            // 
            // awardPointsnumericUpDown
            // 
            this.awardPointsnumericUpDown.Enabled = false;
            this.awardPointsnumericUpDown.Font = new System.Drawing.Font("Calibri", 7F);
            this.awardPointsnumericUpDown.Location = new System.Drawing.Point(300, 120);
            this.awardPointsnumericUpDown.Name = "awardPointsnumericUpDown";
            this.awardPointsnumericUpDown.Size = new System.Drawing.Size(66, 19);
            this.awardPointsnumericUpDown.TabIndex = 48;
            this.awardPointsnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // awardPointsCheckBox
            // 
            this.awardPointsCheckBox.AutoSize = true;
            this.awardPointsCheckBox.Location = new System.Drawing.Point(284, 103);
            this.awardPointsCheckBox.Name = "awardPointsCheckBox";
            this.awardPointsCheckBox.Size = new System.Drawing.Size(88, 17);
            this.awardPointsCheckBox.TabIndex = 47;
            this.awardPointsCheckBox.Text = "Award Points";
            this.awardPointsCheckBox.UseVisualStyleBackColor = true;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 330);
            this.Controls.Add(this.itemsGroupBox);
            this.Controls.Add(this.itemsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.itemsBox.ResumeLayout(false);
            this.itemsGroupBox.ResumeLayout(false);
            this.itemsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitedUsesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardPointsnumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox itemsBox;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label itemDescriptionLabel;
        private System.Windows.Forms.TextBox itemDescriptionBox;
        private System.Windows.Forms.TextBox itemNameBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.ComboBox containsComboBox;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.NumericUpDown capacityNumericUpDown;
        private System.Windows.Forms.CheckBox startOpenCheckBox;
        private System.Windows.Forms.CheckBox containerCheckBox;
        private System.Windows.Forms.CheckBox canTakeCheckBox;
        private System.Windows.Forms.ComboBox usedOnComboBox;
        private System.Windows.Forms.ComboBox newItemOnUseComboBox;
        private System.Windows.Forms.CheckBox newItemOnUseCheckBox;
        private System.Windows.Forms.NumericUpDown limitedUsesNumericUpDown;
        private System.Windows.Forms.CheckBox limitedUsesCheckBox;
        private System.Windows.Forms.Label usedOnLabel;
        private System.Windows.Forms.ComboBox awardOnComboBox;
        private System.Windows.Forms.NumericUpDown awardPointsnumericUpDown;
        private System.Windows.Forms.CheckBox awardPointsCheckBox;
    }
}