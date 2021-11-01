
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
            this.menuOpenButton = new System.Windows.Forms.ToolStripMenuItem();
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
            menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileButton});
            menuStripMain.Location = new System.Drawing.Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Padding = new System.Windows.Forms.Padding(0);
            menuStripMain.Size = new System.Drawing.Size(834, 29);
            menuStripMain.TabIndex = 0;
            // 
            // menuFileButton
            // 
            this.menuFileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewButton,
            this.menuOpenButton,
            this.toolStripMenuItem4,
            this.menuExitButton});
            this.menuFileButton.Name = "menuFileButton";
            this.menuFileButton.Size = new System.Drawing.Size(54, 29);
            this.menuFileButton.Text = "&File";
            // 
            // menuNewButton
            // 
            this.menuNewButton.Name = "menuNewButton";
            this.menuNewButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNewButton.Size = new System.Drawing.Size(223, 34);
            this.menuNewButton.Text = "New";
            // 
            // menuOpenButton
            // 
            this.menuOpenButton.Name = "menuOpenButton";
            this.menuOpenButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpenButton.Size = new System.Drawing.Size(223, 34);
            this.menuOpenButton.Text = "Open";
            this.menuOpenButton.Click += new System.EventHandler(this.menuOpenButton_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(220, 6);
            // 
            // menuExitButton
            // 
            this.menuExitButton.Name = "menuExitButton";
            this.menuExitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExitButton.Size = new System.Drawing.Size(223, 34);
            this.menuExitButton.Text = "E&xit";
            this.menuExitButton.Click += new System.EventHandler(this.menuExitButton_Click);
            // 
            // roomsBox
            // 
            roomsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            roomsBox.Controls.Add(this.deleteRoomButton);
            roomsBox.Controls.Add(this.addRoomButton);
            roomsBox.Controls.Add(this.roomsList);
            roomsBox.Location = new System.Drawing.Point(16, 39);
            roomsBox.Name = "roomsBox";
            roomsBox.Size = new System.Drawing.Size(170, 437);
            roomsBox.TabIndex = 1;
            roomsBox.TabStop = false;
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(87, 388);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 38);
            this.deleteRoomButton.TabIndex = 2;
            this.deleteRoomButton.Text = "Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(6, 388);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 38);
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
            this.roomsList.ItemHeight = 20;
            this.roomsList.Location = new System.Drawing.Point(6, 15);
            this.roomsList.Name = "roomsList";
            this.roomsList.Size = new System.Drawing.Size(154, 364);
            this.roomsList.TabIndex = 0;
            this.roomsList.ValueMember = "Description";
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
            this.roomPropertiesBox.Location = new System.Drawing.Point(194, 39);
            this.roomPropertiesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomPropertiesBox.Name = "roomPropertiesBox";
            this.roomPropertiesBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomPropertiesBox.Size = new System.Drawing.Size(622, 437);
            this.roomPropertiesBox.TabIndex = 2;
            this.roomPropertiesBox.TabStop = false;
            // 
            // roomPropertiesTabs
            // 
            this.roomPropertiesTabs.Controls.Add(this.neighborsTab);
            this.roomPropertiesTabs.Controls.Add(this.roomItemsTab);
            this.roomPropertiesTabs.Location = new System.Drawing.Point(14, 176);
            this.roomPropertiesTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomPropertiesTabs.Name = "roomPropertiesTabs";
            this.roomPropertiesTabs.SelectedIndex = 0;
            this.roomPropertiesTabs.Size = new System.Drawing.Size(600, 240);
            this.roomPropertiesTabs.TabIndex = 4;
            // 
            // neighborsTab
            // 
            this.neighborsTab.Location = new System.Drawing.Point(4, 29);
            this.neighborsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.neighborsTab.Name = "neighborsTab";
            this.neighborsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.neighborsTab.Size = new System.Drawing.Size(592, 207);
            this.neighborsTab.TabIndex = 0;
            this.neighborsTab.Text = "Neighbors";
            this.neighborsTab.UseVisualStyleBackColor = true;
            // 
            // roomItemsTab
            // 
            this.roomItemsTab.Location = new System.Drawing.Point(4, 29);
            this.roomItemsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomItemsTab.Name = "roomItemsTab";
            this.roomItemsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomItemsTab.Size = new System.Drawing.Size(592, 207);
            this.roomItemsTab.TabIndex = 1;
            this.roomItemsTab.Text = "Items";
            this.roomItemsTab.UseVisualStyleBackColor = true;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(240, 45);
            this.roomDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomDescriptionTextBox.Multiline = true;
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(374, 126);
            this.roomDescriptionTextBox.TabIndex = 3;
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(240, 25);
            this.roomDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.roomDescriptionLabel.TabIndex = 2;
            this.roomDescriptionLabel.Text = "Description";
            // 
            // roomNameText
            // 
            this.roomNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.roomNameText.Location = new System.Drawing.Point(9, 45);
            this.roomNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomNameText.Name = "roomNameText";
            this.roomNameText.Size = new System.Drawing.Size(220, 26);
            this.roomNameText.TabIndex = 1;
            this.roomNameText.Text = "room name";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(9, 25);
            this.roomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(51, 20);
            this.roomLabel.TabIndex = 0;
            this.roomLabel.Text = "Name";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // RoomsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 483);
            this.Controls.Add(this.roomPropertiesBox);
            this.Controls.Add(roomsBox);
            this.Controls.Add(menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = menuStripMain;
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
    }
}

