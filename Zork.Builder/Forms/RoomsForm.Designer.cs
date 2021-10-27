
namespace Zork.Builder
{
    partial class RoomsForm
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
            this.roomsBox = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.ListBox();
            this.roomDataGroupBox = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.roomDescriptionBox = new System.Windows.Forms.TextBox();
            this.roomNameBox = new System.Windows.Forms.TextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.startLocationCheck = new System.Windows.Forms.CheckBox();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.worldTab = new System.Windows.Forms.TabControl();
            this.neighborsTabPage = new System.Windows.Forms.TabPage();
            this.upLabel = new System.Windows.Forms.Label();
            this.upComboBox = new System.Windows.Forms.ComboBox();
            this.downLabel = new System.Windows.Forms.Label();
            this.downComboBox = new System.Windows.Forms.ComboBox();
            this.westLabel = new System.Windows.Forms.Label();
            this.westComboBox = new System.Windows.Forms.ComboBox();
            this.eastLabel = new System.Windows.Forms.Label();
            this.eastComboBox = new System.Windows.Forms.ComboBox();
            this.southLabel = new System.Windows.Forms.Label();
            this.southComboBox = new System.Windows.Forms.ComboBox();
            this.northLabel = new System.Windows.Forms.Label();
            this.northComboBox = new System.Windows.Forms.ComboBox();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.roomsBox.SuspendLayout();
            this.roomDataGroupBox.SuspendLayout();
            this.worldTab.SuspendLayout();
            this.neighborsTabPage.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomsBox
            // 
            this.roomsBox.Controls.Add(this.Delete);
            this.roomsBox.Controls.Add(this.AddRoomButton);
            this.roomsBox.Controls.Add(this.Rooms);
            this.roomsBox.Location = new System.Drawing.Point(2, 5);
            this.roomsBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roomsBox.Name = "roomsBox";
            this.roomsBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roomsBox.Size = new System.Drawing.Size(206, 374);
            this.roomsBox.TabIndex = 3;
            this.roomsBox.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(107, 338);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(88, 27);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(8, 338);
            this.AddRoomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(88, 27);
            this.AddRoomButton.TabIndex = 4;
            this.AddRoomButton.Text = "Add";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // Rooms
            // 
            this.Rooms.DisplayMember = "Description";
            this.Rooms.FormattingEnabled = true;
            this.Rooms.ItemHeight = 15;
            this.Rooms.Location = new System.Drawing.Point(8, 12);
            this.Rooms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(186, 319);
            this.Rooms.TabIndex = 3;
            this.Rooms.ValueMember = "Description";
            // 
            // roomDataGroupBox
            // 
            this.roomDataGroupBox.Controls.Add(this.Save);
            this.roomDataGroupBox.Controls.Add(this.roomDescriptionLabel);
            this.roomDataGroupBox.Controls.Add(this.roomDescriptionBox);
            this.roomDataGroupBox.Controls.Add(this.roomNameBox);
            this.roomDataGroupBox.Controls.Add(this.roomNameLabel);
            this.roomDataGroupBox.Controls.Add(this.startLocationCheck);
            this.roomDataGroupBox.Location = new System.Drawing.Point(216, 5);
            this.roomDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roomDataGroupBox.Name = "roomDataGroupBox";
            this.roomDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roomDataGroupBox.Size = new System.Drawing.Size(442, 374);
            this.roomDataGroupBox.TabIndex = 4;
            this.roomDataGroupBox.TabStop = false;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(0, 82);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(88, 27);
            this.Save.TabIndex = 40;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(174, 9);
            this.roomDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.roomDescriptionLabel.TabIndex = 28;
            this.roomDescriptionLabel.Text = "Description";
            // 
            // roomDescriptionBox
            // 
            this.roomDescriptionBox.Location = new System.Drawing.Point(177, 27);
            this.roomDescriptionBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roomDescriptionBox.Multiline = true;
            this.roomDescriptionBox.Name = "roomDescriptionBox";
            this.roomDescriptionBox.Size = new System.Drawing.Size(250, 81);
            this.roomDescriptionBox.TabIndex = 27;
            // 
            // roomNameBox
            // 
            this.roomNameBox.Location = new System.Drawing.Point(7, 27);
            this.roomNameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roomNameBox.Name = "roomNameBox";
            this.roomNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roomNameBox.Size = new System.Drawing.Size(163, 23);
            this.roomNameBox.TabIndex = 25;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(4, 9);
            this.roomNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(39, 15);
            this.roomNameLabel.TabIndex = 26;
            this.roomNameLabel.Text = "Name";
            // 
            // startLocationCheck
            // 
            this.startLocationCheck.AutoSize = true;
            this.startLocationCheck.Location = new System.Drawing.Point(5, 57);
            this.startLocationCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startLocationCheck.Name = "startLocationCheck";
            this.startLocationCheck.Size = new System.Drawing.Size(135, 19);
            this.startLocationCheck.TabIndex = 24;
            this.startLocationCheck.Text = "Can be start location";
            this.startLocationCheck.UseVisualStyleBackColor = true;
            // 
            // itemsListView
            // 
            this.itemsListView.HideSelection = false;
            this.itemsListView.Location = new System.Drawing.Point(6, 7);
            this.itemsListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(405, 175);
            this.itemsListView.TabIndex = 39;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.List;
            // 
            // worldTab
            // 
            this.worldTab.Controls.Add(this.neighborsTabPage);
            this.worldTab.Controls.Add(this.itemsTabPage);
            this.worldTab.Location = new System.Drawing.Point(216, 120);
            this.worldTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.worldTab.Name = "worldTab";
            this.worldTab.SelectedIndex = 0;
            this.worldTab.Size = new System.Drawing.Size(428, 249);
            this.worldTab.TabIndex = 42;
            // 
            // neighborsTabPage
            // 
            this.neighborsTabPage.Controls.Add(this.upLabel);
            this.neighborsTabPage.Controls.Add(this.upComboBox);
            this.neighborsTabPage.Controls.Add(this.downLabel);
            this.neighborsTabPage.Controls.Add(this.downComboBox);
            this.neighborsTabPage.Controls.Add(this.westLabel);
            this.neighborsTabPage.Controls.Add(this.westComboBox);
            this.neighborsTabPage.Controls.Add(this.eastLabel);
            this.neighborsTabPage.Controls.Add(this.eastComboBox);
            this.neighborsTabPage.Controls.Add(this.southLabel);
            this.neighborsTabPage.Controls.Add(this.southComboBox);
            this.neighborsTabPage.Controls.Add(this.northLabel);
            this.neighborsTabPage.Controls.Add(this.northComboBox);
            this.neighborsTabPage.Location = new System.Drawing.Point(4, 24);
            this.neighborsTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.neighborsTabPage.Name = "neighborsTabPage";
            this.neighborsTabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.neighborsTabPage.Size = new System.Drawing.Size(420, 221);
            this.neighborsTabPage.TabIndex = 0;
            this.neighborsTabPage.Text = "Neighbors";
            this.neighborsTabPage.UseVisualStyleBackColor = true;
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Location = new System.Drawing.Point(197, 113);
            this.upLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(22, 15);
            this.upLabel.TabIndex = 50;
            this.upLabel.Text = "Up";
            // 
            // upComboBox
            // 
            this.upComboBox.FormattingEnabled = true;
            this.upComboBox.Location = new System.Drawing.Point(140, 132);
            this.upComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.upComboBox.Name = "upComboBox";
            this.upComboBox.Size = new System.Drawing.Size(140, 23);
            this.upComboBox.TabIndex = 49;
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Location = new System.Drawing.Point(188, 159);
            this.downLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(38, 15);
            this.downLabel.TabIndex = 48;
            this.downLabel.Text = "Down";
            // 
            // downComboBox
            // 
            this.downComboBox.FormattingEnabled = true;
            this.downComboBox.Location = new System.Drawing.Point(140, 178);
            this.downComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.downComboBox.Name = "downComboBox";
            this.downComboBox.Size = new System.Drawing.Size(140, 23);
            this.downComboBox.TabIndex = 47;
            // 
            // westLabel
            // 
            this.westLabel.AutoSize = true;
            this.westLabel.Location = new System.Drawing.Point(52, 37);
            this.westLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(33, 15);
            this.westLabel.TabIndex = 46;
            this.westLabel.Text = "West";
            // 
            // westComboBox
            // 
            this.westComboBox.FormattingEnabled = true;
            this.westComboBox.Location = new System.Drawing.Point(7, 54);
            this.westComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.westComboBox.Name = "westComboBox";
            this.westComboBox.Size = new System.Drawing.Size(140, 23);
            this.westComboBox.TabIndex = 45;
            // 
            // eastLabel
            // 
            this.eastLabel.AutoSize = true;
            this.eastLabel.Location = new System.Drawing.Point(318, 37);
            this.eastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eastLabel.Name = "eastLabel";
            this.eastLabel.Size = new System.Drawing.Size(28, 15);
            this.eastLabel.TabIndex = 44;
            this.eastLabel.Text = "East";
            // 
            // eastComboBox
            // 
            this.eastComboBox.FormattingEnabled = true;
            this.eastComboBox.Location = new System.Drawing.Point(271, 54);
            this.eastComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.eastComboBox.Name = "eastComboBox";
            this.eastComboBox.Size = new System.Drawing.Size(140, 23);
            this.eastComboBox.TabIndex = 43;
            // 
            // southLabel
            // 
            this.southLabel.AutoSize = true;
            this.southLabel.Location = new System.Drawing.Point(188, 67);
            this.southLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(38, 15);
            this.southLabel.TabIndex = 42;
            this.southLabel.Text = "South";
            // 
            // southComboBox
            // 
            this.southComboBox.FormattingEnabled = true;
            this.southComboBox.Location = new System.Drawing.Point(140, 85);
            this.southComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.southComboBox.Name = "southComboBox";
            this.southComboBox.Size = new System.Drawing.Size(140, 23);
            this.southComboBox.TabIndex = 41;
            // 
            // northLabel
            // 
            this.northLabel.AutoSize = true;
            this.northLabel.Location = new System.Drawing.Point(189, 5);
            this.northLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.northLabel.Name = "northLabel";
            this.northLabel.Size = new System.Drawing.Size(38, 15);
            this.northLabel.TabIndex = 40;
            this.northLabel.Text = "North";
            // 
            // northComboBox
            // 
            this.northComboBox.FormattingEnabled = true;
            this.northComboBox.Location = new System.Drawing.Point(140, 23);
            this.northComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.northComboBox.Name = "northComboBox";
            this.northComboBox.Size = new System.Drawing.Size(140, 23);
            this.northComboBox.TabIndex = 39;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemsListView);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 24);
            this.itemsTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.itemsTabPage.Size = new System.Drawing.Size(420, 221);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 381);
            this.Controls.Add(this.worldTab);
            this.Controls.Add(this.roomDataGroupBox);
            this.Controls.Add(this.roomsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "RoomsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zork Builder";
            this.roomsBox.ResumeLayout(false);
            this.roomDataGroupBox.ResumeLayout(false);
            this.roomDataGroupBox.PerformLayout();
            this.worldTab.ResumeLayout(false);
            this.neighborsTabPage.ResumeLayout(false);
            this.neighborsTabPage.PerformLayout();
            this.itemsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox roomsBox;
        private System.Windows.Forms.ListBox Rooms;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.GroupBox roomDataGroupBox;
        private System.Windows.Forms.TabControl worldTab;
        private System.Windows.Forms.TabPage neighborsTabPage;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.ComboBox westComboBox;
        private System.Windows.Forms.Label eastLabel;
        private System.Windows.Forms.ComboBox eastComboBox;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.ComboBox southComboBox;
        private System.Windows.Forms.Label northLabel;
        private System.Windows.Forms.ComboBox northComboBox;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.TextBox roomDescriptionBox;
        private System.Windows.Forms.TextBox roomNameBox;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.CheckBox startLocationCheck;
        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.ComboBox upComboBox;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.ComboBox downComboBox;
    }
}