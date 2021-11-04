﻿
namespace Zork.Builder
{
    partial class RoomsWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip menuStripMain;
            System.Windows.Forms.GroupBox roomsBox;
            this.menuFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomsList = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomPropertiesBox = new System.Windows.Forms.GroupBox();
            this.roomPropertiesTabs = new System.Windows.Forms.TabControl();
            this.neighborsTab = new System.Windows.Forms.TabPage();
            this.roomItemsTab = new System.Windows.Forms.TabPage();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.roomNameText = new System.Windows.Forms.TextBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            menuStripMain = new System.Windows.Forms.MenuStrip();
            roomsBox = new System.Windows.Forms.GroupBox();
            menuStripMain.SuspendLayout();
            roomsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.roomPropertiesBox.SuspendLayout();
            this.roomPropertiesTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileButton});
            menuStripMain.Location = new System.Drawing.Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Padding = new System.Windows.Forms.Padding(0);
            menuStripMain.Size = new System.Drawing.Size(556, 24);
            menuStripMain.TabIndex = 0;
            // 
            // menuFileButton
            // 
            this.menuFileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewButton,
            this.menuSaveButton,
            this.menuSaveAsButton,
            this.menuOpenButton,
            this.menuCloseButton,
            this.toolStripMenuItem4,
            this.menuExitButton});
            this.menuFileButton.Name = "menuFileButton";
            this.menuFileButton.Size = new System.Drawing.Size(37, 24);
            this.menuFileButton.Text = "&File";
            // 
            // menuNewButton
            // 
            this.menuNewButton.Name = "menuNewButton";
            this.menuNewButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNewButton.Size = new System.Drawing.Size(184, 22);
            this.menuNewButton.Text = "New";
            this.menuNewButton.Click += new System.EventHandler(this.menuNewButton_Click);
            // 
            // menuSaveButton
            // 
            this.menuSaveButton.Name = "menuSaveButton";
            this.menuSaveButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSaveButton.Size = new System.Drawing.Size(184, 22);
            this.menuSaveButton.Text = "&Save";
            this.menuSaveButton.Click += new System.EventHandler(this.MenuSaveButton_Click);
            // 
            // menuSaveAsButton
            // 
            this.menuSaveAsButton.Name = "menuSaveAsButton";
            this.menuSaveAsButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.menuSaveAsButton.Size = new System.Drawing.Size(184, 22);
            this.menuSaveAsButton.Text = "Save &as...";
            this.menuSaveAsButton.Click += new System.EventHandler(this.MenuSaveAsButton_Click);
            // 
            // menuOpenButton
            // 
            this.menuOpenButton.Name = "menuOpenButton";
            this.menuOpenButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpenButton.Size = new System.Drawing.Size(184, 22);
            this.menuOpenButton.Text = "Open";
            this.menuOpenButton.Click += new System.EventHandler(this.MenuOpenButton_Click);
            // 
            // menuCloseButton
            // 
            this.menuCloseButton.Name = "menuCloseButton";
            this.menuCloseButton.Size = new System.Drawing.Size(184, 22);
            this.menuCloseButton.Text = "&Close";
            this.menuCloseButton.Click += new System.EventHandler(this.CloseMenuButton_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 6);
            // 
            // menuExitButton
            // 
            this.menuExitButton.Name = "menuExitButton";
            this.menuExitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExitButton.Size = new System.Drawing.Size(184, 22);
            this.menuExitButton.Text = "E&xit";
            this.menuExitButton.Click += new System.EventHandler(this.menuExitButton_Click);
            // 
            // roomsBox
            // 
            roomsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            roomsBox.Controls.Add(this.deleteRoomButton);
            roomsBox.Controls.Add(this.addRoomButton);
            roomsBox.Controls.Add(this.roomsList);
            roomsBox.Location = new System.Drawing.Point(11, 25);
            roomsBox.Margin = new System.Windows.Forms.Padding(2);
            roomsBox.Name = "roomsBox";
            roomsBox.Padding = new System.Windows.Forms.Padding(2);
            roomsBox.Size = new System.Drawing.Size(113, 284);
            roomsBox.TabIndex = 1;
            roomsBox.TabStop = false;
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(58, 252);
            this.deleteRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(50, 25);
            this.deleteRoomButton.TabIndex = 2;
            this.deleteRoomButton.Text = "Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(4, 252);
            this.addRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(50, 25);
            this.addRoomButton.TabIndex = 1;
            this.addRoomButton.Text = "Add";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // roomsList
            // 
            this.roomsList.DataSource = this.roomsBindingSource;
            this.roomsList.DisplayMember = "Name";
            this.roomsList.FormattingEnabled = true;
            this.roomsList.Location = new System.Drawing.Point(4, 10);
            this.roomsList.Margin = new System.Windows.Forms.Padding(2);
            this.roomsList.Name = "roomsList";
            this.roomsList.Size = new System.Drawing.Size(104, 238);
            this.roomsList.TabIndex = 0;
            this.roomsList.ValueMember = "Name";
            this.roomsList.SelectedIndexChanged += new System.EventHandler(this.RoomsList_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // roomPropertiesBox
            // 
            this.roomPropertiesBox.Controls.Add(this.roomPropertiesTabs);
            this.roomPropertiesBox.Controls.Add(this.roomDescriptionTextBox);
            this.roomPropertiesBox.Controls.Add(this.roomDescriptionLabel);
            this.roomPropertiesBox.Controls.Add(this.roomNameText);
            this.roomPropertiesBox.Controls.Add(this.roomLabel);
            this.roomPropertiesBox.Location = new System.Drawing.Point(129, 25);
            this.roomPropertiesBox.Name = "roomPropertiesBox";
            this.roomPropertiesBox.Size = new System.Drawing.Size(415, 284);
            this.roomPropertiesBox.TabIndex = 2;
            this.roomPropertiesBox.TabStop = false;
            // 
            // roomPropertiesTabs
            // 
            this.roomPropertiesTabs.Controls.Add(this.neighborsTab);
            this.roomPropertiesTabs.Controls.Add(this.roomItemsTab);
            this.roomPropertiesTabs.Location = new System.Drawing.Point(9, 114);
            this.roomPropertiesTabs.Name = "roomPropertiesTabs";
            this.roomPropertiesTabs.SelectedIndex = 0;
            this.roomPropertiesTabs.Size = new System.Drawing.Size(400, 156);
            this.roomPropertiesTabs.TabIndex = 4;
            // 
            // neighborsTab
            // 
            this.neighborsTab.Location = new System.Drawing.Point(4, 22);
            this.neighborsTab.Name = "neighborsTab";
            this.neighborsTab.Padding = new System.Windows.Forms.Padding(3);
            this.neighborsTab.Size = new System.Drawing.Size(392, 130);
            this.neighborsTab.TabIndex = 0;
            this.neighborsTab.Text = "Neighbors";
            this.neighborsTab.UseVisualStyleBackColor = true;
            // 
            // roomItemsTab
            // 
            this.roomItemsTab.Location = new System.Drawing.Point(4, 22);
            this.roomItemsTab.Name = "roomItemsTab";
            this.roomItemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.roomItemsTab.Size = new System.Drawing.Size(392, 130);
            this.roomItemsTab.TabIndex = 1;
            this.roomItemsTab.Text = "Items";
            this.roomItemsTab.UseVisualStyleBackColor = true;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(160, 29);
            this.roomDescriptionTextBox.Multiline = true;
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(251, 83);
            this.roomDescriptionTextBox.TabIndex = 3;
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(160, 16);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.roomDescriptionLabel.TabIndex = 2;
            this.roomDescriptionLabel.Text = "Description";
            // 
            // roomNameText
            // 
            this.roomNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomNameText.Location = new System.Drawing.Point(6, 29);
            this.roomNameText.Name = "roomNameText";
            this.roomNameText.Size = new System.Drawing.Size(148, 20);
            this.roomNameText.TabIndex = 1;
            this.roomNameText.TextChanged += new System.EventHandler(this.RoomNameText_TextChanged);
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(6, 16);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(35, 13);
            this.roomLabel.TabIndex = 0;
            this.roomLabel.Text = "Name";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Game Files (*.json)|*.json";
            this.saveFileDialog.Title = "Save Game File";
            // 
            // RoomsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 314);
            this.Controls.Add(this.roomPropertiesBox);
            this.Controls.Add(roomsBox);
            this.Controls.Add(menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RoomsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zork Builder";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            roomsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.roomPropertiesBox.ResumeLayout(false);
            this.roomPropertiesBox.PerformLayout();
            this.roomPropertiesTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuFileButton;
        private System.Windows.Forms.ToolStripMenuItem menuNewButton;
        private System.Windows.Forms.ToolStripMenuItem menuOpenButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuExitButton;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.ListBox roomsList;
        private System.Windows.Forms.GroupBox roomPropertiesBox;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.TextBox roomNameText;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.TabControl roomPropertiesTabs;
        private System.Windows.Forms.TabPage neighborsTab;
        private System.Windows.Forms.TabPage roomItemsTab;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.ToolStripMenuItem menuSaveButton;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAsButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem menuCloseButton;
    }
}
